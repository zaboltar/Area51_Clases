using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EntityData.StructLib;

public class CamBehaviour : MonoBehaviour {
    
    private TargetData defaultData;
    public TargetData data; //currentData

    Vector3 focusPoint { get { return data.target.position + GetRelativePos(data.target, data.focusDistance); }}
    Vector3 followPoint { get { return data.target.position + GetRelativePos(data.target, data.followDistance); } }
    public float followDistanceDelta { get { return Vector3.Distance(transform.position, followPoint); }}

    static public CamBehaviour main;

	private void Awake() {
        main = Camera.main.GetComponent<CamBehaviour>();
	}



	void Start () {
        //defaultData.SetFromVariables(target, focusDistance, followDistance, minFollowSpeed);
        defaultData = data;
	}
	
	
	void LateUpdate () {
        transform.position = Vector3.MoveTowards(transform.position, followPoint, ( data.minFollowSpeed + followDistanceDelta) * Time.deltaTime);
        
        transform.LookAt(focusPoint);
        // transform.lookat redirecciona en virtud del eje Z. El LookAt normaliza e iguala el Z hacia su target LookAteado. El eje Z
        // es una suerte del "forward" del obj.
        // la càmara es lo ùltimo que se updatea en el proceso de ejecuciòn, asì deberìa ser, por lo que corresponde
        // al late update, puesto que el mov de fìsica es ontològicamente anterior al dibujado, que en el ser, es posterior a 
        // los fenòmenos. 


	}


    Vector3 GetRelativePos (Transform relativeTarget, Vector3 distance) {
        Vector3 relativePos;
        relativePos = relativeTarget.right * distance.x;
        relativePos += relativeTarget.up * distance.y;
        relativePos += relativeTarget.forward * distance.z;

        return relativePos;
    }

	public void Reposition(Vector3 updatedPosition) {
        transform.position = updatedPosition;
	}

    public void ResetData() {
        data = defaultData;
    }

	void OnDrawGizmos() {

        if (data.target) {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(followPoint, focusPoint);
            Gizmos.DrawWireSphere(followPoint, 0.25f);
            Gizmos.color = Color.white;
            Gizmos.DrawSphere(focusPoint, 0.15f);

        }

	}
}

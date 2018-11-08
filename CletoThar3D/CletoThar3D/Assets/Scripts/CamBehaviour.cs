using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehaviour : MonoBehaviour {

    //[System.Serializable]
    public struct TargetData {
        public Transform target;
        public Vector3 focusDistance;
        public Vector3 followDistance;
        public float minFollowSpeed;
        public void SetFromVariables (Transform target, Vector3 focus, Vector3 follow, float minSpeed) {
            this.target = target;
            focusDistance = focus;
            followDistance = follow;
            minFollowSpeed = minSpeed;
        }
    }

    public Transform target;
    public Vector3 focusDistance;
    Vector3 focusPoint { get { return target.position + GetRelativePos(target, focusDistance); }}
    public Vector3 followDistance;
    Vector3 followPoint { get { return target.position + GetRelativePos(target, followDistance); } }
    public float minFollowSpeed = 1f;
    public float followDistanceDelta { get { return Vector3.Distance(transform.position, followPoint); }}

    public TargetData defaultData;

	
	void Start () {
        defaultData.SetFromVariables(target, focusDistance, followDistance, minFollowSpeed);
		
	}
	
	
	void LateUpdate () {
        transform.position = Vector3.MoveTowards(transform.position, followPoint, ( minFollowSpeed + followDistanceDelta) * Time.deltaTime);
        
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

	void OnDrawGizmos() {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(followPoint, focusPoint);
        Gizmos.DrawWireSphere(followPoint, 0.25f);
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(focusPoint, 0.15f);





    

	}
}

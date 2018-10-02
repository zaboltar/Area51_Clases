using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCtrl2D : MonoBehaviour {

   /* public Transform currentTarget;
    public Transform defaultTarget;
    public float speed;
    public Vector3 camPosition { get { return Camera.main.transform.position; }}
    public float[] axisLimits;

	// Use this for initialization
	void Start () {
		currentTarget = defaultTarget;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, ConvertToCamDepth(CheckCamLimit (target.position)) , speed * Time.deltaTime );


	}

    Vector3 CheckCamLimit (Vector3 vector) {
        if (target.position <= axisLimits[3] && camPosition.y <= axisLimits [3]) {
            vector.y = axisLimits[3];   // esto es solo para 1 limite
        }
        return vector;
    }


    Vector3 ConvertToCamDepth (Vector3 vector) {
        return new Vector3(vector.x,  vector.y, camPosition.z);
    }


    public void SwitchTarget (Transform target) {
    currentTarget = target == null ? defaultTarget : target;
    // esto es lo mismo q decir if (target ==null) {currentTarget = defaultTarget;} else {currentTarget = target;}
    }


*/

}

// deberia solo seguirme en eje y
// debe tener limitaciones en eje x
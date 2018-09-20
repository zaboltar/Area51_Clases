using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;

public class MovContinuo : MonoBehaviour {

    public float speed;
    public List<AxisPair> axes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movement = Vector3.zero;
        for (int i = 0; i < axes.Count; i++)
        {
            if(Input.GetKey(axes[i].keyCode)){
                movement += axes[i].direction;
            }
        }

        movement = movement.normalized * speed * Time.deltaTime;
        transform.Translate(movement);

    }
}

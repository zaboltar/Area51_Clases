using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;

public class MovCtrl2D : MonoBehaviour {

    public float speed;
    public float limitRight, limitLeft;

    /*[Serializable] //usar unity system para esto...esto define mov; es lo mismo [System.Serializable]
    public struct AxisPair {
       public KeyCode keyCode;
       public Vector3 direction;
    }*/

   public  List<AxisPair> axes;


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < axes.Count; i++)
        {
            if (Input.GetKeyDown(axes[i].keyCode) && !FindObstacle(axes[i].direction)){
                Debug.Log(FindObstacle(transform.position + axes[i].direction));
                transform.Translate(axes[i].direction);

            }
                
        }
    
    }



    bool FindObstacle(Vector3 direction){
        RaycastHit2D hit2D = Physics2D.Raycast (transform.position + direction, Vector3.forward);
        if (hit2D && hit2D.collider.CompareTag("movestible")){
            hit2D.collider.transform.Translate(direction);
        }

        return hit2D ? hit2D.collider.CompareTag("walls") : false;
    }





 
}

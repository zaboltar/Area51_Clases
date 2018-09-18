using System;
using System.Collections.Generic;
using UnityEngine;

public class MovCtrl2D : MonoBehaviour {

    public float speed;
    public float limitRight, limitLeft;

    [Serializable] //usar unity system para esto...esto define mov; es lo mismo [System.Serializable]
    public struct AxisPair {
       public KeyCode keyCode;
       public Vector3 direction;
    }

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
            if (Input.GetKeyDown(axes[i].keyCode)){
                transform.Translate(axes[i].direction);
            }
                
        }
    
    }

 
}

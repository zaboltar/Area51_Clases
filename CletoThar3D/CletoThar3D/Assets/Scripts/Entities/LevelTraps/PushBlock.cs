using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectStatesLib;

public class PushBlock : MonoBehaviour {

    Vector3 startPos;
    public Vector3 target;
    public float pushSpeed;
    bool performingAction;

    TrapState state;

	// Use this for initialization
	void Start () {
        startPos = transform.position;
        state = TrapState.Waiting;
	}
	
	// Update is called once per frame
	void Update () {

        if (!performingAction && transform.position != startPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos, 2f * Time.deltaTime);
        }
        else if (performingAction)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, pushSpeed * Time.deltaTime);
            if (transform.position == target)
            {
                performingAction = false;
            }
        }
		
	}

    void SelectStateAction()
    {
        switch (state)
        {
            case TrapState.Acting:
                if (GameControl.instance.inTransition)
                {
                    state = TrapState.Inactive;
                }
                else
                {
                    state = TrapState.Waiting;
                }
                break;
            case TrapState.Waiting:
                state = TrapState.Acting;
                break;
            case TrapState.Inactive:
                break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            performingAction = true;
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawCube(target, Vector3.one * 0.25f);
    }
}

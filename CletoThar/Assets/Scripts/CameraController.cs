using UnityEngine;

public class CameraController : MonoBehaviour {

public Transform target;
public float smoothSpeed = 0.25f;

public Vector3 offset;

		void LateUpdate () {
			transform.position = target.position + offset;
	}

}

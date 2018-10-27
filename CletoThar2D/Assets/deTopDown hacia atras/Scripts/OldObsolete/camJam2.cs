using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camJam2 : MonoBehaviour {

	public Vector3 offset;
	public Transform target;

	public BoxCollider2D boundBox;
	private Vector3 minBounds;
	private Vector3 maxBounds;

	private Camera theCamera;
	private float halfHeight;
	private float halfWidth;


	void Start(){
		minBounds = boundBox.bounds.min;
		maxBounds = boundBox.bounds.max;

		theCamera = GetComponent<Camera>();
		halfHeight = theCamera.orthographicSize;
		halfWidth = halfHeight * Screen.width / Screen.height;

		
	}

	void Update() {
		float clampedX = Mathf.Clamp(transform.position.x, minBounds.x + halfWidth, maxBounds.x - halfWidth);
		float clampedY = Mathf.Clamp(transform.position.y, minBounds.y + halfHeight, maxBounds.y - halfHeight);
		transform.position = new Vector3(clampedX, clampedY, transform.position.z);

		transform.position = target.position + offset;
	}


	void LateUpdate () {
       
       // transform.position = target.position + offset;

        
	}


}


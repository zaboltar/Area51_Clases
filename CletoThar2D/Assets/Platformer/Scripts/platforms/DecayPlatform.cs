using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecayPlatform : PlatformBehaviour {
	
	float currentValue;
	bool isActive;
	Collider2D platformCol;
	void Start () {
		platformCol = GetComponent<Collider2D>();
	}

	void Update () {
		if (isActive) {
			currentValue += Time.deltaTime;
			if (currentValue >= targetValue) {
				if (platformCol.enabled) {
					platformCol.enabled = false;
					currentValue = 0;
				} else {
					platformCol.enabled = true;
					isActive = false;
				}
			}
		}
	}

	public override void OnPlatformStep (GameObject reference = null) {
		if (!isActive) {
			isActive = true;
			currentValue = 0;
		}
	} 
}

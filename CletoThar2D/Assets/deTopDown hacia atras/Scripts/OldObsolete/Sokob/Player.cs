using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	
	public bool Move (Vector2 direction) { 
		
		if (Mathf.Abs(direction.x) < 0.5) { 
			direction.x = 0;
		} else 
		{
			direction.y = 0;
		}

		direction.Normalize();
		if (Blocked (transform.position, direction)) {
			return false;
		} else 	{
			transform.Translate(direction);
			return true;
		}
	}


	bool Blocked(Vector3 position, Vector2 direction){
		
		Vector2 newPos = new Vector2(position.x, position.y) + direction; // no leo bien si es mas o por -.-
		GameObject[] walls = GameObject.FindGameObjectsWithTag("SokoWall");
		foreach (var wall in walls)	{
			if (wall.transform.position.x == newPos.x && wall.transform.position.y == newPos.y){
				return true;
			}
		}
		GameObject[] boxes = GameObject.FindGameObjectsWithTag("SokoBox");
		foreach (var box in boxes)	{
			if (box.transform.position.x == newPos.x && box.transform.position.y == newPos.y ){
				Box bx = box.GetComponent<Box>();
				if (bx && bx.Move(direction)){
					return false;
				} else {
					return true;
				}
			}
		}
		return false;
	}


}

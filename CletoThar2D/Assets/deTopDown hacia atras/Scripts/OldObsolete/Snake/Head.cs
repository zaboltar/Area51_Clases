using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour {

	enum Direction {
		up,
		down,
		left,
		right
	}

	Direction direction;

	public List<Transform> Tail = new List<Transform>();

	public float frameRate = 0.2f;
	public float step = 0.16f; 

	public GameObject TailPrefab;

	public Vector2 horizRange;
	public Vector2 vertRange;

	private int score = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Move", frameRate, frameRate);
	}
	
	void Move() {
		lastpos = transform.position;


		Vector3 nextPos = Vector3.zero;
			if (direction == Direction.up)
				nextPos = Vector3.up;
				else if (direction == Direction.down)
				nextPos = Vector3.down;
				else if (direction == Direction.left)
				nextPos = Vector3.left;
				else if (direction == Direction.right)
				nextPos = Vector3.right;

			nextPos *= step;
			transform.position += nextPos;

			MoveTail();

	}

	Vector3 lastpos;
	void MoveTail(){
		for (int i = 0; i < Tail.Count; i++) {
			Vector3 temp = Tail[i].position;
			Tail[i].position = lastpos;
			lastpos = temp;
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
			direction = Direction.up;
		else if (Input.GetKeyDown(KeyCode.DownArrow))
			direction = Direction.down;
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			direction = Direction.left;
		else if (Input.GetKeyDown(KeyCode.RightArrow))
			direction = Direction.right;
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.CompareTag("walls")){
			print("Has perdido");
			UnityEngine.SceneManagement.SceneManager.LoadScene(3);
		}

		else if (col.CompareTag("snakeFood")){
			Tail.Add(Instantiate(TailPrefab, Tail[Tail.Count -1].position, Quaternion.identity).transform);
			col.transform.position = new Vector2 (Random.Range(horizRange.x, horizRange.y), Random.Range(vertRange.x, vertRange.y));
			score++;
			}
	}

	void OnGUI(){
        GUI.Label(new Rect(0, 0, 100, 50), "Score: " + score);	
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
	//public GameObject MovingBrick;
	public GameObject Brick;
	public GameObject[] MovingPoints;
	public float MovingSpeed = 2.0f;

	[Range(1.0f, 10.0f)]
	//private variables
	Transform _transform;
	int myPointIndex = 0;
	float _movetime;
	float Waitattime = 1.0f;
	bool loop = true;//will do looping?
	bool _moving = true;

	// Use this for initialization
	void Start () {
		_transform = Brick.transform;
		_movetime = 0f;
		_moving = true;

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= _movetime)
			Movement ();
		
	}

	void Movement(){
		if (MovingPoints.Length != 0 && _moving) {

			_transform.position = Vector3.MoveTowards (_transform.position,MovingPoints [myPointIndex].transform.position, MovingSpeed * Time.deltaTime);
			//make new wait point
			if (Vector3.Distance(MovingPoints [myPointIndex].transform.position, _transform.position) <= 0) {
				myPointIndex++;
				_movetime = Time.time + Waitattime;
			
			}


			if (myPointIndex >= MovingPoints.Length) {
				if (loop)
					myPointIndex = 0;
				else
					_moving = false;
			
			}
		}
	}
}

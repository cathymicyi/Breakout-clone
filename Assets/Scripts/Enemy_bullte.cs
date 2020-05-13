using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_bullte : MonoBehaviour {
	public GameObject ABullet;
	public Transform BulletPos;

	public float speed = 5.0f; 
	private float timer = 2.0f;//spawn every 5 sec

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", timer, timer);
		
	//	_ABColiision = GetComponent<Collider> ();
		
	}
	
	// Update is called once per frame
	void Update () {


	}
	void Spawn(){
		var bullets = (GameObject)Instantiate (ABullet, BulletPos.transform.position, BulletPos.transform.rotation);

	}



}

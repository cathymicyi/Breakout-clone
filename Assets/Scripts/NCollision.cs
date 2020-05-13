using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NCollision : MonoBehaviour {

//	public GameObject HitTo_;

	void Start () {



	}

	//detect bullet iself

	private  void OnCollisionEnter(Collision collision) {
		
		//hit the wall destroy itself
			Destroy (gameObject);


	}
}

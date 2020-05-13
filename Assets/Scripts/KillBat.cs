using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBat : MonoBehaviour {

// use to detect hit bat only

	private void  OnCollisionEnter(Collision collision) {
		
			Physics.IgnoreCollision (collision.collider, gameObject.GetComponent<SphereCollider> ());

		}

	private void OnTriggerEnter(Collider other){
		if (other.tag.Equals ("Bat")) {
			Destroy (gameObject);
		//	Destroy (other.gameObject);
		}
	}



}

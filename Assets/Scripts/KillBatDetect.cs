using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBatDetect : MonoBehaviour {
	public GameObject Target;

	private GameObject gameControllerObject;
	//Collider _col;
	void Start () {
	gameControllerObject = GameObject.Find("GameController");
	
	
	}


	// Update is called once per frame
	void Update () {


	}

	private void  OnCollisionEnter(Collision collision) {
		if (gameObject.tag.Equals( "Enemy")) {
			Physics.IgnoreCollision (collision.collider, gameObject.GetComponent<SphereCollider> ());
			//collider.enable = false;
		}
		if (Target.tag.Equals( "DestroyMe")) {

			Destroy (Target);
			Destroy (gameObject);//destroy itself
			gameControllerObject.GetComponent<GameController> ().lives -= 1;
		}

	}
}

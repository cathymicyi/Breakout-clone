using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour {

    private GameObject gameControllerObject;


	void Start () {
        gameControllerObject = GameObject.Find("GameController");
	
	
		}


	//Hit by player's bullet, destroy itself and bullet
  /*  private void OnCollisionEnter(Collision collision) {
		if (gameObject.tag =="Ball") {
			
				Destroy (gameObject);
			   // Destroy (HitBy_);
			     
				gameControllerObject.GetComponent<GameController> ().scores += 1;

				gameControllerObject.GetComponent<GameController> ().numberOfBricks -= 1;
			}

	}*/
	private void OnTriggerEnter(Collider other){

		if (other.tag.Equals ("Bullet")) {
			Destroy (gameObject);

			Destroy (other.gameObject);
		
			gameControllerObject.GetComponent<GameController> ().scores += 1;

			gameControllerObject.GetComponent<GameController> ().numberOfBricks -= 1;
		
		}
	
	
	}

}

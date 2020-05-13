using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseLives : MonoBehaviour {

    public GameObject gameControllerObject;
    public GameObject bat;

	Vector3 _trans;

	void Start(){
		_trans = bat.transform.position;
	}
    private void OnTriggerEnter(Collider other) {
		
        if (other.tag.Equals("EnemyBullet")) {
			Debug.Log (other.gameObject.name);
			Destroy(other.gameObject);
            gameControllerObject.GetComponent<GameController>().lives -= 1;

            if(gameControllerObject.GetComponent<GameController>().lives > 0) {
				//tmp.transform.parent = bat.transform;
               // GameObject newBat = Instantiate(batPrefab);
				gameObject.transform.position = _trans;
                //newBat.transform.position = new Vector3(bat.transform.position.x, bat.transform.position.y+1f, bat.transform.position.z);
                //newBat.transform.parent = bat.transform;

				Debug.Log (gameObject.name);
            }
			//Destroy (gameObject);
        }



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
	
	public GameObject Bullet;
	public Transform BulletPos;
	public float speed = 10.0f;
	public AudioClip ShootSound;

	
	// Update is called once per frame
	void Update () {
		//set Fire1 is pressing space(fire)
		if (Input.GetButtonDown ("Fire1")) {
			
			var bullets = (GameObject)Instantiate (Bullet, BulletPos.transform.position, BulletPos.transform.rotation);

			bullets.GetComponent<Rigidbody> ().velocity = bullets.transform.forward*speed;

			if(ShootSound)
			{
				if (bullets.GetComponent<AudioSource> ())
					bullets.GetComponent<AudioSource> ().PlayOneShot (ShootSound);
				else//create new audio source 
					AudioSource.PlayClipAtPoint(ShootSound, bullets.transform.position);


			}
			Debug.Log("Fire");

		
		}
		
	}

}

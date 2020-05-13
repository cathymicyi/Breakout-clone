using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour {

    public float initialSpeed = 500f;



    private Rigidbody rb;
    private bool launched;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && launched == false) {

            transform.parent = null;
            launched = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(initialSpeed, initialSpeed,0));

        }
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBat : MonoBehaviour {

    public float speed = 0.5f;

    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Horizontal")*speed;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + translation,-10,10), transform.position.y,transform.position.z) ;
	}
}

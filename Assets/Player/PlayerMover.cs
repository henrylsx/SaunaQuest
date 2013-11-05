﻿using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour {
	public float forwardSpeed = 1.0f;
	public float backwardSpeed = 1.0f;
	public float turnRate = 1.0f;
		

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   if (Input.GetKey( KeyCode.W) ) {
			transform.position += transform.forward * forwardSpeed * Time.deltaTime;
		}
			   if (Input.GetKey( KeyCode.S) ) {
			transform.position -= transform.forward * backwardSpeed * Time.deltaTime;
		}
		if (Input.GetKey( KeyCode.A) ) {
			transform.Rotate(0.0f, -turnRate * Time.deltaTime, 0.0f);
		}
		if (Input.GetKey( KeyCode.D) ) {
			transform.Rotate(0.0f, turnRate  * Time.deltaTime, 0.0f);
		}

	}
}
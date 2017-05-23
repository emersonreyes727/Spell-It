﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {
	[SerializeField] private GameObject ball;
	[SerializeField] private Transform ballResetPosition;

	private float distance = 10f;
	private RaycastHit hit;

	// Use this for initialization
	void Start () {
		
	}
	
	// 
	void FixedUpdate () {
		Vector3 forward = transform.TransformDirection (Vector3.forward) * distance;
		Debug.DrawRay (transform.position, forward, Color.red);

		if (Physics.Raycast (transform.position, forward, out hit)) {
			if (Input.GetMouseButtonDown(0)) {
				ShootBall ();
			}	
		}
	}

	void ShootBall () {
		Instantiate (ball, transform.position, transform.rotation, ballResetPosition);
		Debug.Log ("shoot");
	}
}
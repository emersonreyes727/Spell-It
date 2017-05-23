﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour {
	[SerializeField] private GameObject ball;
	[SerializeField] private Transform ballResetPosition;

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			ShootTheBall ();
		}	
	}

	void ShootTheBall () {
		Instantiate (ball, transform.position, transform.rotation, ballResetPosition);
		Debug.Log ("Shoot the ball");
	}


}
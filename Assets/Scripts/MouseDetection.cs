﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDetection : MonoBehaviour {
	// disable the "shootball" script when it enter a button or waypoint so it won't 
	// shoot the ball when you click the button

	public void OnMouseEnter () {
		GameObject.Find("Main Camera").GetComponent<ShootBall>().enabled = false;
		Debug.Log ("enter");

	}

	public void OnMouseExit () {
		GameObject.Find("Main Camera").GetComponent<ShootBall>().enabled = true;
		//GameObject.Find("cursor").GetComponent<JoshsMenu> ().enabled = false;
		Debug.Log ("exit");
	}
}

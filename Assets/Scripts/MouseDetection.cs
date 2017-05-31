using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDetection : MonoBehaviour {

	//
	void Start () {

	}

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

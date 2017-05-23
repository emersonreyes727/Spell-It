using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEnter : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Ball") {
			Debug.Log ("Ball Enter");
		}
	}
}

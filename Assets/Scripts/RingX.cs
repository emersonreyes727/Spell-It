using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingX : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Ball") {
			GameManager.instance.XisHit ();
		}
	}
}

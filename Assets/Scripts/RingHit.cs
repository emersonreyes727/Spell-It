using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingHit : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		if (other.tag == "A") {
			GameManager.instance.AisHit ();
		}

		if (other.tag == "X") {
			GameManager.instance.XisHit ();
		}

		if (other.tag == "T") {
			GameManager.instance.TisHit ();
		}

		if (other.tag == "Y") {
			GameManager.instance.YisHit ();
		}

		if (other.tag == "G") {
			GameManager.instance.GisHit ();
		}

		if (other.tag == "Z") {
			GameManager.instance.ZisHit ();
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingHit : MonoBehaviour {

	// when ball hits the ring cube colliders
	void OnTriggerEnter (Collider other) {
		if (other.tag == "X") {
			GameManager.instance.XisHit ();
		}

		if (other.tag == "Y") {
			GameManager.instance.YisHit ();
		}

		if (other.tag == "Z") {
			GameManager.instance.ZisHit ();
		}

		//
		if (other.tag == "C") {
			GameManager.instance.CisHit ();
		}

		if (other.tag == "A") {
			GameManager.instance.AisHit ();
		}

		if (other.tag == "T") {
			GameManager.instance.TisHit ();
		}

		if (other.tag == "T2") {
			GameManager.instance.T2isHit ();
		}
			
		if (other.tag == "I") {
			GameManager.instance.IisHit ();
		}

		if (other.tag == "G") {
			GameManager.instance.GisHit ();
		}

		if (other.tag == "E") {
			GameManager.instance.EisHit ();
		}

		if (other.tag == "R") {
			GameManager.instance.RisHit ();
		}

		if (other.tag == "B") {
			GameManager.instance.BisHit ();
		}

		if (other.tag == "I2") {
			GameManager.instance.I2isHit ();
		}

		if (other.tag == "R2") {
			GameManager.instance.R2isHit ();
		}

		if (other.tag == "D") {
			GameManager.instance.DisHit ();
		}
	}
}

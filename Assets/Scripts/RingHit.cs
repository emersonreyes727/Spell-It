using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingHit : MonoBehaviour {

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

		if (other.tag == "G2") {
			GameManager.instance.G2isHit ();
		}

		if (other.tag == "O") {
			GameManager.instance.OisHit ();
		}

		if (other.tag == "R2") {
			GameManager.instance.R2isHit ();
		}

		if (other.tag == "I2") {
			GameManager.instance.I2isHit ();
		}

		if (other.tag == "L") {
			GameManager.instance.LisHit ();
		}

		if (other.tag == "L2") {
			GameManager.instance.L2isHit ();
		}

		if (other.tag == "A2") {
			GameManager.instance.A2isHit ();
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallEnter : MonoBehaviour {
	[SerializeField] private Text letterA;
	private int shotMade;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "A") {
			GameManager.instance.AisHit ();
		}

		else if (other.tag == "X") {
			GameManager.instance.XisHit ();
		}
	}
}

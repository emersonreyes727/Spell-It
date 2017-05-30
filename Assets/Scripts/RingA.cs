using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingA : MonoBehaviour {
	[SerializeField] private float startPosition;
	[SerializeField] private float resetPosition;
	private float speed = 2f;

	// 
	void Update () {
		transform.Translate (Vector3.right * (speed * Time.deltaTime));

		if (transform.localPosition.x > resetPosition) {
			transform.position = new Vector3 (startPosition, transform.position.y, transform.position.z);
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Ball") {
			GameManager.instance.AisHit ();
		}
	}
}

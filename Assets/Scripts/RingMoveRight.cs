using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingMoveRight : MonoBehaviour {
	private float startPosition = 4f;
	private float resetPosition = 17f;
	private float speed = 1f;
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * (speed * Time.deltaTime));

		if (transform.localPosition.x >= resetPosition) {
			transform.position = new Vector3 (startPosition, transform.position.y, transform.position.z);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingMoveLeft : MonoBehaviour {
	private float startPosition = 13f;
	private float resetPosition = 7f;
	private float speed = 0.5f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * (speed * Time.deltaTime));

		if (transform.localPosition.x <= resetPosition) {
			transform.position = new Vector3 (startPosition, transform.position.y, transform.position.z);
		}
	}
}

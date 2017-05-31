using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private float force = 0.10f;
	private Rigidbody rb;
	private bool addOnce = true;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (addOnce) {
			rb.AddForce (transform.forward * force, ForceMode.Impulse);
			addOnce = false;
		}
	}
}

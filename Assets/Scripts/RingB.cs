using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingB : MonoBehaviour {
	private Rigidbody rb;
	private bool justOnce = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// 
	void FixedUpdate () {
		if (!justOnce) {
			rb.AddForce (transform.up * 10f, ForceMode.Impulse);	
			justOnce = true;
		}
	}
}

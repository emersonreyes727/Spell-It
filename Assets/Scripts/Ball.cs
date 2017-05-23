using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private float force = 0.2f;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// 
	void FixedUpdate () {
		rb.AddForce (transform.forward * (force * Time.deltaTime), ForceMode.Impulse);
	}
}

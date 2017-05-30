using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
	[SerializeField] private float force;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {
	[SerializeField] private GameObject exit;

	private ShootBall shootBall;
	private float rayLength = 40f; 
	private RaycastHit hit;

	// Use this for initialization
	void Start () {
		shootBall = GetComponent<ShootBall> ();	
	}
	
	// 
	void FixedUpdate () {
		Vector3 forward = transform.TransformDirection (Vector3.forward) * rayLength;
		Debug.DrawRay (transform.position, forward, Color.green);

		if (Physics.Raycast (transform.position, forward, out hit)) {
			
		}
	}
}

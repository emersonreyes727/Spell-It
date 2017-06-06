using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {
	[SerializeField] private GameObject reticlePointer;

	private RaycastHit hit;
	
	//
	void FixedUpdate () {
		Vector3 forward = transform.TransformDirection (Vector3.forward * 40f);
		Debug.DrawRay (transform.position, forward, Color.red);

		if (Physics.Raycast (transform.position, forward, out hit)) {
			if (hit.collider.tag == "RemoveReticlePointer" || hit.collider.tag == "Ring" || hit.collider.tag == "Ball" || 
				hit.collider.tag == "C" || hit.collider.tag == "A" || hit.collider.tag == "T" || hit.collider.tag == "T2" ||
				hit.collider.tag == "I" || hit.collider.tag == "G" || hit.collider.tag == "E" || hit.collider.tag == "R" ||
				hit.collider.tag == "B" || hit.collider.tag == "I2" || hit.collider.tag == "R2" || hit.collider.tag == "D" ||
				hit.collider.tag == "X" || hit.collider.tag == "Y" || hit.collider.tag == "Z") {

				reticlePointer.SetActive (false);
			} else {
				reticlePointer.SetActive (true);
			}
		}
	}
}

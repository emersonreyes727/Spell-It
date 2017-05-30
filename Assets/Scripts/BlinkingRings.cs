using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingRings : MonoBehaviour {
	[SerializeField] private float topLeft;
	[SerializeField] private float topRight;
	[SerializeField] private float bottomRight;
	[SerializeField] private float bottomLeft;
	[SerializeField] private GameObject ringB;
	[SerializeField] private GameObject ringX2;

	private float speed = 1f;
	private bool justOnce = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (ringB.transform.localPosition.y >= topLeft) {
			ringB.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringB.transform.position = new Vector3 (ringB.transform.position.x, 10f, ringB.transform.position.z);
		}  

		if (ringB.transform.localPosition.x >= topRight) {
			ringB.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringB.transform.position = new Vector3 (5f, ringB.transform.position.y, ringB.transform.position.z);
		}  

		if (ringB.transform.localPosition.y <= bottomRight) {
			ringB.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringB.transform.position = new Vector3 (ringB.transform.position.x, 2f, ringB.transform.position.z);
		}  

		if (ringB.transform.localPosition.x <= bottomLeft) {
			ringB.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringB.transform.position = new Vector3 (-3f, ringB.transform.position.y, ringB.transform.position.z);
		}

		if (ringX2.transform.localPosition.y >= topLeft) {
			ringX2.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringX2.transform.position = new Vector3 (ringX2.transform.position.x, 10f, ringX2.transform.position.z);
		}  

		if (ringX2.transform.localPosition.x >= topRight) {
			ringX2.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringX2.transform.position = new Vector3 (5f, ringX2.transform.position.y, ringX2.transform.position.z);
		}  

		if (ringX2.transform.localPosition.y <= bottomRight) {
			ringX2.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringX2.transform.position = new Vector3 (ringX2.transform.position.x, 2f, ringX2.transform.position.z);
		}  

		if (ringX2.transform.localPosition.x <= bottomLeft) {
			ringX2.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringX2.transform.position = new Vector3 (-3f, ringX2.transform.position.y, ringX2.transform.position.z);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class RingMoveAround : MonoBehaviour {
	// moves the bird rings around
	[SerializeField] private GameObject ringB;
	[SerializeField] private GameObject ringI2;
	[SerializeField] private GameObject ringR2;
	[SerializeField] private GameObject ringD;

	[SerializeField] private GameObject ringZu;
	[SerializeField] private GameObject ringZs;
	[SerializeField] private GameObject ringZq;
	[SerializeField] private GameObject ringZc;

	private float topLeft = 4.5f; 
	private float topRight = 31f; 
	private float bottomRight = 3.5f; 
	private float bottomLeft = 28f; 

	private float speed = 0.5f;

	//
	void Awake () {
		Assert.IsNotNull (ringB);
		Assert.IsNotNull (ringI2);
		Assert.IsNotNull (ringR2);
		Assert.IsNotNull (ringD);

		Assert.IsNotNull (ringZu);
		Assert.IsNotNull (ringZs);
		Assert.IsNotNull (ringZq);
		Assert.IsNotNull (ringZc);
	}
	//
	void Update () {
		// ringB move
		if (ringB.transform.localPosition.y >= topLeft) {
			ringB.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringB.transform.position = new Vector3 (ringB.transform.position.x, topLeft, ringB.transform.position.z);
		}  

		if (ringB.transform.localPosition.x >= topRight) {
			ringB.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringB.transform.position = new Vector3 (topRight, ringB.transform.position.y, ringB.transform.position.z);
		}  
	

		if (ringB.transform.localPosition.y <= bottomRight) {
			ringB.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringB.transform.position = new Vector3 (ringB.transform.position.x, bottomRight, ringB.transform.position.z);
		}  

		if (ringB.transform.localPosition.x <= bottomLeft) {
			ringB.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringB.transform.position = new Vector3 (bottomLeft, ringB.transform.position.y, ringB.transform.position.z);
		}

		// ringI2 move
		if (ringI2.transform.localPosition.y >= topLeft) {
			ringI2.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringI2.transform.position = new Vector3 (ringI2.transform.position.x, topLeft, ringI2.transform.position.z);
		}  

		if (ringI2.transform.localPosition.x >= topRight) {
			ringI2.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringI2.transform.position = new Vector3 (topRight, ringI2.transform.position.y, ringI2.transform.position.z);
		}  


		if (ringI2.transform.localPosition.y <= bottomRight) {
			ringI2.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringI2.transform.position = new Vector3 (ringI2.transform.position.x, bottomRight, ringI2.transform.position.z);
		}  

		if (ringI2.transform.localPosition.x <= bottomLeft) {
			ringI2.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringI2.transform.position = new Vector3 (bottomLeft, ringI2.transform.position.y, ringI2.transform.position.z);
		}

		// ringR2 move
		if (ringR2.transform.localPosition.y >= topLeft) {
			ringR2.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringR2.transform.position = new Vector3 (ringR2.transform.position.x, topLeft, ringR2.transform.position.z);
		}  

		if (ringR2.transform.localPosition.x >= topRight) {
			ringR2.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringR2.transform.position = new Vector3 (topRight, ringR2.transform.position.y, ringR2.transform.position.z);
		}  


		if (ringR2.transform.localPosition.y <= bottomRight) {
			ringR2.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringR2.transform.position = new Vector3 (ringR2.transform.position.x, bottomRight, ringR2.transform.position.z);
		}  

		if (ringR2.transform.localPosition.x <= bottomLeft) {
			ringR2.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringR2.transform.position = new Vector3 (bottomLeft, ringR2.transform.position.y, ringR2.transform.position.z);
		}
			
		// ringD move
		if (ringD.transform.localPosition.y >= topLeft) {
			ringD.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringD.transform.position = new Vector3 (ringD.transform.position.x, topLeft, ringD.transform.position.z);
		}  

		if (ringD.transform.localPosition.x >= topRight) {
			ringD.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringD.transform.position = new Vector3 (topRight, ringD.transform.position.y, ringD.transform.position.z);
		}  


		if (ringD.transform.localPosition.y <= bottomRight) {
			ringD.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringD.transform.position = new Vector3 (ringD.transform.position.x, bottomRight, ringD.transform.position.z);
		}  

		if (ringD.transform.localPosition.x <= bottomLeft) {
			ringD.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringD.transform.position = new Vector3 (bottomLeft, ringD.transform.position.y, ringD.transform.position.z);
		}
			
		// ringZu move
		if (ringZu.transform.localPosition.y >= topLeft) {
			ringZu.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringZu.transform.position = new Vector3 (ringZu.transform.position.x, topLeft, ringZu.transform.position.z);
		}  

		if (ringZu.transform.localPosition.x >= topRight) {
			ringZu.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringZu.transform.position = new Vector3 (topRight, ringZu.transform.position.y, ringZu.transform.position.z);
		}  


		if (ringZu.transform.localPosition.y <= bottomRight) {
			ringZu.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringZu.transform.position = new Vector3 (ringZu.transform.position.x, bottomRight, ringZu.transform.position.z);
		}  

		if (ringZu.transform.localPosition.x <= bottomLeft) {
			ringZu.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringZu.transform.position = new Vector3 (bottomLeft, ringZu.transform.position.y, ringZu.transform.position.z);
		}

		// ringZs move
		if (ringZs.transform.localPosition.y >= topLeft) {
			ringZs.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringZs.transform.position = new Vector3 (ringZs.transform.position.x, topLeft, ringZs.transform.position.z);
		}  

		if (ringZs.transform.localPosition.x >= topRight) {
			ringZs.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringZs.transform.position = new Vector3 (topRight, ringZs.transform.position.y, ringZs.transform.position.z);
		}  


		if (ringZs.transform.localPosition.y <= bottomRight) {
			ringZs.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringZs.transform.position = new Vector3 (ringZs.transform.position.x, bottomRight, ringZs.transform.position.z);
		}  

		if (ringZs.transform.localPosition.x <= bottomLeft) {
			ringZs.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringZs.transform.position = new Vector3 (bottomLeft, ringZs.transform.position.y, ringZs.transform.position.z);
		}

		// ringZq move
		if (ringZq.transform.localPosition.y >= topLeft) {
			ringZq.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringZq.transform.position = new Vector3 (ringZq.transform.position.x, topLeft, ringZq.transform.position.z);
		}  

		if (ringZq.transform.localPosition.x >= topRight) {
			ringZq.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringZq.transform.position = new Vector3 (topRight, ringZq.transform.position.y, ringZq.transform.position.z);
		}  


		if (ringZq.transform.localPosition.y <= bottomRight) {
			ringZq.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringZq.transform.position = new Vector3 (ringZq.transform.position.x, bottomRight, ringZq.transform.position.z);
		}  

		if (ringZq.transform.localPosition.x <= bottomLeft) {
			ringZq.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringZq.transform.position = new Vector3 (bottomLeft, ringZq.transform.position.y, ringZq.transform.position.z);
		}
			
		// ringZc move
		if (ringZc.transform.localPosition.y >= topLeft) {
			ringZc.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringZc.transform.position = new Vector3 (ringZc.transform.position.x, topLeft, ringZc.transform.position.z);
		}  

		if (ringZc.transform.localPosition.x >= topRight) {
			ringZc.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringZc.transform.position = new Vector3 (topRight, ringZc.transform.position.y, ringZc.transform.position.z);
		}  


		if (ringZc.transform.localPosition.y <= bottomRight) {
			ringZc.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringZc.transform.position = new Vector3 (ringZc.transform.position.x, bottomRight, ringZc.transform.position.z);
		}  

		if (ringZc.transform.localPosition.x <= bottomLeft) {
			ringZc.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringZc.transform.position = new Vector3 (bottomLeft, ringZc.transform.position.y, ringZc.transform.position.z);
		}
	}
}

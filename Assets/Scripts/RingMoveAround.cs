using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class RingMoveAround : MonoBehaviour {
	[SerializeField] private float topLeft; 
	[SerializeField] private float topRight; 
	[SerializeField] private float bottomRight; 
	[SerializeField] private float bottomLeft; 

	[SerializeField] private GameObject ringG2;
	[SerializeField] private GameObject ringO;
	[SerializeField] private GameObject ringR2;
	[SerializeField] private GameObject ringI2;
	[SerializeField] private GameObject ringL;
	[SerializeField] private GameObject ringL2;
	[SerializeField] private GameObject ringA2;
	[SerializeField] private GameObject ringZe;
	[SerializeField] private GameObject ringZu;
	[SerializeField] private GameObject ringZb;
	[SerializeField] private GameObject ringZs;
	[SerializeField] private GameObject ringZw;
	[SerializeField] private GameObject ringZp;
	[SerializeField] private GameObject ringZq;
	[SerializeField] private GameObject ringZv;
	[SerializeField] private GameObject ringZc;


	private float speed = 0.5f;

	//
	void Update () {
		// ringG2 move
		if (ringG2.transform.localPosition.y >= topLeft) {
			ringG2.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringG2.transform.position = new Vector3 (ringG2.transform.position.x, topLeft, ringG2.transform.position.z);
		}  

		if (ringG2.transform.localPosition.x >= topRight) {
			ringG2.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringG2.transform.position = new Vector3 (topRight, ringG2.transform.position.y, ringG2.transform.position.z);
		}  
	

		if (ringG2.transform.localPosition.y <= bottomRight) {
			ringG2.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringG2.transform.position = new Vector3 (ringG2.transform.position.x, bottomRight, ringG2.transform.position.z);
		}  

		if (ringG2.transform.localPosition.x <= bottomLeft) {
			ringG2.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringG2.transform.position = new Vector3 (bottomLeft, ringG2.transform.position.y, ringG2.transform.position.z);
		}

		// ringO move
		if (ringO.transform.localPosition.y >= topLeft) {
			ringO.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringO.transform.position = new Vector3 (ringO.transform.position.x, topLeft, ringO.transform.position.z);
		}  

		if (ringO.transform.localPosition.x >= topRight) {
			ringO.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringO.transform.position = new Vector3 (topRight, ringO.transform.position.y, ringO.transform.position.z);
		}  


		if (ringO.transform.localPosition.y <= bottomRight) {
			ringO.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringO.transform.position = new Vector3 (ringO.transform.position.x, bottomRight, ringO.transform.position.z);
		}  

		if (ringO.transform.localPosition.x <= bottomLeft) {
			ringO.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringO.transform.position = new Vector3 (bottomLeft, ringO.transform.position.y, ringO.transform.position.z);
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

		// ringL move
		if (ringL.transform.localPosition.y >= topLeft) {
			ringL.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringL.transform.position = new Vector3 (ringL.transform.position.x, topLeft, ringL.transform.position.z);
		}  

		if (ringL.transform.localPosition.x >= topRight) {
			ringL.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringL.transform.position = new Vector3 (topRight, ringL.transform.position.y, ringL.transform.position.z);
		}  


		if (ringL.transform.localPosition.y <= bottomRight) {
			ringL.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringL.transform.position = new Vector3 (ringL.transform.position.x, bottomRight, ringL.transform.position.z);
		}  

		if (ringL.transform.localPosition.x <= bottomLeft) {
			ringL.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringL.transform.position = new Vector3 (bottomLeft, ringL.transform.position.y, ringL.transform.position.z);
		}

		// ringL2 move
		if (ringL2.transform.localPosition.y >= topLeft) {
			ringL2.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringL2.transform.position = new Vector3 (ringL2.transform.position.x, topLeft, ringL2.transform.position.z);
		}  

		if (ringL2.transform.localPosition.x >= topRight) {
			ringL2.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringL2.transform.position = new Vector3 (topRight, ringL2.transform.position.y, ringL2.transform.position.z);
		}  


		if (ringL2.transform.localPosition.y <= bottomRight) {
			ringL2.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringL2.transform.position = new Vector3 (ringL2.transform.position.x, bottomRight, ringL2.transform.position.z);
		}  

		if (ringL2.transform.localPosition.x <= bottomLeft) {
			ringL2.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringL2.transform.position = new Vector3 (bottomLeft, ringL2.transform.position.y, ringL2.transform.position.z);
		}

		// ringA2 move
		if (ringA2.transform.localPosition.y >= topLeft) {
			ringA2.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringA2.transform.position = new Vector3 (ringA2.transform.position.x, topLeft, ringA2.transform.position.z);
		}  

		if (ringA2.transform.localPosition.x >= topRight) {
			ringA2.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringA2.transform.position = new Vector3 (topRight, ringA2.transform.position.y, ringA2.transform.position.z);
		}  


		if (ringA2.transform.localPosition.y <= bottomRight) {
			ringA2.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringA2.transform.position = new Vector3 (ringA2.transform.position.x, bottomRight, ringA2.transform.position.z);
		}  

		if (ringA2.transform.localPosition.x <= bottomLeft) {
			ringA2.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringA2.transform.position = new Vector3 (bottomLeft, ringA2.transform.position.y, ringA2.transform.position.z);
		}

		// ringZe move
		if (ringZe.transform.localPosition.y >= topLeft) {
			ringZe.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringZe.transform.position = new Vector3 (ringZe.transform.position.x, topLeft, ringZe.transform.position.z);
		}  

		if (ringZe.transform.localPosition.x >= topRight) {
			ringZe.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringZe.transform.position = new Vector3 (topRight, ringZe.transform.position.y, ringZe.transform.position.z);
		}  


		if (ringZe.transform.localPosition.y <= bottomRight) {
			ringZe.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringZe.transform.position = new Vector3 (ringZe.transform.position.x, bottomRight, ringZe.transform.position.z);
		}  

		if (ringZe.transform.localPosition.x <= bottomLeft) {
			ringZe.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringZe.transform.position = new Vector3 (bottomLeft, ringZe.transform.position.y, ringZe.transform.position.z);
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

		// ringZb move
		if (ringZb.transform.localPosition.y >= topLeft) {
			ringZb.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringZb.transform.position = new Vector3 (ringZb.transform.position.x, topLeft, ringZb.transform.position.z);
		}  

		if (ringZb.transform.localPosition.x >= topRight) {
			ringZb.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringZb.transform.position = new Vector3 (topRight, ringZb.transform.position.y, ringZb.transform.position.z);
		}  


		if (ringZb.transform.localPosition.y <= bottomRight) {
			ringZb.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringZb.transform.position = new Vector3 (ringZb.transform.position.x, bottomRight, ringZb.transform.position.z);
		}  

		if (ringZb.transform.localPosition.x <= bottomLeft) {
			ringZb.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringZb.transform.position = new Vector3 (bottomLeft, ringZb.transform.position.y, ringZb.transform.position.z);
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

		// ringZw move
		if (ringZw.transform.localPosition.y >= topLeft) {
			ringZw.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringZw.transform.position = new Vector3 (ringZw.transform.position.x, topLeft, ringZw.transform.position.z);
		}  

		if (ringZw.transform.localPosition.x >= topRight) {
			ringZw.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringZw.transform.position = new Vector3 (topRight, ringZw.transform.position.y, ringZw.transform.position.z);
		}  


		if (ringZw.transform.localPosition.y <= bottomRight) {
			ringZw.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringZw.transform.position = new Vector3 (ringZw.transform.position.x, bottomRight, ringZw.transform.position.z);
		}  

		if (ringZw.transform.localPosition.x <= bottomLeft) {
			ringZw.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringZw.transform.position = new Vector3 (bottomLeft, ringZw.transform.position.y, ringZw.transform.position.z);
		}

		// ringZp move
		if (ringZp.transform.localPosition.y >= topLeft) {
			ringZp.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringZp.transform.position = new Vector3 (ringZp.transform.position.x, topLeft, ringZp.transform.position.z);
		}  

		if (ringZp.transform.localPosition.x >= topRight) {
			ringZp.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringZp.transform.position = new Vector3 (topRight, ringZp.transform.position.y, ringZp.transform.position.z);
		}  


		if (ringZp.transform.localPosition.y <= bottomRight) {
			ringZp.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringZp.transform.position = new Vector3 (ringZp.transform.position.x, bottomRight, ringZp.transform.position.z);
		}  

		if (ringZp.transform.localPosition.x <= bottomLeft) {
			ringZp.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringZp.transform.position = new Vector3 (bottomLeft, ringZp.transform.position.y, ringZp.transform.position.z);
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

		// ringZv move
		if (ringZv.transform.localPosition.y >= topLeft) {
			ringZv.transform.Translate (Vector3.right * (speed * Time.deltaTime));
			ringZv.transform.position = new Vector3 (ringZv.transform.position.x, topLeft, ringZv.transform.position.z);
		}  

		if (ringZv.transform.localPosition.x >= topRight) {
			ringZv.transform.Translate (Vector3.down * (speed * Time.deltaTime));
			ringZv.transform.position = new Vector3 (topRight, ringZv.transform.position.y, ringZv.transform.position.z);
		}  


		if (ringZv.transform.localPosition.y <= bottomRight) {
			ringZv.transform.Translate (Vector3.left * (speed * Time.deltaTime));
			ringZv.transform.position = new Vector3 (ringZv.transform.position.x, bottomRight, ringZv.transform.position.z);
		}  

		if (ringZv.transform.localPosition.x <= bottomLeft) {
			ringZv.transform.Translate (Vector3.up * (speed * Time.deltaTime));
			ringZv.transform.position = new Vector3 (bottomLeft, ringZv.transform.position.y, ringZv.transform.position.z);
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

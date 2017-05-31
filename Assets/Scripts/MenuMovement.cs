using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class MenuMovement : MonoBehaviour {
	[SerializeField] private GameObject mainCamera;

	//
	void Awake () {
		Assert.IsNotNull (mainCamera);
	}

	//
	void Update () {
		this.transform.position = mainCamera.transform.position;
		float angleX = this.transform.eulerAngles.x;
		float angleY = mainCamera.transform.localEulerAngles.y;
		float angleZ = this.transform.eulerAngles.z;
		this.transform.eulerAngles = new Vector3 (angleX, angleY, angleZ);
	}
}

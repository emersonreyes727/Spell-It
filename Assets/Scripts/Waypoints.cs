using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {
	[SerializeField] private Transform camera;

	// moves the camera where the waypoint is located
	public void MoveHere () {
		camera.position = new Vector3 (transform.position.x, transform.position.y - 0.5f, transform.position.z);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointRotate : MonoBehaviour {
	
	// rotates the waypoints
	void Update () {
		transform.Rotate (new Vector3 (45, 0, 45) * Time.deltaTime);
	}
}

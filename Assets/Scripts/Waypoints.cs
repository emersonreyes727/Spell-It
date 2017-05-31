using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {
	[SerializeField] private Transform camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveHere () {
		camera.position = new Vector3 (transform.position.x, transform.position.y + 1f, transform.position.z);
	}
}

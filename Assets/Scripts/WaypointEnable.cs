using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointEnable : MonoBehaviour {
	[SerializeField] private GameObject waypoint1;
	[SerializeField] private GameObject waypoint2;
	[SerializeField] private GameObject waypoint3;
	[SerializeField] private GameObject waypoint4;
	[SerializeField] private GameObject waypoint5;
	[SerializeField] private GameObject waypoint6;

	// 
	void Start () {
		waypoint1.SetActive (false);
		waypoint2.SetActive (false);
		waypoint3.SetActive (false);
		waypoint4.SetActive (false);
		waypoint5.SetActive (false);
		waypoint6.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.GameStart) {
			waypoint1.SetActive (true);	
		}

		if (GameManager.instance.HitC && GameManager.instance.HitA && GameManager.instance.HitT) {
			waypoint2.SetActive (true);
			waypoint3.SetActive (true);
		}

		if (GameManager.instance.HitT2 && GameManager.instance.HitI && GameManager.instance.HitG &&
			GameManager.instance.HitE && GameManager.instance.HitR) {
			waypoint4.SetActive (true);
			waypoint5.SetActive (true);
			waypoint6.SetActive (true);
		}
	}
}

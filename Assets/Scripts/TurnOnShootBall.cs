using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnShootBall : MonoBehaviour {
	[SerializeField] private Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// if player is on the first waypoint in the start of the game
		if ((player.position.x == transform.position.x) && !GameManager.instance.HitC) {
			GameObject.Find("Main Camera").GetComponent<ShootBall>().enabled = true;
		}
	}
}

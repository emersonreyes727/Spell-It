using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootBall : MonoBehaviour {
	[SerializeField] private GameObject ball;
	[SerializeField] private Transform ballResetPosition;
	// del me
	[SerializeField] private Text shootingBall;

	// how many times the player shoot the ball
	private int playerShoot;

	// 
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Instantiate (ball, transform.position, transform.rotation, ballResetPosition);
			playerShoot += 1;
			// del me
			shootingBall.text = "Shoot Ball: " + playerShoot;
		}	
	}
}

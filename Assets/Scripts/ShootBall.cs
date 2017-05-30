using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootBall : MonoBehaviour {
	[SerializeField] private GameObject ball;
	[SerializeField] private Transform ballResetPosition;
	[SerializeField] private AudioClip soundFx;
	// del me
	[SerializeField] private Text shootingBall;

	private GvrAudioSource audio;
	private bool isShooting = false;

	// how many times the player shoot the ball
	private int playerShoot;

	// 
	void Start () {
		audio = GetComponent<GvrAudioSource> ();
	}

	// 
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Instantiate (ball, transform.position, transform.rotation, ballResetPosition);
			playerShoot += 1;
			// del me
			shootingBall.text = "Shoot Ball: " + playerShoot;

			isShooting = true;
		}	

		if (isShooting) {
			audio.PlayOneShot (soundFx);
			isShooting = false;
		}
	}
}

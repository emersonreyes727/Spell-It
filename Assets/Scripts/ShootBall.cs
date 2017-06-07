using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Assertions;

public class ShootBall : MonoBehaviour {
	[SerializeField] private GameObject ball;
	[SerializeField] private Transform ballResetPosition;
	[SerializeField] private AudioClip soundFx;

	// when the player moves to the waypoint the first time and shoots the ball
	// the "ballsShot" will start counting how many balls was shot and assign it to 
	// each sections ball shot count
	[SerializeField] private Transform waypoint1;
	[SerializeField] private Transform waypoint3;
	[SerializeField] private Transform waypoint6;

	[SerializeField] private Transform player;

	private GvrAudioSource audio;

	private int catBallsShot = 0;
	private int tigerBallsShot = 0;
	private int birdBallsShot = 0;

	// plays audio once
	private bool isShooting = false;

	//
	void Awake () {
		Assert.IsNotNull (ball);
		Assert.IsNotNull (ballResetPosition);
		Assert.IsNotNull (soundFx);

		Assert.IsNotNull (waypoint1);
		Assert.IsNotNull (waypoint3);
		Assert.IsNotNull (waypoint6);

		Assert.IsNotNull (player);
	}

	// 
	void Start () {
		audio = GetComponent<GvrAudioSource> ();
	}

	// 
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Instantiate (ball, transform.position, transform.rotation, ballResetPosition);

			AddOne ();
			isShooting = true;
		}	

		if (isShooting) {
			audio.PlayOneShot (soundFx);
			isShooting = false;
		}

		if (GameManager.instance.HitC && GameManager.instance.HitA && GameManager.instance.HitT) {
			GameManager.instance.AddToCatCount (catBallsShot);
		}

		if (GameManager.instance.HitT2 && GameManager.instance.HitI && GameManager.instance.HitG && GameManager.instance.HitE && GameManager.instance.HitR) {
			GameManager.instance.AddToTigerCount (tigerBallsShot);
		}

		if (GameManager.instance.HitB && GameManager.instance.HitI2 && GameManager.instance.HitR2 && GameManager.instance.HitD) {
			GameManager.instance.AddToBirdCount (birdBallsShot);
		}
	}

	// add how many balls was shot
	private void AddOne () {
		// for cat count
		if ((!GameManager.instance.HitC || !GameManager.instance.HitA || !GameManager.instance.HitT) &&
			(player.position.x == waypoint1.position.x)) {

			catBallsShot += 1;
		}

		// for tiger count
		if ((!GameManager.instance.HitT2 || !GameManager.instance.HitI || !GameManager.instance.HitG || !GameManager.instance.HitE || !GameManager.instance.HitR) &&
			(player.position.x == waypoint3.position.x)) {

			tigerBallsShot += 1;
		} 

		// for bird count
		if ((!GameManager.instance.HitB || !GameManager.instance.HitI2 || !GameManager.instance.HitR2 || !GameManager.instance.HitD) &&
			(player.position.x == waypoint6.position.x)) {

			birdBallsShot += 1;
		}
	}
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Assertions;

public class ShootBall : MonoBehaviour {
	[SerializeField] private GameObject ball;
	[SerializeField] private Transform ballResetPosition;
	[SerializeField] private AudioClip soundFx;

	private GvrAudioSource audio;
	private bool isShooting = false;

	//
	void Awake () {
		Assert.IsNotNull (ball);
		Assert.IsNotNull (ballResetPosition);
		Assert.IsNotNull (soundFx);
	}

	// 
	void Start () {
		audio = GetComponent<GvrAudioSource> ();
	}

	// 
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Instantiate (ball, transform.position, transform.rotation, ballResetPosition);

			isShooting = true;
		}	

		if (isShooting) {
			audio.PlayOneShot (soundFx);
			isShooting = false;
		}
	}
}


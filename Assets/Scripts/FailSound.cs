using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailSound : MonoBehaviour {
	[SerializeField] private AudioClip soundFxFail;

	private GvrAudioSource audio;
	private bool playAudioOnce = false;

	// Use this for initialization
	void Start () {
		audio = GetComponent<GvrAudioSource> ();	
	}

	//
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Ball") {
			playAudioOnce = true;
		}

		if (playAudioOnce) {
			audio.PlayOneShot (soundFxFail);
			playAudioOnce = false;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class SoundFail : MonoBehaviour {
	[SerializeField] private AudioClip soundFxFail;

	private GvrAudioSource audio;

	//
	void Awake () {
		Assert.IsNotNull (soundFxFail);
	}

	// 
	void Start () {
		audio = GetComponent<GvrAudioSource> ();	
	}

	//
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Ball") {
			audio.PlayOneShot (soundFxFail);
		}
	}
}

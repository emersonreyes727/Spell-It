using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class SoundFail : MonoBehaviour {
	[SerializeField] private AudioClip soundFxFail1;
	[SerializeField] private AudioClip soundFxFail2;

	private GvrAudioSource audio;

	//
	void Awake () {
		Assert.IsNotNull (soundFxFail1);
		Assert.IsNotNull (soundFxFail2);
	}

	// 
	void Start () {
		audio = GetComponent<GvrAudioSource> ();	
	}

	//
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Ball") {
			
			// random number will determine which sound will play
			float number = Mathf.Round (Random.Range (0f, 1f));
			if (number == 0f) {
				audio.PlayOneShot (soundFxFail1);
			} else {
				audio.PlayOneShot (soundFxFail2);
			}
		}
	}
}

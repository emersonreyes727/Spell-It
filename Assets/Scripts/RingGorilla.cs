using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingGorilla : MonoBehaviour {
	[SerializeField] private Canvas letterG;
	[SerializeField] private GameObject colliderG;
	[SerializeField] private AudioClip soundFxReward;

	private GvrAudioSource audio;
	private bool playerScored = false;
	private bool playAudioOnce = false;

	//
	void Start () {
		audio = GetComponent<GvrAudioSource> ();
	}

	//
	void Update () {
		if (GameManager.instance.HitG && !playerScored) {
			letterG.enabled = false;
			colliderG.SetActive (false);

			playAudioOnce = true;
			playerScored = true;
		}

		if (playAudioOnce) {
			audio.PlayOneShot (soundFxReward);
			playAudioOnce = false;
		}
	}
}

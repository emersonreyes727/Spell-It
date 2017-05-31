using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class RingTiger : MonoBehaviour {
	[SerializeField] private Canvas letterT;
	[SerializeField] private GameObject colliderT;
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
		if (GameManager.instance.HitT2 && !playerScored) {
			letterT.enabled = false;
			colliderT.SetActive (false);

			playAudioOnce = true;
			playerScored = true;
		}

		if (playAudioOnce) {
			audio.PlayOneShot (soundFxReward);
			playAudioOnce = false;
		}
	}
}

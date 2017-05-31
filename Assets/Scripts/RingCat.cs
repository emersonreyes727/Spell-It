using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class RingCat : MonoBehaviour {
	[SerializeField] private Canvas letterA;
	[SerializeField] private GameObject colliderA;
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
		if (GameManager.instance.HitA && !playerScored) {
			letterA.enabled = false;
			colliderA.SetActive (false);

			playAudioOnce = true;
			playerScored = true;
		}

		if (playAudioOnce) {
			audio.PlayOneShot (soundFxReward);
			playAudioOnce = false;
		}
	}
}

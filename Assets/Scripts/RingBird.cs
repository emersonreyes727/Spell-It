using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class RingBird : MonoBehaviour {
	[SerializeField] private Canvas letterB;
	[SerializeField] private GameObject colliderB;
	[SerializeField] private Canvas letterI2;
	[SerializeField] private GameObject colliderI2;
	[SerializeField] private Canvas letterR2;
	[SerializeField] private GameObject colliderR2;
	[SerializeField] private Canvas letterD;
	[SerializeField] private GameObject colliderD;

	[SerializeField] private AudioClip soundFx;

	private GvrAudioSource audio;

	// will prevent the audio from running multiple times in update
	private bool bHit = false;
	private bool i2Hit = false;
	private bool r2Hit = false;
	private bool dHit = false;

	//
	void Start () {
		// when game begins turn off collider 
		colliderI2.SetActive (false);
		colliderR2.SetActive (false);
		colliderD.SetActive (false);

		audio = GetComponent<GvrAudioSource> ();
	}

	//
	void Update () {
		if (GameManager.instance.HitB && !bHit) {
			letterB.enabled = false;
			colliderB.SetActive (false);

			colliderI2.SetActive (true);

			audio.PlayOneShot (soundFx);
			bHit = true;
		}

		if (GameManager.instance.HitI2 && !i2Hit) {
			letterI2.enabled = false;
			colliderI2.SetActive (false);

			colliderR2.SetActive (true);

			audio.PlayOneShot (soundFx);
			i2Hit = true;
		}

		if (GameManager.instance.HitR2 && !r2Hit) {
			letterR2.enabled = false;
			colliderR2.SetActive (false);

			colliderD.SetActive (true);

			audio.PlayOneShot (soundFx);
			r2Hit = true;
		}
			
		if (GameManager.instance.HitD && !dHit) {
			letterD.enabled = false;
			colliderD.SetActive (false);

			audio.PlayOneShot (soundFx);
			dHit = true;
		}

		if (GameManager.instance.HitB && GameManager.instance.HitI2  && 
			GameManager.instance.HitR2 && GameManager.instance.HitD) {
			// open the gate
		}
	}
}

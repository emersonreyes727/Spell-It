using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class RingTiger : MonoBehaviour {
	[SerializeField] private Canvas letterT2;
	[SerializeField] private GameObject colliderT2;
	[SerializeField] private Canvas letterI;
	[SerializeField] private GameObject colliderI;
	[SerializeField] private Canvas letterG;
	[SerializeField] private GameObject colliderG;
	[SerializeField] private Canvas letterE;
	[SerializeField] private GameObject colliderE;
	[SerializeField] private Canvas letterR;
	[SerializeField] private GameObject colliderR;

	[SerializeField] private AudioClip soundFx;

	private GvrAudioSource audio;

	// will prevent the audio from running multiple times in update
	private bool t2Hit = false;
	private bool iHit = false;
	private bool gHit = false;
	private bool eHit = false;
	private bool rHit = false;

	//
	void Start () {
		// when game begins turn off collider for letters I, G, E, and R
		colliderI.SetActive (false);
		colliderG.SetActive (false);
		colliderE.SetActive (false);
		colliderR.SetActive (false);

		audio = GetComponent<GvrAudioSource> ();
	}

	//
	void Update () {
		if (GameManager.instance.HitT2 && !t2Hit) {
			letterT2.enabled = false;
			colliderT2.SetActive (false);

			// turn on letter I when T is hit
			colliderI.SetActive (true);

			audio.PlayOneShot (soundFx);
			t2Hit = true;
		}

		if (GameManager.instance.HitI && !iHit) {
			letterI.enabled = false;
			colliderI.SetActive (false);

			// turn on letter G when I is hit
			colliderG.SetActive (true);

			audio.PlayOneShot (soundFx);
			iHit = true;
		}

		if (GameManager.instance.HitG && !gHit) {
			letterG.enabled = false;
			colliderG.SetActive (false);

			// turn on letter E when G is hit
			colliderE.SetActive (true);

			audio.PlayOneShot (soundFx);
			gHit = true;
		}

		if (GameManager.instance.HitE && !eHit) {
			letterE.enabled = false;
			colliderE.SetActive (false);

			// turn on letter R when E is hit
			colliderR.SetActive (true);

			audio.PlayOneShot (soundFx);
			eHit = true;
		}

		if (GameManager.instance.HitR && !rHit) {
			letterR.enabled = false;
			colliderR.SetActive (false);

			audio.PlayOneShot (soundFx);
			rHit = true;
		}

		if (GameManager.instance.HitT2 && GameManager.instance.HitI && GameManager.instance.HitG &&
			GameManager.instance.HitE && GameManager.instance.HitR) {
			// animate the tiger and open the gate
		}
	}
}

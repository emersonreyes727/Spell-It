using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class RingCat : MonoBehaviour {
	[SerializeField] private Canvas letterC;
	[SerializeField] private GameObject colliderC;
	[SerializeField] private Canvas letterA;
	[SerializeField] private GameObject colliderA;
	[SerializeField] private Canvas letterT;
	[SerializeField] private GameObject colliderT;

	[SerializeField] private AudioClip soundFx1;
	[SerializeField] private AudioClip soundFx2;

	private GvrAudioSource audio;

	// will prevent the audio from running multiple times in update
	private bool cHit = false;
	private bool aHit = false;
	private bool tHit = false;

	//
	void Awake () {
		Assert.IsNotNull (letterC);
		Assert.IsNotNull (colliderC);
		Assert.IsNotNull (letterA);
		Assert.IsNotNull (colliderA);
		Assert.IsNotNull (letterT);
		Assert.IsNotNull (colliderT);
		Assert.IsNotNull (soundFx1);
		Assert.IsNotNull (soundFx2);
	}

	//
	void Start () {
		// when game begins turn off collider for letters A and T
		colliderA.SetActive (false);
		colliderT.SetActive (false);

		audio = GetComponent<GvrAudioSource> ();
	}

	//
	void Update () {
		if (GameManager.instance.HitC && !cHit) {
			letterC.enabled = false;
			colliderC.SetActive (false);

			// turn on letter A when C is hit
			colliderA.SetActive (true);

			audio.PlayOneShot (soundFx1);
			cHit = true;
		}

		if (GameManager.instance.HitA && !aHit) {
			letterA.enabled = false;
			colliderA.SetActive (false);

			// turn on letter T when A is hit
			colliderT.SetActive (true);

			audio.PlayOneShot (soundFx1);
			aHit = true;
		}

		if (GameManager.instance.HitT && !tHit) {
			letterT.enabled = false;
			colliderT.SetActive (false);

			audio.PlayOneShot (soundFx1);
			tHit = true;
		}

		if (GameManager.instance.HitC && GameManager.instance.HitA && GameManager.instance.HitT) {
			// open the gate
		}

	}
}

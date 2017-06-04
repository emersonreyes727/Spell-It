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
		audio = GetComponent<GvrAudioSource> ();
	}

	//
	void Update () {
		if (GameManager.instance.HitC && !cHit) {
			letterC.enabled = false;
			colliderC.SetActive (false);

			// changes the tag
			colliderA.tag = "A";
			// disables the "sound fail" script
			colliderA.GetComponent<SoundFail> ().enabled = false;

			// random number will determine which sound will play
			float number = Mathf.Round (Random.Range (0f, 1f));

			if (number == 0f) {
				audio.PlayOneShot (soundFx1);
			} else {
				audio.PlayOneShot (soundFx2);
			}

			cHit = true;
		}

		if (GameManager.instance.HitA && !aHit) {
			letterA.enabled = false;
			colliderA.SetActive (false);

			// changes letter T's tag from X to T
			colliderT.tag = "T";
			// disables the "sound fail" script
			colliderT.GetComponent<SoundFail> ().enabled = false;

			// random number will determine which sound will play
			float number = Mathf.Round (Random.Range (0f, 1f));

			if (number == 0f) {
				audio.PlayOneShot (soundFx1);
			} else {
				audio.PlayOneShot (soundFx2);
			}

			aHit = true;
		}

		if (GameManager.instance.HitT && !tHit) {
			letterT.enabled = false;
			colliderT.SetActive (false);

			// random number will determine which sound will play
			float number = Mathf.Round (Random.Range (0f, 1f));

			if (number == 0f) {
				audio.PlayOneShot (soundFx1);
			} else {
				audio.PlayOneShot (soundFx2);
			}

			tHit = true;
		}

		if (GameManager.instance.HitC && GameManager.instance.HitA && GameManager.instance.HitT) {
			// open the gate
		}

	}
}

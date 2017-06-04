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

	[SerializeField] private AudioClip soundFx1;
	[SerializeField] private AudioClip soundFx2;

	private GvrAudioSource audio;

	// will prevent the audio from running multiple times in update
	private bool t2Hit = false;
	private bool iHit = false;
	private bool gHit = false;
	private bool eHit = false;
	private bool rHit = false;

	//
	void Awake () {
		Assert.IsNotNull (letterT2);
		Assert.IsNotNull (colliderT2);
		Assert.IsNotNull (letterI);
		Assert.IsNotNull (colliderI);
		Assert.IsNotNull (letterG);
		Assert.IsNotNull (colliderG);
		Assert.IsNotNull (letterE);
		Assert.IsNotNull (colliderE);
		Assert.IsNotNull (letterR);
		Assert.IsNotNull (colliderR);

		Assert.IsNotNull (soundFx1);
		Assert.IsNotNull (soundFx2);
	}
	//
	void Start () {
		audio = GetComponent<GvrAudioSource> ();
	}

	//
	void Update () {
		if (GameManager.instance.HitT2 && !t2Hit) {
			letterT2.enabled = false;
			colliderT2.SetActive (false);

			// changes the tag
			colliderI.tag = "I";
			// disables the "sound fail" script
			colliderI.GetComponent<SoundFail> ().enabled = false;

			// random number will determine which sound will play
			float number = Mathf.Round (Random.Range (0f, 1f));

			if (number == 0f) {
				audio.PlayOneShot (soundFx1);
			} else {
				audio.PlayOneShot (soundFx2);
			}

			t2Hit = true;
		}

		if (GameManager.instance.HitI && !iHit) {
			letterI.enabled = false;
			colliderI.SetActive (false);

			// changes the tag
			colliderG.tag = "G";
			// disables the "sound fail" script
			colliderG.GetComponent<SoundFail> ().enabled = false;

			// random number will determine which sound will play
			float number = Mathf.Round (Random.Range (0f, 1f));

			if (number == 0f) {
				audio.PlayOneShot (soundFx1);
			} else {
				audio.PlayOneShot (soundFx2);
			}

			iHit = true;
		}

		if (GameManager.instance.HitG && !gHit) {
			letterG.enabled = false;
			colliderG.SetActive (false);

			// changes the tag
			colliderE.tag = "E";
			// disables the "sound fail" script
			colliderE.GetComponent<SoundFail> ().enabled = false;

			// random number will determine which sound will play
			float number = Mathf.Round (Random.Range (0f, 1f));

			if (number == 0f) {
				audio.PlayOneShot (soundFx1);
			} else {
				audio.PlayOneShot (soundFx2);
			}

			gHit = true;
		}

		if (GameManager.instance.HitE && !eHit) {
			letterE.enabled = false;
			colliderE.SetActive (false);

			// changes the tag
			colliderR.tag = "R";
			// disables the "sound fail" script
			colliderR.GetComponent<SoundFail> ().enabled = false;

			// random number will determine which sound will play
			float number = Mathf.Round (Random.Range (0f, 1f));

			if (number == 0f) {
				audio.PlayOneShot (soundFx1);
			} else {
				audio.PlayOneShot (soundFx2);
			}

			eHit = true;
		}

		if (GameManager.instance.HitR && !rHit) {
			letterR.enabled = false;
			colliderR.SetActive (false);

			// random number will determine which sound will play
			float number = Mathf.Round (Random.Range (0f, 1f));

			if (number == 0f) {
				audio.PlayOneShot (soundFx1);
			} else {
				audio.PlayOneShot (soundFx2);
			}

			rHit = true;
		}

		if (GameManager.instance.HitT2 && GameManager.instance.HitI && GameManager.instance.HitG &&
			GameManager.instance.HitE && GameManager.instance.HitR) {
			// animate the tiger and open the gate
		}
	}
}

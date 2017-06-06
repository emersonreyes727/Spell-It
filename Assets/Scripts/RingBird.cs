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

	[SerializeField] private GameObject colliderU;
	[SerializeField] private GameObject colliderS;
	[SerializeField] private GameObject colliderQ;
	[SerializeField] private GameObject colliderC;

	[SerializeField] private AudioClip soundFx1;
	[SerializeField] private AudioClip soundFx2;

	private GvrAudioSource audio;

	// will prevent the audio from running multiple times in update
	private bool bHit = false;
	private bool i2Hit = false;
	private bool r2Hit = false;
	private bool dHit = false;

	// 
	void Awake () {
		Assert.IsNotNull (letterB);
		Assert.IsNotNull (colliderB);
		Assert.IsNotNull (letterI2);
		Assert.IsNotNull (colliderI2);
		Assert.IsNotNull (letterR2);
		Assert.IsNotNull (colliderR2);
		Assert.IsNotNull (letterD);
		Assert.IsNotNull (colliderD);

		Assert.IsNotNull (colliderU);
		Assert.IsNotNull (colliderS);
		Assert.IsNotNull (colliderQ);
		Assert.IsNotNull (colliderC);

		Assert.IsNotNull (soundFx1);
		Assert.IsNotNull (soundFx2);
	}
	//
	void Start () {
		audio = GetComponent<GvrAudioSource> ();
	}

	//
	void Update () {
		if (GameManager.instance.HitB && !bHit) {
			letterB.enabled = false;
			colliderB.SetActive (false);

			// changes the tag
			colliderI2.tag = "I2";
			// disables the "sound fail" script
			colliderI2.GetComponent<SoundFail> ().enabled = false;

			// random number will determine which sound will play
			float number = Mathf.Round (Random.Range (0f, 1f));

			if (number == 0f) {
				audio.PlayOneShot (soundFx1);
			} else {
				audio.PlayOneShot (soundFx2);
			}

			bHit = true;
		}

		if (GameManager.instance.HitI2 && !i2Hit) {
			letterI2.enabled = false;
			colliderI2.SetActive (false);

			// changes the tag
			colliderR2.tag = "R2";
			// disables the "sound fail" script
			colliderR2.GetComponent<SoundFail> ().enabled = false;

			// random number will determine which sound will play
			float number = Mathf.Round (Random.Range (0f, 1f));

			if (number == 0f) {
				audio.PlayOneShot (soundFx1);
			} else {
				audio.PlayOneShot (soundFx2);
			}

			i2Hit = true;
		}

		if (GameManager.instance.HitR2 && !r2Hit) {
			letterR2.enabled = false;
			colliderR2.SetActive (false);

			// changes the tag
			colliderD.tag = "D";
			// disables the "sound fail" script
			colliderD.GetComponent<SoundFail> ().enabled = false;

			// random number will determine which sound will play
			float number = Mathf.Round (Random.Range (0f, 1f));

			if (number == 0f) {
				audio.PlayOneShot (soundFx1);
			} else {
				audio.PlayOneShot (soundFx2);
			}

			r2Hit = true;
		}
			
		if (GameManager.instance.HitD && !dHit) {
			letterD.enabled = false;
			colliderD.SetActive (false);

			// random number will determine which sound will play
			float number = Mathf.Round (Random.Range (0f, 1f));

			if (number == 0f) {
				audio.PlayOneShot (soundFx1);
			} else {
				audio.PlayOneShot (soundFx2);
			}

			dHit = true;
		}

		if (GameManager.instance.HitB && GameManager.instance.HitI2  && 
			GameManager.instance.HitR2 && GameManager.instance.HitD) {
			// disable colliders when player completes the section
			colliderU.SetActive (false);
			colliderS.SetActive (false);
			colliderQ.SetActive (false);
			colliderC.SetActive (false);
		}
	}
}

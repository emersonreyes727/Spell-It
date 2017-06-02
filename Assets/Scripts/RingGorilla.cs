using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class RingGorilla : MonoBehaviour {
	[SerializeField] private Canvas letterG2;
	[SerializeField] private GameObject colliderG2;
	[SerializeField] private Canvas letterO;
	[SerializeField] private GameObject colliderO;
	[SerializeField] private Canvas letterR2;
	[SerializeField] private GameObject colliderR2;
	[SerializeField] private Canvas letterI2;
	[SerializeField] private GameObject colliderI2;
	[SerializeField] private Canvas letterL;
	[SerializeField] private GameObject colliderL;
	[SerializeField] private Canvas letterL2;
	[SerializeField] private GameObject colliderL2;
	[SerializeField] private Canvas letterA2;
	[SerializeField] private GameObject colliderA2;

	[SerializeField] private AudioClip soundFx;

	private GvrAudioSource audio;

	// will prevent the audio from running multiple times in update
	private bool g2Hit = false;
	private bool oHit = false;
	private bool r2Hit = false;
	private bool i2Hit = false;
	private bool lHit = false;
	private bool l2Hit = false;
	private bool a2Hit = false;

	//
	void Start () {
		// when game begins turn off collider for letters O, R, I, L, L and A
		colliderO.SetActive (false);
		colliderR2.SetActive (false);
		colliderI2.SetActive (false);
		colliderL.SetActive (false);
		colliderL2.SetActive (false);
		colliderA2.SetActive (false);

		audio = GetComponent<GvrAudioSource> ();
	}

	//
	void Update () {
		if (GameManager.instance.HitG2 && !g2Hit) {
			letterG2.enabled = false;
			colliderG2.SetActive (false);

			// turn on letter O when G is hit
			colliderO.SetActive (true);

			audio.PlayOneShot (soundFx);
			g2Hit = true;
		}

		if (GameManager.instance.HitO && !oHit) {
			letterO.enabled = false;
			colliderO.SetActive (false);

			// turn on letter R when O is hit
			colliderR2.SetActive (true);

			audio.PlayOneShot (soundFx);
			oHit = true;
		}

		if (GameManager.instance.HitR2 && !r2Hit) {
			letterR2.enabled = false;
			colliderR2.SetActive (false);

			// turn on letter I when R is hit
			colliderI2.SetActive (true);

			audio.PlayOneShot (soundFx);
			r2Hit = true;
		}

		if (GameManager.instance.HitI2 && !i2Hit) {
			letterI2.enabled = false;
			colliderI2.SetActive (false);

			// turn on letter L, L when I is hit
			colliderL.SetActive (true);
			colliderL2.SetActive (true);

			audio.PlayOneShot (soundFx);
			i2Hit = true;
		}
			
		// 
		if (GameManager.instance.HitL && !lHit) {
			letterL.enabled = false;
			colliderL.SetActive (false);


			audio.PlayOneShot (soundFx);
			lHit = true;
		}

		if (GameManager.instance.HitL2 && !l2Hit) {
			letterL2.enabled = false;
			colliderL2.SetActive (false);

			audio.PlayOneShot (soundFx);
			l2Hit = true;
		}
		//

		// if both L's are hit, turn on A
		if (GameManager.instance.HitL && GameManager.instance.HitL2) {
			colliderA2.SetActive (true);
		}

		if (GameManager.instance.HitA2 && !a2Hit) {
			letterA2.enabled = false;
			colliderA2.SetActive (false);

			audio.PlayOneShot (soundFx);
			a2Hit = true;
		}

		if (GameManager.instance.HitT2 && GameManager.instance.HitI && GameManager.instance.HitG &&
			GameManager.instance.HitE && GameManager.instance.HitR) {
			// animate the tiger and open the gate
		}
	}
}

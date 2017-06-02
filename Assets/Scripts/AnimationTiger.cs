using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTiger : MonoBehaviour {

	private Animator anim;
	private GvrAudioSource audio;
	private bool playAudioOnce = false;
	private float timer = 4f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		audio = GetComponent<GvrAudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if (GameManager.instance.HitT2 && GameManager.instance.HitI && GameManager.instance.HitG && 
			GameManager.instance.HitE && GameManager.instance.HitR && !playAudioOnce) {
			// open the gate
			anim.SetBool ("isCorrect", true);

			// timer for the tiger to start roaring
			timer -= Time.deltaTime;

			if (timer <= 0) {
				audio.Play ();
				playAudioOnce = true;
			}
		}
	}
}

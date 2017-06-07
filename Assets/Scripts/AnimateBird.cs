using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateBird : MonoBehaviour {
	private Animator anim;
	private GvrAudioSource audio;

	// plays audio once
	private bool runOnceBird = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		audio = GetComponent<GvrAudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if (GameManager.instance.HitB && GameManager.instance.HitI2  && 
			GameManager.instance.HitR2 && GameManager.instance.HitD && !runOnceBird) {

			anim.SetBool ("isCorrect", true);
			audio.Play ();
			runOnceBird = true;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateTiger : MonoBehaviour {
	private Animator anim;
	private GvrAudioSource audio;

	// plays audio once
	private bool runOnceTiger = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		audio = GetComponent<GvrAudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if (GameManager.instance.HitT2 && GameManager.instance.HitI && GameManager.instance.HitG 
			&& GameManager.instance.HitE && GameManager.instance.HitR && !runOnceTiger) {

			anim.SetBool ("isCorrect", true);
			audio.Play ();
			runOnceTiger = true;
		}
	}
}

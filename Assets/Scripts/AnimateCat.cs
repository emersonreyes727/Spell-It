using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCat : MonoBehaviour {
	private Animator anim;
	private GvrAudioSource audio;

	private bool runOnceCat = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		audio = GetComponent<GvrAudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.HitC && GameManager.instance.HitA && 
			GameManager.instance.HitT && !runOnceCat) {

			anim.SetBool ("isCorrect", true);
			audio.Play ();
			runOnceCat = true;
		}
	}
}

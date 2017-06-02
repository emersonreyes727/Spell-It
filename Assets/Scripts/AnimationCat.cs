using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCat : MonoBehaviour {
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
		if (GameManager.instance.HitC && GameManager.instance.HitA && GameManager.instance.HitT && !playAudioOnce) {
			// open the gate
			anim.SetBool ("isCorrect", true);


			// timer for the cat to start meowing
			timer -= Time.deltaTime;

			if (timer <= 0) {
				audio.Play ();
				playAudioOnce = true;
			}
		}
	}
}

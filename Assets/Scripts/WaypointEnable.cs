using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class WaypointEnable : MonoBehaviour {
	[SerializeField] private GameObject waypoint1;
	[SerializeField] private GameObject waypoint2;
	[SerializeField] private GameObject waypoint3;
	[SerializeField] private GameObject waypoint4;
	[SerializeField] private GameObject waypoint5;
	[SerializeField] private GameObject waypoint6;

	[SerializeField] private Transform player;

	[SerializeField] private AudioClip soundFxCat;
	[SerializeField] private AudioClip soundFxTiger;
	[SerializeField] private AudioClip soundFxBird;

	private GvrAudioSource audio;

	// will play audio once
	private bool playSpellCat = false;
	private bool playSpellTiger = false;
	private bool playSpellBird = false;

	//
	void Awake () {
		Assert.IsNotNull (waypoint1);
		Assert.IsNotNull (waypoint2);
		Assert.IsNotNull (waypoint3);
		Assert.IsNotNull (waypoint4);
		Assert.IsNotNull (waypoint5);
		Assert.IsNotNull (waypoint6);

		Assert.IsNotNull (player);

		Assert.IsNotNull (soundFxCat);
		Assert.IsNotNull (soundFxTiger);
		Assert.IsNotNull (soundFxBird);
	}

	// 
	void Start () {
		waypoint1.SetActive (false);
		waypoint2.SetActive (false);
		waypoint3.SetActive (false);
		waypoint4.SetActive (false);
		waypoint5.SetActive (false);
		waypoint6.SetActive (false);

		audio = GetComponent<GvrAudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if (GameManager.instance.GameStart) {
			waypoint1.SetActive (true);	
		} 

		if (GameManager.instance.HitC && GameManager.instance.HitA && GameManager.instance.HitT) {
			waypoint2.SetActive (true);
			waypoint3.SetActive (true);
		} 

		if (GameManager.instance.HitT2 && GameManager.instance.HitI && GameManager.instance.HitG &&
			GameManager.instance.HitE && GameManager.instance.HitR) {

			waypoint4.SetActive (true);
			waypoint5.SetActive (true);
			waypoint6.SetActive (true);
		} 

		if (!GameManager.instance.HitC && !GameManager.instance.HitA && !GameManager.instance.HitT && (player.position.x == waypoint1.transform.position.x) && !playSpellCat) {
			audio.PlayOneShot (soundFxCat);
			playSpellCat = true;
		}

		if (!GameManager.instance.HitT2 && !GameManager.instance.HitI && !GameManager.instance.HitG && !GameManager.instance.HitE && !GameManager.instance.HitR && (player.position.x == waypoint3.transform.position.x) && !playSpellTiger) {
			audio.PlayOneShot (soundFxTiger);
			playSpellTiger = true;
		}

		if (!GameManager.instance.HitB && !GameManager.instance.HitI2 && !GameManager.instance.HitR2 && !GameManager.instance.HitD && (player.position.x == waypoint6.transform.position.x) && !playSpellBird) {
			audio.PlayOneShot (soundFxBird);
			playSpellBird = true;
		}
	}
}


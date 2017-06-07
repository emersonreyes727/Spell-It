using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class GameOver : MonoBehaviour {
	[SerializeField] private GameObject gameOver;

	[SerializeField] private Text cat;
	[SerializeField] private Text tiger;
	[SerializeField] private Text bird;

	private float catScore;
	private float tigerScore;
	private float birdScore;

	// 
	void Awake () {
		Assert.IsNotNull (gameOver);

		Assert.IsNotNull (cat);
		Assert.IsNotNull (tiger);
		Assert.IsNotNull (bird);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.HitB && GameManager.instance.HitI2 && GameManager.instance.HitR2 && GameManager.instance.HitD) {
			gameOver.SetActive (true);

			float catValue = (3f / (float)GameManager.instance.BallCountCat) * 100f;
			float tigerValue = (5f / (float) GameManager.instance.BallCountTiger) * 100f;
			float birdValue = (4f / (float) GameManager.instance.BallCountBird) * 100f;

			cat.text = "cat: " + Mathf.Round (catValue)  + "%";
			tiger.text = "tiger: " + Mathf.Round(tigerValue) + "%";
			bird.text = "bird: " + Mathf.Round(birdValue) + "%";
		}
	}
}

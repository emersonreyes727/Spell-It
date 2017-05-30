using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	[SerializeField] private GameObject player;

	public static GameManager instance = null;

	// delete me
	[SerializeField] private Text ringA;
	[SerializeField] private Text ringX;

	//
	private bool gameOver = false;
	private bool gameStart = false;

	private int hitX;
	private bool hitA = false;

	//
	public GameObject Player {
		get { return player; }
	}

	public bool GameOver {
		get { return gameOver; }
	}

	public bool GameStart {
		get { return gameStart; }
	}

	public int HitX {
		get { return hitX; }
	}

	public bool HitA {
		get { return hitA; }
	}

	//
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}

		Assert.IsNotNull (player);
	}

	// 
	void Update () {
		// delete me
		ringA.text = "Ring A: " + hitA;
		ringX.text = "Ring X: " + hitX;
	}

	//
	public void GameIsOver () {
		gameOver = true;
	}

	public void GameHasStarted () {
		gameStart = true;
	}

	public void XisHit () {
		hitX += 1;
	}

	public void AisHit () {
		hitA = true;
	}

	public void Restart () {
		SceneManager.LoadScene ("Main");
	}

	public void Exit () {
		Application.Quit ();
	}
}

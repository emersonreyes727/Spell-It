using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	[SerializeField] private GameObject player;

	public static GameManager instance = null;

	//
	private bool gameOver = false;
	private bool gameStart = false;
	private bool isShooting = false;

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

	public bool IsShooting {
		get { return isShooting; }
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
	public void GameIsOver () {
		gameOver = true;
	}

	public void GameHasStarted () {
		gameStart = true;
	}

	public void ShootingBall () {
		isShooting = true;
	}

	public void Restart () {
		SceneManager.LoadScene ("Main");
	}

	public void Exit () {
		Application.Quit ();
	}
}

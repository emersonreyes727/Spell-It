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
	[SerializeField] private Text ringT;
	[SerializeField] private Text ringG;

	[SerializeField] private Text ringX;
	[SerializeField] private Text ringY;
	[SerializeField] private Text ringZ;

	//
	private bool gameOver = false;
	private bool gameStart = false;

	//
	private int hitX;
	private int hitY;
	private int hitZ;

	private bool hitA = false;
	private bool hitT = false;
	private bool hitG = false;

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

	//
	public int HitX {
		get { return hitX; }
	}

	public int HitY {
		get { return hitY; }
	}

	public int HitZ {
		get { return hitZ; }
	}


	public bool HitA {
		get { return hitA; }
	}

	public bool HitT {
		get { return hitT; }
	}

	public bool HitG {
		get { return hitG; }
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
		ringX.text = "Ring X: " + hitX;
		ringY.text = "Ring Y: " + hitY;
		ringZ.text = "Ring ZZ: " + hitZ;

		ringA.text = "Ring A: " + hitA;
		ringT.text = "Ring T: " + hitT;
		ringG.text = "Ring G: " + hitG;
	}

	//
	public void GameIsOver () {
		gameOver = true;
	}

	public void GameHasStarted () {
		gameStart = true;
	}

	//
	public void XisHit () {
		hitX += 1;
	}

	public void YisHit () {
		hitY += 1;
	}

	public void ZisHit () {
		hitZ += 1;
	}

	public void AisHit () {
		hitA = true;
	}

	public void TisHit () {
		hitT = true;
	}

	public void GisHit () {
		hitG = true;
	}

	//
	public void Restart () {
		SceneManager.LoadScene ("Main");
	}

	public void Exit () {
		Application.Quit ();
	}
}

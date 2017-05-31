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

	private int hitX;
	private int hitY;
	private int hitZ;

	private bool hitC = false;
	private bool hitA = false;
	private bool hitT = false;
	private bool hitT2 = false;
	private bool hitI = false;
	private bool hitG = false;
	private bool hitE = false;
	private bool hitR = false;
	private bool hitG2 = false;
	private bool hitO = false;
	private bool hitR2 = false;
	private bool hitI2 = false;
	private bool hitL = false;
	private bool hitL2 = false;
	private bool hitA2 = false;

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

	public int HitY {
		get { return hitY; }
	}

	public int HitZ {
		get { return hitZ; }
	}

	public bool HitC {
		get { return hitC; }
	}

	public bool HitA {
		get { return hitA; }
	}

	public bool HitT {
		get { return hitT; }
	}

	public bool HitT2 {
		get { return hitT2; }
	}

	public bool HitI {
		get { return hitI; }
	}

	public bool HitG {
		get { return hitG; }
	}

	public bool HitE {
		get { return hitE; }
	}

	public bool HitR {
		get { return hitR; }
	}

	public bool HitG2 {
		get { return hitG2; }
	}

	public bool HitO {
		get { return hitO; }
	}

	public bool HitR2 {
		get { return hitR2; }
	}

	public bool HitI2 {
		get { return hitI2; }
	}

	public bool HitL {
		get { return hitL; }
	}

	public bool HitL2 {
		get { return hitL2; }
	}

	public bool HitA2 {
		get { return hitA2; }
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

	public void CisHit () {
		hitC = true;
	}

	public void AisHit () {
		hitA = true;
	}

	public void TisHit () {
		hitT = true;
	}

	public void T2isHit () {
		hitT2 = true;
	}

	public void IisHit () {
		hitI = true;
	}

	public void GisHit () {
		hitG = true;
	}

	public void EisHit () {
		hitE = true;
	}

	public void RisHit () {
		hitR = true;
	}

	public void G2isHit () {
		hitG2 = true;
	}

	public void OisHit () {
		hitO = true;
	}

	public void R2isHit () {
		hitR2 = true;
	}

	public void I2isHit () {
		hitI2 = true;
	}

	public void LisHit () {
		hitL = true;
	}

	public void L2isHit () {
		hitL2 = true;
	}

	public void A2isHit () {
		hitA2 = true;
	}

	//
	public void Restart () {
		SceneManager.LoadScene ("Main");
	}

	public void Exit () {
		Application.Quit ();
	}
}

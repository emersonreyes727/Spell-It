using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class WordDisplay : MonoBehaviour {
	[SerializeField] private Text letterC;
	[SerializeField] private Text letterA;
	[SerializeField] private Text letterT;
	[SerializeField] private Text letterT2;
	[SerializeField] private Text letterI;
	[SerializeField] private Text letterG;
	[SerializeField] private Text letterE;
	[SerializeField] private Text letterR;
	[SerializeField] private Text letterG2;
	[SerializeField] private Text letterO;
	[SerializeField] private Text letterR2;
	[SerializeField] private Text letterI2;
	[SerializeField] private Text letterL;
	[SerializeField] private Text letterL2;
	[SerializeField] private Text letterA2;

	//
	void Awake () {
		Assert.IsNotNull (letterC);
		Assert.IsNotNull (letterA);
		Assert.IsNotNull (letterT);
		Assert.IsNotNull (letterT2);
		Assert.IsNotNull (letterI);
		Assert.IsNotNull (letterG);
		Assert.IsNotNull (letterE);
		Assert.IsNotNull (letterR);
		Assert.IsNotNull (letterG2);
		Assert.IsNotNull (letterO);
		Assert.IsNotNull (letterR2);
		Assert.IsNotNull (letterI2);
		Assert.IsNotNull (letterL);
		Assert.IsNotNull (letterL2);
		Assert.IsNotNull (letterA2);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameManager.instance.HitC) {
			letterC.text = "X";
		} else {
			letterC.text = "C";
		}

		if (!GameManager.instance.HitA) {
			letterA.text = "X";
		} else {
			letterA.text = "A";
		}

		if (!GameManager.instance.HitT) {
			letterT.text = "X";
		} else {
			letterT.text = "T";
		}

		if (!GameManager.instance.HitT2) {
			letterT2.text = "X";
		} else {
			letterT2.text = "T";
		}

		if (!GameManager.instance.HitI) {
			letterI.text = "X";
		} else {
			letterI.text = "I";
		}

		if (!GameManager.instance.HitG) {
			letterG.text = "X";
		} else {
			letterG.text = "G";
		}

		if (!GameManager.instance.HitE) {
			letterE.text = "X";
		} else {
			letterE.text = "E";
		}

		if (!GameManager.instance.HitR) {
			letterR.text = "X";
		} else {
			letterR.text = "R";
		}

		if (!GameManager.instance.HitG2) {
			letterG2.text = "X";
		} else {
			letterG2.text = "G";
		}

		if (!GameManager.instance.HitO) {
			letterO.text = "X";
		} else {
			letterO.text = "O";
		}

		if (!GameManager.instance.HitR2) {
			letterR2.text = "X";
		} else {
			letterR2.text = "R";
		}

		if (!GameManager.instance.HitI2) {
			letterI2.text = "X";
		} else {
			letterI2.text = "I";
		}

		if (!GameManager.instance.HitL) {
			letterL.text = "X";
		} else {
			letterL.text = "L";
		}

		if (!GameManager.instance.HitL2) {
			letterL2.text = "X";
		} else {
			letterL2.text = "L";
		}

		if (!GameManager.instance.HitA2) {
			letterA2.text = "X";
		} else {
			letterA2.text = "A";
		}
	}
}

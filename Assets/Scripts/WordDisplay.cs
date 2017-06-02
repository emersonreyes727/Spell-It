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

	[SerializeField] private Text letterB;
	[SerializeField] private Text letterI2;
	[SerializeField] private Text letterR2;
	[SerializeField] private Text letterD;

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

		Assert.IsNotNull (letterB);
		Assert.IsNotNull (letterI2);
		Assert.IsNotNull (letterR2);
		Assert.IsNotNull (letterD);
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

		//
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

		//
		if (!GameManager.instance.HitB) {
			letterB.text = "X";
		} else {
			letterB.text = "B";
		}

		if (!GameManager.instance.HitI2) {
			letterI2.text = "X";
		} else {
			letterI2.text = "I";
		}

		if (!GameManager.instance.HitR2) {
			letterR2.text = "X";
		} else {
			letterR2.text = "R";
		}

		if (!GameManager.instance.HitD) {
			letterD.text = "X";
		} else {
			letterD.text = "D";
		}
	}
}

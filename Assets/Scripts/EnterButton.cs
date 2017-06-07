using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class EnterButton : MonoBehaviour {
	[SerializeField] private Transform player;
	[SerializeField] private Transform firstWaypoint;
	[SerializeField] private GameObject welcomeUI;
	[SerializeField] private GameObject instructionsUI;

	//
	void Awake () {
		Assert.IsNotNull (player);
		Assert.IsNotNull (firstWaypoint);
		Assert.IsNotNull (welcomeUI);
		Assert.IsNotNull (instructionsUI);
	}

	public void ShowInstructions () {
		welcomeUI.SetActive (false);
		instructionsUI.SetActive (true);
	}

	public void EnterGame () {
		player.position = firstWaypoint.position;
		instructionsUI.SetActive (false);

		GameManager.instance.GameHasStarted ();
	}
}

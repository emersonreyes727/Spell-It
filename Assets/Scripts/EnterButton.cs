using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class EnterButton : MonoBehaviour {
	[SerializeField] private Transform player;
	[SerializeField] private Transform firstWaypoint;
	[SerializeField] private Canvas welcomeUI;

	//
	void Awake () {
		Assert.IsNotNull (player);
		Assert.IsNotNull (firstWaypoint);
		Assert.IsNotNull (welcomeUI);
	}

	public void EnterGame () {
		player.position = firstWaypoint.position;
		welcomeUI.enabled = false;

		GameManager.instance.GameHasStarted ();
	}
}

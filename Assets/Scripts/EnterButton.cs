using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterButton : MonoBehaviour {
	[SerializeField] private Transform player;
	[SerializeField] private Transform firstWaypoint;

	public void EnterGame () {
		player.position = firstWaypoint.position;

		GameManager.instance.GameHasStarted ();
	}
}

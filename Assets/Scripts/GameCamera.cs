﻿using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour {

	public Transform player;

	private Vector3 distanceToPlayer;

	void Start () {
		distanceToPlayer = transform.position - player.position;
	}

	void Update () {
		transform.position = player.position + distanceToPlayer;
	}
}

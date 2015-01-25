﻿using UnityEngine;
using System.Collections;

public class BGMPlayer : MonoBehaviour {

	bool test;

	// Use this for initialization
	void Start () {
		test = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!test) {
			AudioManager.PlayBGM ("epicSocore1.5Intro");
			audio.loop = false;
			test = true;
		}

		if (!audio.isPlaying){
			AudioManager.PlayBGM ("epicSocore1.5Loop");
			audio.loop = true;
		}


	}
}

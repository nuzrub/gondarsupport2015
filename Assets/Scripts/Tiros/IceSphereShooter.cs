﻿using UnityEngine;
using System.Collections;

public class IceSphereShooter : MonoBehaviour {

	public GameObject empty;
	public GameObject projectile;
	public float timeToDestroy;
	public int speed;

	void Start() {
		empty.particleSystem.enableEmission = false;
	}
	
	void FixedUpdate () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			Debug.Log("Apertei espaço");
			
			GameObject sphere = Instantiate(projectile, new Vector3(0, 0 , 0), Quaternion.identity) as GameObject;
			
			//sphere.renderer.enabled = false;
			sphere.transform.localScale += new Vector3(2, 2, 2);
			sphere.transform.position = empty.transform.position;
			sphere.transform.rotation = empty.transform.rotation;
			
			//empty.particleSystem.enableEmission = true;	
			//empty.particleSystem.Play();
			
			Rigidbody rigidbody = sphere.AddComponent<Rigidbody>();

			rigidbody.useGravity = false;
			rigidbody.velocity = empty.transform.forward * speed;

			Destroy(sphere, timeToDestroy);
		}
	}
}

using UnityEngine;
using System.Collections;

public class FireScriptShooter : MonoBehaviour {

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
			
			GameObject sphere1 = Instantiate(projectile, new Vector3(Random.Range(-3.0F, 5.0F), Random.Range(-3.0F, 5.0F), Random.Range(-3.0F, 5.0F)), Quaternion.identity) as GameObject;
			GameObject sphere2 = Instantiate(projectile, new Vector3(Random.Range(-3.0F, 5.0F), Random.Range(-3.0F, 5.0F), Random.Range(-3.0F, 5.0F)), Quaternion.identity) as GameObject;
			GameObject sphere3 = Instantiate(projectile, new Vector3(Random.Range(-3.0F, 5.0F), Random.Range(-3.0F, 5.0F), Random.Range(-3.0F, 5.0F)), Quaternion.identity) as GameObject;
			GameObject sphere4 = Instantiate(projectile, new Vector3(Random.Range(-3.0F, 5.0F), Random.Range(-3.0F, 5.0F), Random.Range(-3.0F, 5.0F)), Quaternion.identity) as GameObject;
			GameObject sphere5 = Instantiate(projectile, new Vector3(Random.Range(-3.0F, 5.0F), Random.Range(-3.0F, 5.0F), Random.Range(-3.0F, 5.0F)), Quaternion.identity) as GameObject;
			
			//sphere.renderer.enabled = false;
			
			sphere1.transform.position = empty.transform.position;
			sphere1.transform.rotation = empty.transform.rotation;
			
			sphere2.transform.position = empty.transform.position;
			sphere2.transform.rotation = empty.transform.rotation;
			
			sphere3.transform.position = empty.transform.position;
			sphere3.transform.rotation = empty.transform.rotation;
			
			sphere4.transform.position = empty.transform.position;
			sphere4.transform.rotation = empty.transform.rotation;
			
			sphere5.transform.position = empty.transform.position;
			sphere5.transform.rotation = empty.transform.rotation;
			
			//empty.particleSystem.enableEmission = true;	
			//empty.particleSystem.Play();
			
			Rigidbody rigidbody1 = sphere1.AddComponent<Rigidbody>();
			Rigidbody rigidbody2 = sphere2.AddComponent<Rigidbody>();
			Rigidbody rigidbody3 = sphere3.AddComponent<Rigidbody>();
			Rigidbody rigidbody4 = sphere4.AddComponent<Rigidbody>();
			Rigidbody rigidbody5 = sphere5.AddComponent<Rigidbody>();
			
			rigidbody1.useGravity = false;
			rigidbody1.velocity = empty.transform.forward * (speed + Random.Range(10.0F, 30F));
			rigidbody2.useGravity = false;
			rigidbody2.velocity = empty.transform.forward * (speed + Random.Range(10.0F, 30F));
			rigidbody3.useGravity = false;
			rigidbody3.velocity = empty.transform.forward * (speed + Random.Range(10.0F, 30F));
			rigidbody4.useGravity = false;
			rigidbody4.velocity = empty.transform.forward * (speed + Random.Range(10.0F, 30F));
			rigidbody5.useGravity = false;
			rigidbody5.velocity = empty.transform.forward * (speed + Random.Range(10.0F, 30F));
			
			
			Destroy(sphere1, timeToDestroy);
			Destroy(sphere2, timeToDestroy);
			Destroy(sphere3, timeToDestroy);
			Destroy(sphere4, timeToDestroy);
			Destroy(sphere5, timeToDestroy);
		}
	}
}

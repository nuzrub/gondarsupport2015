using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour {

	public GameObject empty;
	public GameObject projectile;

	void Start() {
		empty.particleSystem.enableEmission = false;	
	}

	void FixedUpdate () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			Debug.Log("Apertei espaço");

			GameObject sphere = Instantiate(projectile, new Vector3(0, 0 , 0), Quaternion.identity) as GameObject;

			//sphere.renderer.enabled = false;
			sphere.transform.position = empty.transform.position;
			sphere.transform.rotation = empty.transform.rotation;

			empty.particleSystem.enableEmission = true;	
			empty.particleSystem.Play();

			Rigidbody rigidbody = sphere.AddComponent<Rigidbody>();

			rigidbody.velocity = empty.transform.forward * 30;
		}
	}
}

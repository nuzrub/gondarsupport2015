using UnityEngine;
using System.Collections;

public class RaySphereShooter : BaseShooter {

	public override void Atirar() {
		base.Atirar();
		
		GameObject sphere = Instantiate(projectile, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
		
		//sphere.renderer.enabled = false;
		sphere.transform.localScale += new Vector3(0.0f, 0.0f, .3f);
		sphere.transform.position = empty.transform.position;
		sphere.transform.rotation = empty.transform.rotation;
		
		Rigidbody rigidbody = sphere.AddComponent<Rigidbody>();
		
		rigidbody.useGravity = false;
		rigidbody.velocity = empty.transform.forward * speed;

        CriarEfeito(sphere.transform);
		Destroy(sphere, timeToDestroy);
	}
}

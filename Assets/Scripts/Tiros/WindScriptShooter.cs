using UnityEngine;
using System.Collections;

public class WindScriptShooter : BaseShooter {

    public override void Atirar() {
        base.Atirar();

        GameObject sphere = Instantiate(projectile, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;

        //sphere.renderer.enabled = false;
        sphere.transform.position = empty.transform.position;
        sphere.transform.rotation = empty.transform.rotation;


        Rigidbody rigidbody = sphere.AddComponent<Rigidbody>();

        rigidbody.useGravity = false;
        rigidbody.velocity = empty.transform.forward * speed;

        sphere.tag = "playerbullet";
        CriarEfeito(sphere.transform);
        Destroy(sphere, timeToDestroy);
    }
}

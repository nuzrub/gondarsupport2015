﻿using UnityEngine;
using System.Collections;

public class Braco_Missil : BaseBraco {

    public override void Atirar() {
        base.Atirar();

        GameObject sphere = Instantiate(projectile, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;

        //sphere.renderer.enabled = false;
        sphere.transform.position = empty.transform.position;
        sphere.transform.rotation = empty.transform.rotation;
        sphere.transform.eulerAngles += new Vector3(-90, 0, 0);
        sphere.transform.parent = Temp.Projectiles;

        Rigidbody rigidbody = sphere.AddComponent<Rigidbody>();

        rigidbody.useGravity = false;
        rigidbody.velocity = empty.transform.forward * bulletSpeed;
        rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;

        sphere.tag = "enemybullet";
        CriarEfeito(sphere.transform);
        Destroy(sphere, bulletLifetime);
    }
}
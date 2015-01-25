using UnityEngine;
using System.Collections;

public class Braco_Fogo : BaseBraco {

    public override void Atirar() {
        base.Atirar();

        GameObject sphere1 = Instantiate(projectile, new Vector3(Random.Range(-3.0F, 5.0F), empty.transform.position.y, Random.Range(-3.0F, 5.0F)), Quaternion.identity) as GameObject;
        GameObject sphere2 = Instantiate(projectile, new Vector3(Random.Range(-3.0F, 5.0F), empty.transform.position.y, Random.Range(-3.0F, 5.0F)), Quaternion.identity) as GameObject;
        GameObject sphere3 = Instantiate(projectile, new Vector3(Random.Range(-3.0F, 5.0F), empty.transform.position.y, Random.Range(-3.0F, 5.0F)), Quaternion.identity) as GameObject;
        GameObject sphere4 = Instantiate(projectile, new Vector3(Random.Range(-3.0F, 5.0F), empty.transform.position.y, Random.Range(-3.0F, 5.0F)), Quaternion.identity) as GameObject;
        GameObject sphere5 = Instantiate(projectile, new Vector3(Random.Range(-3.0F, 5.0F), empty.transform.position.y, Random.Range(-3.0F, 5.0F)), Quaternion.identity) as GameObject;

        //sphere.renderer.enabled = false;

        sphere1.transform.position = empty.transform.position;
        sphere1.transform.rotation = empty.transform.rotation;
        sphere1.transform.parent = Temp.Projectiles;

        sphere2.transform.position = empty.transform.position;
        sphere2.transform.rotation = empty.transform.rotation;
        sphere2.transform.parent = Temp.Projectiles;

        sphere3.transform.position = empty.transform.position;
        sphere3.transform.rotation = empty.transform.rotation;
        sphere3.transform.parent = Temp.Projectiles;

        sphere4.transform.position = empty.transform.position;
        sphere4.transform.rotation = empty.transform.rotation;
        sphere4.transform.parent = Temp.Projectiles;

        sphere5.transform.position = empty.transform.position;
        sphere5.transform.rotation = empty.transform.rotation;
        sphere5.transform.parent = Temp.Projectiles;

        Rigidbody rigidbody1 = sphere1.AddComponent<Rigidbody>();
        Rigidbody rigidbody2 = sphere2.AddComponent<Rigidbody>();
        Rigidbody rigidbody3 = sphere3.AddComponent<Rigidbody>();
        Rigidbody rigidbody4 = sphere4.AddComponent<Rigidbody>();
        Rigidbody rigidbody5 = sphere5.AddComponent<Rigidbody>();

        rigidbody1.useGravity = false;
        rigidbody1.velocity = empty.transform.forward * (bulletSpeed + Random.Range(10.0F, 30F));
        rigidbody2.useGravity = false;
        rigidbody2.velocity = empty.transform.forward * (bulletSpeed + Random.Range(10.0F, 30F));
        rigidbody3.useGravity = false;
        rigidbody3.velocity = empty.transform.forward * (bulletSpeed + Random.Range(10.0F, 30F));
        rigidbody4.useGravity = false;
        rigidbody4.velocity = empty.transform.forward * (bulletSpeed + Random.Range(10.0F, 30F));
        rigidbody5.useGravity = false;
        rigidbody5.velocity = empty.transform.forward * (bulletSpeed + Random.Range(10.0F, 30F));

        CriarEfeito(sphere1.transform);
        CriarEfeito(sphere2.transform);
        CriarEfeito(sphere3.transform);
        CriarEfeito(sphere4.transform);
        CriarEfeito(sphere5.transform);

        sphere1.tag = "enemybullet";
        sphere2.tag = "enemybullet";
        sphere3.tag = "enemybullet";
        sphere4.tag = "enemybullet";
        sphere5.tag = "enemybullet";

        Destroy(sphere1, bulletLifetime);
        Destroy(sphere2, bulletLifetime);
        Destroy(sphere3, bulletLifetime);
        Destroy(sphere4, bulletLifetime);
        Destroy(sphere5, bulletLifetime);
    }
}
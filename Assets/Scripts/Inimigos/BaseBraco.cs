using UnityEngine;
using System.Collections;

public class BaseBraco : BaseComponent {

    public Transform empty;
    public GameObject projectile;
    public GameObject efeito;
    public float bulletSpeed = 10f;
    public float bulletLifetime = 3f;
    public float cooldown = 0.6f;
    private float nextShoot = 0f;

    public void TentarAtirar() {
        if (Time.time > nextShoot) {
            nextShoot = Time.time + cooldown * corpo.cooldownModifier;

            if (efeito != null) {
                Instantiate(efeito, empty.transform.position, empty.transform.rotation);
            }
            Atirar();
        }
    }
    public virtual void Atirar() {

    }
}

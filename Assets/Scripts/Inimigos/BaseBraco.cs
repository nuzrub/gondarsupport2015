using UnityEngine;
using System.Collections;

public class BaseBraco : BaseComponent {

    public float cooldown = 0.6f;
    private float nextShoot = 0f;

    public void TentarAtirar() {
        if (Time.time > nextShoot) {
            nextShoot = Time.time + cooldown;

            Atirar();
        }
    }
    public virtual void Atirar() {

    }
}

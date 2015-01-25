using UnityEngine;
using System.Collections;

public class BaseShooter : MonoBehaviour {
    public GameObject empty;
    public GameObject projectile;
    public GameObject efeito;
    public float timeToDestroy;
    public float speed = 1f;
    public float cooldown = 0.3f;
    private float nextShoot = 0;


    void Update() {
        if (GameInput.Atirar1()) {
            if (Time.time > nextShoot) {
                nextShoot = Time.time + cooldown;

                if (efeito != null) {
                    Instantiate(efeito, empty.transform.position, empty.transform.rotation);
                }
                Atirar();
            }
        }
    }

    public virtual void Atirar() {

    }
}

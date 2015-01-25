using UnityEngine;
using System.Collections;

public class BaseShooter : MonoBehaviour {
    public GameObject empty;
    public GameObject projectile;
    public GameObject efeito;
    public string sfx_name;
    public float timeToDestroy;
    public float speed = 1f;
    public float cooldown = 0.3f;
    private float nextShoot = 0;


    void Update() {
        if (GameInput.Atirar1()) {
            if (Time.time > nextShoot) {
                nextShoot = Time.time + cooldown;

                if (sfx_name != "") {
                    AudioManager.PlaySFX(sfx_name, transform.position);
                }
                Atirar();
            }
        }
    }

    protected void CriarEfeito(Transform esfera) {
        if (efeito != null) {
            GameObject go = (GameObject)Instantiate(efeito, esfera.position, esfera.rotation);
            go.transform.parent = esfera;
        }
    }

    public virtual void Atirar() {

    }
}

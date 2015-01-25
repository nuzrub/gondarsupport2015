using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour {

    public GameObject explosionEffect;
    public float damage = 4;


    void OnCollisionEnter(Collision collision) {
        codigo(collision.collider.tag, collision.gameObject);
    }
    void OnTriggerEnter(Collider other) {
        codigo(other.tag, other.gameObject);
    }


    void codigo(string otherTag, GameObject other) {
        bool destruir = false;
        if (this.tag == "playerbullet") {
            if (otherTag == "enemy") {
                CorpoMonstro cm = other.GetComponent<CorpoMonstro>();
                cm.TomarDano(damage);
                destruir = true;
            }
        } else if (this.tag == "enemybullet") {
            if (otherTag == "Player") {
                Player p = other.GetComponent<Player>();
                p.TakeDamage(damage);
                destruir = true;
            }
        }
        
        
        if (tag == "cenario") {
            destruir = true;
        }


        if (destruir) {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
			AudioManager.PlaySFX("sfx_explosion", this.transform.position);
        }
    }
}

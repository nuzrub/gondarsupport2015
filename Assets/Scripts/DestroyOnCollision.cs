using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour {

    public GameObject explosionEffect;
    public float damage;

    void OnCollisionEnter(Collision collision) {
        codigo(collision.collider.tag);
    }
    void OnTriggerEnter(Collider other) {
        codigo(other.tag);
    }

    void codigo(string otherTag) {
        if (tag == "Player") {
            // tirar hp

            Instantiate(explosionEffect);
            Destroy(this.gameObject);
        } else if (tag == "cenario") {
            Instantiate(explosionEffect);
            Destroy(this.gameObject);
        }
    }
}

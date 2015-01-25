using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour {

    public GameObject explosionEffect;
    public float damage;

    void OnCollisionEnter(Collision collision) {
        codigo(collision.other.tag);
    }
    void OnTriggerEnter(Collider other) {
        codigo(other.tag);
    }

    void codigo(string otherTag) {
        if (tag == "Player") {
            // tirar hp
        } else if (tag == "cenario") {
            return;
        } else {
            return;
        }
    }
}

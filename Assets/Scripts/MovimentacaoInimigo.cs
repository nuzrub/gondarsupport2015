using UnityEngine;
using System.Collections;

public class MovimentacaoInimigo : MonoBehaviour {

    public Transform player;
    public int moveSpeed = 4;
    public int MaxDist = 10;
    public int MinDist = 5;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update() {
        transform.LookAt(player);

        if (Vector3.Distance(transform.position, player.position) >= MinDist) {

            transform.position += transform.forward * moveSpeed * Time.deltaTime;


            if (Vector3.Distance(transform.position, player.position) <= MaxDist) {
                //Codigo para atirar.
            }
        }
    }

    void FixedUpdate() {
        rigidbody.velocity = Vector3.zero;
    }
}

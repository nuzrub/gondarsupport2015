using UnityEngine;
using System.Collections;

public class MinaMovimento : MonoBehaviour {

    public GameObject minaPrefab;
    public Transform minaSpawn;
    private float nextShoot = 0f;
    private float cooldown = 0.2f;
    private float bulletSpeed = 6f;


    void Update() {
        if (GameInput.Atirar1()) {
            if (Time.time > nextShoot && CMin.atual < CMin.maxMinas) {
                CMin.atual++;
                nextShoot = Time.time + cooldown;
                GameObject mina = (GameObject)GameObject.Instantiate(minaPrefab, minaSpawn.position, minaSpawn.rotation);
            }
        }
    }
}

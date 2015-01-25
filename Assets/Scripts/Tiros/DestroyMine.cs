using UnityEngine;
using System.Collections;

public class DestroyMine : MonoBehaviour {

    public float timerDestroyMine = 5f;
    public GameObject efeito;

    void Update() {
        timerDestroyMine -= Time.deltaTime;

        if (timerDestroyMine < 0) {
            Destroy(this.gameObject);
            CMin.atual--;
            Instantiate(efeito, this.gameObject.transform.position, Quaternion.identity);
        }
    }
}

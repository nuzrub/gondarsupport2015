using UnityEngine;
using System.Collections;

public class Selfdestruct : MonoBehaviour {

    public float Delay = 1f;
	
	void Update () {
        Delay -= Time.deltaTime;

        if (Delay <= 0) {
            Destroy(this.gameObject);
        }
	}
}

using UnityEngine;
using System.Collections;

public class BasePerna : BaseComponent {
    public float distanciaDesejada = 6;


    public virtual void Andar() {
        corpo.transform.position = new Vector3(corpo.transform.position.x, 1.5f, corpo.transform.position.z);
        corpo.transform.LookAt(player);
        if (Vector3.Distance(corpo.transform.position, player.position) >= distanciaDesejada) {
            corpo.transform.Translate(-corpo.transform.forward * corpo.mov_peed * Time.deltaTime);
        }
    }
}

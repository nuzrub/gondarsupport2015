using UnityEngine;
using System.Collections;

public class BasePerna : BaseComponent {
    public float distanciaDesejada = 20;


    public virtual void Andar() {
        corpo.transform.position = new Vector3(corpo.transform.position.x, player.transform.position.y, corpo.transform.position.z);
        corpo.transform.LookAt(player);
        if (Vector3.Distance(corpo.transform.position, player.position) >= distanciaDesejada) {
            corpo.transform.Translate(-corpo.transform.forward * corpo.mov_peed * Time.deltaTime);
        }
    }
}

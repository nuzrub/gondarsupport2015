using UnityEngine;
using System.Collections;

public class BasePerna : BaseComponent {
    public float distanciaDesejada = 6f;
    public override void Install(CorpoMonstro cm) {
        base.Install(cm);
        perna = this;
    }

    public virtual void Andar() {
        corpo.transform.LookAt(player);

        if (Vector3.Distance(corpo.transform.position, player.position) >= distanciaDesejada) {
            corpo.transform.Translate(corpo.transform.forward * corpo.mov_peed * Time.deltaTime);
        }
    }
}

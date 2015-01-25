using UnityEngine;
using System.Collections;

public class Cabeca_Rage : BaseCabeca {
    public override void Atacar() {
        if (Vector3.Distance(corpo.transform.position, player.position) <= 22f) {
            base.Atacar();
        }
    }
}

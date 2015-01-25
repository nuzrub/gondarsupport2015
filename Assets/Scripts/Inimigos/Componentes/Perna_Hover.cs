using UnityEngine;
using System.Collections;

public class Perna_Hover : BasePerna {

    public override void Buff() {
        base.Buff();

        corpo.mov_peed *= 1.25f;
    }

    public override void Andar() {
        base.Andar();
    }
}
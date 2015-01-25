using UnityEngine;
using System.Collections;

public class Costa_Ataque : BaseCosta {
    public override void Buffar() {
        base.Buffar();

        corpo.attack += 5;
    }
}

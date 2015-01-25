using UnityEngine;
using System.Collections;

public class Costa_Ataque : BaseCosta {
    public override void Buff() {
        base.Buff();

        corpo.attack += 5;
        corpo.cooldownModifier = 0.75f;
    }
}

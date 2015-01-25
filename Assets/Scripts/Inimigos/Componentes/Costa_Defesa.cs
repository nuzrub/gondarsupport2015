using UnityEngine;
using System.Collections;

public class Costa_Defesa : BaseCosta {
    public override void Buff() {
        base.Buff();

        corpo.defense += 5;
        corpo.HP_Max *= 1.25f;
        corpo.HP_Current = corpo.HP_Max;
    }
}

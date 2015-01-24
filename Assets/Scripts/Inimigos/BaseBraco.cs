using UnityEngine;
using System.Collections;

public class BaseBraco : BaseComponent {

    public override void Install(CorpoMonstro cm) {
        base.Install(cm);
        if (braco1 == null) {
            braco1 = this;
        } else {
            braco2 = this;
        }
    }

    public virtual void Atirar() {

    }
}

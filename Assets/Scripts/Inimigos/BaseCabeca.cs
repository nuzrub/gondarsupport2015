using UnityEngine;
using System.Collections;

public class BaseCabeca : BaseComponent {
    public override void Install(CorpoMonstro cm) {
        base.Install(cm);
        cabeca = this;
    }

    public virtual void Atacar() {

    }
}

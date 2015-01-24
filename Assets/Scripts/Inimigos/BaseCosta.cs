using UnityEngine;
using System.Collections;

public class BaseCosta : BaseComponent {
    public override void Install(CorpoMonstro cm) {
        base.Install(cm);
        costa = this;
    }
}

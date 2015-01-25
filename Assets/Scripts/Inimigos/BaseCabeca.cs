using UnityEngine;
using System.Collections;

public class BaseCabeca : BaseComponent {


    public virtual void Atacar() {
        braco1.TentarAtirar();
        braco2.TentarAtirar();
    }
}

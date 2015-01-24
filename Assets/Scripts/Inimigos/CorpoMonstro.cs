using UnityEngine;
using System.Collections;

public class CorpoMonstro : MonoBehaviour {
	
	public Transform slotCabeca;
	public Transform slotBracoEsquerdo;
	public Transform slotBracoDireito;
	public Transform slotCosta;
	public Transform slotPernas;

   
    public float HP_Max;
    public float HP_Current;
    public float attack;
    public float defense;
    public float attack_speed;
    public float mov_peed;

    public void montarMonstro(BaseCabeca cabeca, BaseBraco bracoEsquerdo, BaseBraco bracoDireito, BaseCosta costa, BasePerna pernas) {
		cabeca.transform.parent = slotCabeca;
        cabeca.transform.localPosition = Vector3.zero;

        bracoDireito.transform.parent = slotBracoDireito;
        bracoDireito.transform.localPosition = Vector3.zero;

        bracoEsquerdo.transform.parent = slotBracoEsquerdo;
        bracoEsquerdo.transform.localPosition = Vector3.zero;

        costa.transform.parent = slotCosta;
        costa.transform.localPosition = Vector3.zero;

        pernas.transform.parent = slotPernas;
        pernas.transform.localPosition = Vector3.zero;

        cabeca.Install(this);
        costa.Install(this);
        bracoDireito.Install(this);
        bracoEsquerdo.Install(this);
        pernas.Install(this);


	}

    void FixedUpdate() {
        rigidbody.velocity = Vector3.zero;
    }
}

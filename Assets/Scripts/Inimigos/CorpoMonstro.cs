using UnityEngine;
using System.Collections;

public class CorpoMonstro : MonoBehaviour {
	
	public Transform slotCabeca;
	public Transform slotBracoEsquerdo;
	public Transform slotBracoDireito;
	public Transform slotCosta;
	public Transform slotPernas;

    public float Speed;
    public float HP_Max;
    public float HP_Current;

	void criarMonstro(Transform cabeca, Transform bracoEsquerdo, Transform bracoDireito, Transform costa, Transform pernas){
		cabeca.parent = slotCabeca;
		cabeca.localPosition = Vector3.zero;

		bracoDireito.parent = slotBracoDireito;
		bracoDireito.localPosition = Vector3.zero;

		bracoEsquerdo.parent = slotBracoEsquerdo;
		bracoEsquerdo.localPosition = Vector3.zero;

		costa.parent = slotCosta;
		costa.localPosition = Vector3.zero;

		pernas.parent = slotPernas;
		pernas.localPosition = Vector3.zero;
	}
}

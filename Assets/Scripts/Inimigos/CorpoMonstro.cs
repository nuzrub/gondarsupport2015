﻿using UnityEngine;
using System.Collections;

public class CorpoMonstro : BaseComponent {
	
	public Transform slotCabeca;
	public Transform slotBracoEsquerdo;
	public Transform slotBracoDireito;
	public Transform slotCosta;
	public Transform slotPernas;

    public GameObject onDieEffect;
    public float HP_Max;
    public float HP_Current;
    public float attack;
    public float defense;
    public float mov_peed;
    public float cooldownModifier;

    public void TomarDano(float damage) {
        HP_Current -= damage;

        if (HP_Current <= 0) {
            Instantiate(onDieEffect, transform.position, transform.rotation);
            GameObject.Destroy(this.gameObject);
            GameSystem.Instance.OnInimigoMorreu();
        }
    }
    public void montarMonstro(BaseCabeca cabeca, BaseBraco bracoEsquerdo, BaseBraco bracoDireito, BaseCosta costa, BasePerna pernas) {
		cabeca.transform.parent = slotCabeca;
        cabeca.transform.localPosition = Vector3.zero;

        bracoDireito.transform.parent = slotBracoDireito;
        bracoDireito.transform.localPosition = Vector3.zero;
        bracoDireito.transform.eulerAngles = new Vector3(-90, 0, 0);
        bracoDireito.transform.localScale = new Vector3(6, 6, 6);

        bracoEsquerdo.transform.parent = slotBracoEsquerdo;
        bracoEsquerdo.transform.localPosition = Vector3.zero;
        bracoEsquerdo.transform.eulerAngles = new Vector3(-90, 0, 0);
        bracoEsquerdo.transform.localScale = new Vector3(6, 6, 6);

        costa.transform.parent = slotCosta;
        costa.transform.localPosition = Vector3.zero;

        pernas.transform.parent = slotPernas;
        pernas.transform.localPosition = Vector3.zero;


        BaseComponent[] bclist = new BaseComponent[6];
        bclist[0] = cabeca;
        bclist[1] = costa;
        bclist[2] = pernas;
        bclist[3] = bracoDireito;
        bclist[4] = bracoEsquerdo;
        bclist[5] = this;
        for (int i = 0; i < 6; i++) {
            bclist[i].corpo = this;
            bclist[i].cabeca = cabeca;
            bclist[i].costa = costa;
            bclist[i].perna = pernas;
            bclist[i].braco1 = bracoDireito;
            bclist[i].braco2 = bracoEsquerdo;
        }

        cabeca.Buff();
        braco1.Buff();
        braco2.Buff();
        costa.Buff();
        perna.Buff();
	}

    protected override void OnUpdate() {
        base.OnUpdate();

        perna.Andar();
        cabeca.Atacar();
    }

    void FixedUpdate() {
        rigidbody.velocity = Vector3.zero;
    }
}

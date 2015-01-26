using UnityEngine;
using System.Collections;

public class BaseComponent : MonoBehaviour {

    public Transform player;

    public CorpoMonstro corpo;
    public BaseCabeca cabeca;
    public BaseCosta costa;
    public BaseBraco braco1;
    public BaseBraco braco2;
    public BasePerna perna;

	void Start () {
        OnStart();
	}

	void Update () {
        GameObject p = GameObject.FindGameObjectWithTag("Player");

        if (p != null) {
            player = p.transform;
            OnUpdate();
        }
	}

    protected virtual void OnStart() { }
    protected virtual void OnUpdate() { }

    public virtual void Buff() { }
}

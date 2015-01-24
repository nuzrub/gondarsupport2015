using UnityEngine;
using System.Collections;

public class BaseComponent : MonoBehaviour {

    public Transform player;

    protected CorpoMonstro corpo;
    protected BaseCabeca cabeca;
    protected BaseCosta costa;
    protected BaseBraco braco1;
    protected BaseBraco braco2;
    protected BasePerna perna;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        OnStart();
	}

	void Update () {
        OnUpdate();
	}

    public virtual void Install(CorpoMonstro cm) {
        corpo = cm;
    }
    protected virtual void OnStart() { }
    protected virtual void OnUpdate() { }
}

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
        player = GameObject.FindGameObjectWithTag("Player").transform;

        OnStart();
	}

	void Update () {
        OnUpdate();
	}

    protected virtual void OnStart() { }
    protected virtual void OnUpdate() { }
}

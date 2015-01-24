using UnityEngine;
using System.Collections;

public class TesteCorpo : MonoBehaviour {

	public CorpoMonstro cm;
	public GameObject prefab;
	public GameObject go;

	void Start () {
		GameObject g1 = (GameObject)GameObject.Instantiate (prefab);
		GameObject g2 = (GameObject)GameObject.Instantiate (prefab);
		GameObject g3 = (GameObject)GameObject.Instantiate (prefab);
		GameObject g4 = (GameObject)GameObject.Instantiate (prefab);
		GameObject g5 = (GameObject)GameObject.Instantiate (prefab);
		cm.criarMonstro (go.transform, g2.transform, g3.transform, g4.transform, g5.transform);
	}
}

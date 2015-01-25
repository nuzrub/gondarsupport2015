using UnityEngine;
using System.Collections;

public class RaySphereControlller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.localScale += new Vector3(0.001f, 0.001f, 0.005f);

	}

}

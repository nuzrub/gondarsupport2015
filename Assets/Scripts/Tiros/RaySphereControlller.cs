using UnityEngine;
using System.Collections;

public class RaySphereControlller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag.Equals("Respawn"))
		{
			Debug.Log ("Bateu no inimigo");
		}

	}
}

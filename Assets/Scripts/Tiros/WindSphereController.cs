using UnityEngine;
using System.Collections;

public class WindSphereController : MonoBehaviour {

	private float seno;
	
	void Start () {
		seno = 0;
	}

	void FixedUpdate () {
		transform.position += transform.right * Mathf.Sin(seno*20) * (seno*5) ;
		seno += Time.deltaTime;
	}
}

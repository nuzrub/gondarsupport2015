using UnityEngine;
using System.Collections;

public class WindSphereController : MonoBehaviour {

	private float seno;
	
	void Start () {
		seno = 0;
	}

	void FixedUpdate () {
		transform.position += transform.right * 3.4f*(Mathf.Sin(seno));
		seno += Time.deltaTime * 8 + 1;
	}
}

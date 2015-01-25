using UnityEngine;
using System.Collections;

public class LifeHud : MonoBehaviour {

	Animation animation;

	// Use this for initialization
	void Start () {
	
		animation = GetComponent<Animation> ();	
	
	}
	
	public void StartAnimation() {
		
		animation.Play ();

	}

}

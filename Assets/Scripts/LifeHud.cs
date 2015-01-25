using UnityEngine;
using System.Collections;

public class LifeHud : MonoBehaviour {
	public Animation animation;

	// Use this for initialization
	void Start () {
		animation = GetComponent<Animation> ();	
		animation.Play ();
	}

    public void Start_TomarDano_Animation() {
		animation.Play ();
	}
}

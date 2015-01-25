using UnityEngine;
using System.Collections;

public class DestroyMine : MonoBehaviour {

	public float timerDestroyMine = 5f;

	void Update()
	{
		timerDestroyMine -= Time.deltaTime;

		if (timerDestroyMine < 0) {
			Destroy (this.gameObject);
			CMin.atual--;
		}
	}
}

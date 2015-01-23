using UnityEngine;
using System.Collections;

public class BasicBullet : MonoBehaviour {

	public Vector3 Speed;

	void Update () {
		transform.Translate (Speed * Time.deltaTime);
	}
}

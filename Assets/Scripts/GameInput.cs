using UnityEngine;
using System.Collections;

public class GameInput : MonoBehaviour {

	private static GameInput instance;
	public static Vector3 MoveDirection() {
		return instance.mdir;
	}
	public static Vector3 ShootDirection() {
		return instance.sdir;
	}
	public static bool Atirar1() {
		return Input.GetButton ("Atirar1");
	}
	public static bool Atirar2() {
		return Input.GetButton ("Atirar2");
	}

	public bool UseMouse = true;
	private Vector3 mdir;
	private Vector3 sdir;

	void Start () {
		instance = this;
		mdir = Vector3.zero;
		sdir = Vector3.forward;
	}

	void Update () {
		Vector3 lastSdir = sdir;

		mdir = Vector3.zero;
		sdir = Vector3.zero;

		// teclado/joystick
		mdir += Vector3.right * Input.GetAxisRaw ("Movement_X");
		mdir += Vector3.forward * Input.GetAxisRaw ("Movement_Y");

		if (UseMouse) {
			Vector3 mousePos = Input.mousePosition;
			mousePos.x /= Screen.width;
			mousePos.y /= Screen.height;
			mousePos *= 2;
			mousePos += new Vector3(-1, -1, 0);
			mousePos.z = mousePos.y;
			mousePos.y = 0;

			sdir = mousePos;
		} else {
			sdir += Vector3.right * Input.GetAxisRaw ("Shoot_X");
			sdir += Vector3.forward * Input.GetAxisRaw ("Shoot_Y");
		}

		if (sdir == Vector3.zero) {
			sdir = lastSdir;
		}

		mdir.Normalize ();
		sdir.Normalize ();
	}
}

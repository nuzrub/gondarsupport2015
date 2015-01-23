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

	private Vector3 mdir;
	private Vector3 sdir;

	void Start () {
		mdir = Vector3.zero;
		sdir = Vector3.zero;
	}

	void Update () {
		mdir = Vector3.zero;
		sdir = Vector3.zero;

		// teclado/joystick
		mdir += Vector3.right * Input.GetAxisRaw ("Movement_X");
		mdir += Vector3.up * Input.GetAxisRaw ("Movement_Y");
		sdir += Vector3.right * Input.GetAxisRaw ("Shoot_X");
		sdir += Vector3.up * Input.GetAxisRaw ("Shoot_Y");

		// mouse
		Vector3 mousePos = Input.mousePosition;
		// calcular mousePos para ficar de [-1, -1, 0] ate [1, 1, 0]

		sdir += mousePos;

		mdir.Normalize ();
		sdir.Normalize ();

		print ("Mdir: " + mdir);
		print ("Sdir: " + sdir);
	}
}

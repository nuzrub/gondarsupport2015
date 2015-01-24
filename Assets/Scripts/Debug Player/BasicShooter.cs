using UnityEngine;
using System.Collections;

public class BasicShooter : MonoBehaviour {

	public BasicBullet bulletPrefab;
	private float nextShoot = 0f;
	private float cooldown = 0.2f;
	private float bulletSpeed = 6f;


	void Update () {
		if (GameInput.Atirar1 ()) {
			if (Time.time > nextShoot) {
				nextShoot = Time.time + cooldown;

				BasicBullet bullet = (BasicBullet)GameObject.Instantiate(bulletPrefab, transform.position + transform.forward, Quaternion.identity);
				bullet.Speed = GameInput.ShootDirection() * bulletSpeed;
			}
		}
	}
}

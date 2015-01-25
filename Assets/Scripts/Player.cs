using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float Speed = 6;

    void Start() {

    }

    void Update() {
        Mover();
    }
    void FixedUpdate() {
        rigidbody.velocity = Vector3.zero;
    }

    private void Mover() {
        Vector3 direction = GameInput.MoveDirection();
        Vector3 translate;
        Vector3 rotate;


        translate = direction * Speed * Time.deltaTime;

        if (GameInput.Atirar1()) {
            direction = GameInput.ShootDirection();
        }

        if (direction.normalized == -transform.forward) {
            rotate = new Vector3(0, 180, 0);
        } else {
            rotate = Quaternion.FromToRotation(transform.forward, direction).eulerAngles;
        }
        rotate.x = rotate.z = 0;
        

        transform.Translate(translate, Space.World);
        transform.Rotate(rotate, Space.Self);
        print(translate);
    }
}

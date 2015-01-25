using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float HP_Max = 100;
    public float HP_Curr;
    public float Speed = 6;

    void Start() {
        HP_Curr = HP_Max;
    }
    void Update() {
        Mover();
    }
    void FixedUpdate() {
        rigidbody.velocity = Vector3.zero;
    }

    private void Mover() {
        Vector3 direction = GameInput.MoveDirection();
        Vector3 translate = Vector3.zero;
        Vector3 rotate = Vector3.zero;

        if (direction == Vector3.zero) {
            animation.CrossFade("Defending_Cycle");
        } else {
            animation.CrossFade("Runing_Cycle");
            translate = direction * Speed * Time.deltaTime;
        }
        

        if (GameInput.Atirar1()) {
            animation.CrossFade("Fire_Pistol_Cycle");
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
    }
}

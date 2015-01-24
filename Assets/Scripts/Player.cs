using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float Speed = 60;

    void Start() {

    }

    void Update() {
        Mover();
    }
    void FixedUpdate() {
        rigidbody.velocity = Vector3.zero;
    }

    private void Mover() {
        Vector3 movement = GameInput.MoveDirection();

        transform.Translate(movement * Speed * Time.deltaTime);
    }
}

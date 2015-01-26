using UnityEngine;
using System.Collections;

public class LittleThornCreator : BaseShooter
{

    public float timerDestroySphere;
    public GameObject efeito2;
    public GameObject littleThorn;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timerDestroySphere -= Time.deltaTime;

        if (timerDestroySphere < 0)
        {
            Destroy(this.gameObject);
            CMin.atual--;

            GameObject little1 = Instantiate(littleThorn, this.gameObject.transform.position, this.gameObject.transform.rotation) as GameObject;
            GameObject little2 = Instantiate(littleThorn, this.gameObject.transform.position, this.gameObject.transform.rotation) as GameObject;
            GameObject little3 = Instantiate(littleThorn, this.gameObject.transform.position, this.gameObject.transform.rotation) as GameObject;
            GameObject little4 = Instantiate(littleThorn, this.gameObject.transform.position, this.gameObject.transform.rotation) as GameObject;

            Rigidbody rigidbody1 = little1.AddComponent<Rigidbody>();
            Rigidbody rigidbody2 = little2.AddComponent<Rigidbody>();
            Rigidbody rigidbody3 = little3.AddComponent<Rigidbody>();
            Rigidbody rigidbody4 = little4.AddComponent<Rigidbody>();

            rigidbody1.useGravity = false;
            rigidbody1.velocity = this.gameObject.transform.forward * 30.0f;

            rigidbody2.useGravity = false;
            rigidbody2.velocity = -this.gameObject.transform.forward * 30.0f;

            rigidbody3.useGravity = false;
            rigidbody3.velocity = this.gameObject.transform.right * 30.0f;

            rigidbody4.useGravity = false;
            rigidbody4.velocity = -this.gameObject.transform.right * 30.0f;

            CriarEfeito(little1.transform);
            CriarEfeito(little2.transform);
            CriarEfeito(little3.transform);
            CriarEfeito(little4.transform);

            Destroy(little1, 0.6f);
            Destroy(little2, 0.6f);
            Destroy(little3, 0.6f);
            Destroy(little4, 0.6f);

        }
	}
}

using UnityEngine;
using System.Collections;

public class Continuum : MonoBehaviour {

    public float Cooldown = 0.5f;
    private float nextKick;

    void Start() {
        nextKick = 0f;

    }
	void Update () {
	    if (Time.time >= nextKick) {
            if (Input.GetMouseButton(0)) {
                Vector3 mpos = Input.mousePosition;
                float w = Screen.width;
                float h = Screen.height;

                if (mpos.y < 60) {
                    return;
                }

                mpos.x /= w;
                mpos.y /= h;
                float pitch = (mpos.x + 0.5f);

                mpos *= 2;
                mpos -= new Vector3(1, 1, 0);
                mpos *= 4;

                print(w + ", " + h);
                AudioManager.PlaySFX("Kick", mpos, 1f, pitch);

                nextKick = Time.time + Cooldown;
            }
        }
	}
}

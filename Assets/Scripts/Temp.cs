using UnityEngine;
using System.Collections;

public class Temp : MonoBehaviour {
    public static Transform Audio;
    public static Transform Objects;
    public static Transform Projectiles;

    void Awake() {
        this.transform.position = Vector3.zero;

        Audio = CreateEmpty("Audio");
        Objects = CreateEmpty("Objects");
        Projectiles = CreateEmpty("Projectiles");
    }

    private Transform CreateEmpty(string name) {
        GameObject go = new GameObject(name);
        go.transform.position = Vector3.zero;
        go.transform.rotation = Quaternion.identity;
        go.transform.parent = this.transform;

        return go.transform;
    }
}

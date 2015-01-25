using UnityEngine;
using System.Collections;

public class MineScriptShooter : BaseShooter {

    public override void Atirar()
    {
        if(CMin.atual < CMin.maxMinas){
            base.Atirar();

            GameObject sphere = Instantiate(projectile, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;

            //sphere.renderer.enabled = false;
            sphere.transform.localScale += new Vector3(2, 2, 2);
            sphere.transform.position = empty.transform.position;
            sphere.transform.rotation = empty.transform.rotation;

            Rigidbody rigidbody = sphere.AddComponent<Rigidbody>();

            CriarEfeito(sphere.transform);
            rigidbody.useGravity = true;
            CMin.atual++;
        }
    }
}

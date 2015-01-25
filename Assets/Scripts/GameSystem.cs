using UnityEngine;
using System.Collections;

public class GameSystem : MonoBehaviour {

    public CorpoMonstro baseEnemy;
    public BaseCabeca[] cabecas;
    public BaseBraco[] bracos;
    public BaseCosta[] costas;
    public BasePerna[] pernas;
    public Transform SpawnPoint;
    public int Quantidade_Inimigos_min = 3;
    public int Quantidade_Inimigos_max = 12;
    public int HP_Somado = 200;

    private BaseComponent[] selecionadas;
    private CorpoMonstro[] inimigos;

	void Start () {
        selecionadas = new BaseComponent[5];
        int r;

        // cabeça
        r = Random.Range(0, cabecas.Length - 1);
        selecionadas[0] = cabecas[r];

        // bracos
        r = Random.Range(0, bracos.Length - 1);
        selecionadas[1] = bracos[r];
        r = Random.Range(0, bracos.Length - 1);
        selecionadas[2] = bracos[r];

        // costas
        r = Random.Range(0, costas.Length - 1);
        selecionadas[3] = costas[r];

        // pernas
        r = Random.Range(0, pernas.Length - 1);
        selecionadas[4] = pernas[r];



        int qinimigos = Random.Range(Quantidade_Inimigos_min, Quantidade_Inimigos_max);
        int hp = HP_Somado / qinimigos;
        inimigos = new CorpoMonstro[qinimigos];

        for (int i = 0; i < qinimigos; i++) {
            inimigos[i] = CriarInimigo(hp);
        }
	}

    private CorpoMonstro CriarInimigo(int hp) {
        CorpoMonstro cm = (CorpoMonstro)GameObject.Instantiate(baseEnemy);
        cm.HP_Max = hp;
        cm.montarMonstro(
            (BaseCabeca)GameObject.Instantiate(selecionadas[0]),
            (BaseBraco)GameObject.Instantiate(selecionadas[1]),
            (BaseBraco)GameObject.Instantiate(selecionadas[2]),
            (BaseCosta)GameObject.Instantiate(selecionadas[3]),
            (BasePerna)GameObject.Instantiate(selecionadas[4]));

        cm.transform.position = SpawnPoint.position;
        cm.transform.parent = Temp.Objects;
        return cm;
    }
}

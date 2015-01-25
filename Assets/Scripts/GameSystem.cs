using UnityEngine;
using System.Collections;

public class GameSystem : MonoBehaviour {

    public static GameSystem Instance;
    public CorpoMonstro baseEnemy;
    public BaseCabeca[] cabecas;
    public BaseBraco[] bracos;
    public BaseCosta[] costas;
    public BasePerna[] pernas;
    public Transform SpawnPoint;
    public int Quantidade_Inimigos_min = 3;
    public int Quantidade_Inimigos_max = 12;
    public int HP_Somado = 200;
    public int Base_Attack = 10;
    public int Base_Defense = 6;
    public int Base_moveSpeed = 6;
    public float Base_cooldownModifier = 1f;

    public int Inimigos_Vivos;

    private BaseComponent[] selecionadas;
    private CorpoMonstro[] inimigos;

    void Awake() {
        GameSystem.Instance = this;
    }
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
        Inimigos_Vivos = qinimigos;
        int hp = HP_Somado / qinimigos;
        inimigos = new CorpoMonstro[qinimigos];

        for (int i = 0; i < qinimigos; i++) {
            inimigos[i] = CriarInimigo(hp);
        }
	}

    private CorpoMonstro CriarInimigo(int hp) {
        CorpoMonstro cm = (CorpoMonstro)GameObject.Instantiate(baseEnemy);
        cm.HP_Max = hp;
        cm.attack = Base_Attack;
        cm.defense = Base_Defense;
        cm.mov_peed = Base_moveSpeed;
        cm.cooldownModifier = Base_cooldownModifier;
       
        cm.montarMonstro(
            (BaseCabeca)GameObject.Instantiate(selecionadas[0]),
            (BaseBraco)GameObject.Instantiate(selecionadas[1]),
            (BaseBraco)GameObject.Instantiate(selecionadas[2]),
            (BaseCosta)GameObject.Instantiate(selecionadas[3]),
            (BasePerna)GameObject.Instantiate(selecionadas[4]));

        cm.transform.position = SpawnPoint.position + new Vector3(Random.Range(-5f, 5f), 0, 0);
        cm.transform.parent = Temp.Objects;
        return cm;
    }

    public void OnInimigoMorreu() {
        Inimigos_Vivos--;

        if (Inimigos_Vivos == 0) {
            // GameOver;
        }
    }
}

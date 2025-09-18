using Assets;
using UnityEngine;

public class Aula01 : MonoBehaviour
{
    void Start()
    {
        Pessoa p1 = new Pessoa();
        p1.receberNome("Adam");

        Pessoa p2 = new Pessoa();
        p2.receberNome("bob");

        Debug.Log(p2.perguntar(p1));

    }

    void Update()
    {

    }
}

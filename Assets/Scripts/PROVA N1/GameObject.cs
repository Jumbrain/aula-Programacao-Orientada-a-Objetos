using UnityEngine;

public class GameObject : MonoBehaviour
{
    void Start()
    {
        //O que está dentro do ProvaN1POO é a implementação do construtor
        ProvaN1POO p = new ProvaN1POO("534.731.753-5", 19);

        //Abaixo, é uma demonstração de uma sobrecarga de construtores
        ProvaN1POO p1 = new ProvaN1POO("643.798.128-36", 33);

        ProvaN1POO p2 = new ProvaN1POO("735.732.189-60", 47);
    }
}

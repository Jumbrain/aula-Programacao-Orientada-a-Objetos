using UnityEngine;

public class Inimigo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClasseInimigo goblin = new ClasseInimigo("Goblin", 100);
        Debug.Log("Seu inimigo é um " + goblin.GetNome() + " e ele possui " + goblin.GetVida() + " de vida");

        ClasseInimigo semNome = new ClasseInimigo();
        semNome.SetNome("!@#$%¨&*");
        semNome.SetVida(50);
        Debug.Log("Você está contra um " + semNome.GetNome() + "... Ele possui " + semNome.GetVida() + " de vida");

        ClasseInimigo esqueleto = new ClasseInimigo("Esqueleto");
        Debug.Log("você encontrou um " + esqueleto.GetNome() + " vagando pelos corredores");

        Arma2 metodo1 = new Arma2();
        Debug.Log(metodo1.Atacar());

        Arma2 metodo2 = new Arma2();
        Debug.Log(metodo2.Atacar(50));

        Arma2 metodo3 = new Arma2();
        Debug.Log(metodo3.Atacar("Atordoamento"));

        Debug.Log(ClasseInimigo.GetContarInimigos() + " inimigos foram contados!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

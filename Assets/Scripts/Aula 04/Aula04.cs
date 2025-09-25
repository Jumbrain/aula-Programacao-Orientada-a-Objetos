using UnityEngine;
using System.Collections.Generic;

public class Aula04 : MonoBehaviour
{
    void Start()
    {
        //ExemploArrayLista();

        //Aula de associação de objetos
        Player player = new Player("Guerreiro", 100);
        Arma3 arma = new Arma3("Espada", 20);
        Inimigo2 inimigo = new Inimigo2("Golem", 50, 15);
        Escudo escudo = new Escudo("Escudo Retangular", 5);
        Armadura armadura = new Armadura("Armadura Prateada", 5);

        player.SetArma(arma);
        player.SetEscudo(escudo);
        player.SetArmadura(armadura);
        player.Atacar(inimigo, arma);
        inimigo.Atacar(player);
        player.Atacar(inimigo, arma);
        inimigo.Atacar(player);

    }

    //void ExemploArrayLista()
    //{
    //    //Array e Lista

    //    //Array
    //    int[] numeros = new int[3];
    //    numeros[0] = 1;
    //    numeros[1] = 10;
    //    numeros[2] = 20;
    //    Debug.Log("Primeira posição do array: " + numeros[0]);
    //    for (int i = 0; i < numeros.Length; i++)
    //    {
    //        Debug.Log("Posição " + (i + 1) + " do array: " + numeros[i]);
    //    }

    //    foreach (int numero in numeros)
    //    {
    //        Debug.Log("Numero do array: " + numero);
    //    }

    //    //Lista
    //    List<string> frutas = new List<string>();
    //    frutas.Add("Maça");
    //    frutas.Add("Morango");
    //    frutas.Add("Goiaba");
    //    Debug.Log("Primeira fruta da lista: " + frutas[2]);
    //    frutas.Remove("Banana");
    //    Debug.Log("Quantidade de frutas: " + frutas.Count);

    //    for (int i = 0; i < frutas.Count; i++)
    //    {
    //        Debug.Log("Fruta " + (i + 1) + " da lista: " + frutas[i]);
    //    }

    //    foreach (string fruta in frutas)
    //    {
    //        Debug.Log("Fruta da lista: " + fruta);
    //    }
    //}
}

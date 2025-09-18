using UnityEngine;

public class Arma : MonoBehaviour
{
    void Start()
    {
        ClasseArma classeArma1 = new ClasseArma();
        ClasseArma classeArma2 = new ClasseArma();

        //Definir os Tipos
        classeArma1.SetTipoDaArma("Pistola");
        classeArma2.SetTipoDaArma("Fuzil");

        //Definir Balas
        classeArma1.SetBalas(1);
        classeArma2.SetBalas(5);

        //debug nessa prora (arma 1)
        Debug.Log("Sua arma é um/uma " + classeArma1.GetTipoDaArma() + " e possui " + classeArma1.GetBalas() + " balas");

        //debug nessa prora (arma 2)
        Debug.Log("Sua arma é um/uma " + classeArma2.GetTipoDaArma() + " e possui " + classeArma2.GetBalas() + " balas");
    }

    void Update()
    {
        
    }
}

using UnityEngine;

public class Aula03 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Magia fogo = new Magia("Fogo", 100, "explode uma área");

        Magia gelo = new Magia();
        gelo.SetNome("raio de gelo");
        gelo.SetPoder(40);
        gelo.SetDescricao("congela o inimigo");

        Debug.Log(fogo.LancarMagia());
        Debug.Log(gelo.LancarMagia("troll"));

        Debug.Log("Total de magias criadas: " + Magia.getContarMagias());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

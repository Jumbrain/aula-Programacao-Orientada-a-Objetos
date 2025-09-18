using UnityEngine;

public class Aula02 : MonoBehaviour
{
    void Start()
    {
        Personagem personagem = new Personagem(/*"Jorge", 5*/);

        //Definindo as caracteristicas com o Set
        personagem.SetTipoPersonagem(TipoPersonagem.Guerreiro); 
        personagem.SetVida(3);
        personagem.SetNome("flavio");

        //Pegando as caracteristicas com o Get
        Debug.Log("Tipo: " + personagem.GetTipoPersonagem());
        Debug.Log(personagem.GetVida());
        Debug.Log(personagem.GetNome());

        //GameObject gameObject = new GameObject("alberto"); (criar gameObjects)
    }

    void Update()
    {
        
    }
}

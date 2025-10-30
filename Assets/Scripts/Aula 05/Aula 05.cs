using UnityEngine;

public class Aula05 : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("Heroi", 100);
        Inimigo2 inimigo = new Inimigo2("Monstro", 80, 15);

        player.Gritar();
        inimigo.Reclamar();
    }

}

using UnityEngine;

public class Atividade : MonoBehaviour
{
    private void Start()
    {
        Player player = new Player("Herói", 100);
        Revolver revolver = new Revolver("ak47", 5);
        Espada espada = new Espada("Ascalun", 10);

        player.SetArma(revolver);
        player.SetArma(espada);
        revolver.Atirar();
        espada.Cortar();
    }
}

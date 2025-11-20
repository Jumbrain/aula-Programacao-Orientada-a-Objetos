using UnityEngine;

public class Espada : Armas, IArmaDeCorte
{
    public Espada(string nome, int dano) : base(nome, dano)
    {
    }

    public void Cortar()
    {
        Debug.Log("Fiun Fiunn");
    }

    public override void Usar(int dano)
    {
        Cortar();
    }
}

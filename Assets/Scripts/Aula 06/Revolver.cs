using UnityEngine;

public class Revolver : Armas, IArmaFogo
{
    public Revolver(string nome, int dano) : base(nome, dano)
    {
    }

    public void Atirar()
    {
        Debug.Log("Pweu Pweu");
    }

    public override void Usar(int dano)
    {
        Atirar();
    }
}

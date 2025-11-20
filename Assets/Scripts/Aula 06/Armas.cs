using UnityEngine;

public abstract class Armas //: IArmaDeCorte, IArmaFogo
{
    private string nome;
    private int dano;

    public Armas(string nome, int dano)
    {
        this.nome = nome;
        this.dano = dano;
    }
    public int getDano()
    {
        return dano;
    }
    public string getNome()
    {
        return nome;
    }

    public abstract void Usar(int dano);
}

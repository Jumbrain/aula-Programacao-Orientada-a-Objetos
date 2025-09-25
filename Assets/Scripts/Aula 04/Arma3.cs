using UnityEngine;

public class Arma3
{
    private string nome;
    private int dano;

    public Arma3(string nome, int dano)
    {
        this.nome = nome;
        this.dano = dano;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public int GetDano()
    {
        return dano;
    }

    public void SetDano(int dano)
    {
        this.dano = dano;
    }
}

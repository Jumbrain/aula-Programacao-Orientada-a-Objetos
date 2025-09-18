using UnityEngine;

public class ClasseRPG
{
    private string nome;
    private int vida;
    private int mana;

    public ClasseRPG(string nome, int vida, int mana)
    {
        this.nome = nome;
        this.vida = vida;
        this.mana = mana;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetVida(int vida)
    {
        this.vida = vida;
    }

    public int GetVida()
    {
        return vida;
    }

    public void SetMana(int mana)
    {
        this.mana = mana;
    }

    public int GetMana()
    {
        return mana;
    }
}

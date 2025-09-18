using UnityEngine;

public class ClasseInimigo
{
    private string nome;
    private int vida;
    private static int quantidadeInimigo;

    public ClasseInimigo(string nome, int vida)
    {
        this.nome = nome;
        this.vida = vida;
        quantidadeInimigo++;
    }

    public ClasseInimigo(string nome)
    {
        this.nome = nome;
        quantidadeInimigo++;
    }

    public ClasseInimigo()
    {
        quantidadeInimigo++;
    }

    public static int GetContarInimigos()
    {
        return quantidadeInimigo;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public int GetVida()
    {
        return vida;
    }

    public void SetVida(int vida)
    {
        this.vida = vida;
    }
}

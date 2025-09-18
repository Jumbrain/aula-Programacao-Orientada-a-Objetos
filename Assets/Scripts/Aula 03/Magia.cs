using UnityEngine;

public class Magia
{
    private string nome;
    private int poder;
    private string descricao;
    private static int contarMagias = 0;

    public Magia(string nome, int poder, string descricao)
    {
        this.nome = nome;
        this.poder = poder;
        this.descricao = descricao;
        contarMagias++;
    }

    public Magia()
    {
        contarMagias++;
    }

    public static int getContarMagias()
    {
        return contarMagias;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public int GetPoder()
    {
        return poder;
    }

    public void SetPoder(int poder)
    {
        this.poder = poder;
    }

    public string GetDescricao()
    {
        return descricao;
    }

    public void SetDescricao(string descricao)
    {
        this.descricao = descricao;
    }

    public string LancarMagia()
    {
        return "Lançando magia: " + nome + " com poder de " + poder + ". Descrição: " + descricao;
    }

    public string LancarMagia(string alvo)
    {
        return "Lançando magia: " + nome + " com poder de " + poder + " no alvo " + alvo + ". Descrição: " + descricao;
    }
}

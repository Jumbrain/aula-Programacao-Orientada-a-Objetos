using UnityEngine;

public class Inimigo2
{
    private string nome;
    private int vida;
    private int dano;

    public Inimigo2 (string nome, int vida, int dano)
    {
        this.nome = nome;
        this.vida = vida;
        this.dano = dano;
    }

    public string GetNome()
    {
        return nome;
    }

    public void Atacar(Player player)
    {
        player.ReceberDano(dano);
        Debug.Log($"{nome} atacou {player.GetNome()}, causando {dano} de dano!");
    }

    public void ReceberDano(int dano)
    {
        vida -= dano;
        Debug.Log($"{nome} recebeu {dano} de dano. Vida restante: {vida}");

        if(vida <= 0)
        {
            Debug.Log($"{nome} foi derrotado!");
        }
    }
}

using UnityEngine;

public class Inimigo2 : Personagem
{
    private int dano;

    public Inimigo2 (string nome, int vida, int dano) : base(nome, vida)
    {
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

    public void Reclamar()
    {
        Debug.Log("vai se fude doidao, fica gritando em ingles ai achando que é o maioral, você não entende que eu nasci para lutar, treinei por anos, só para em deparar com alguem como você, um lunático, um doido, que não-");
    }
}

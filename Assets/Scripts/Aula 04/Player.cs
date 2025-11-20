using UnityEngine;
using System.Collections.Generic;

public class Player : Personagem
{
    private List<Armas> armas = new List<Armas>();
    private Armadura armadura;
    private Escudo escudo;

    public Player (string nome, int vida) : base(nome, vida)
    {

    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetArma(Armas arma)
    {
        armas.Add(arma);
    }

    public List<Armas> GetArmas()
    {
        return armas;
    }

    public void SetArmadura(Armadura armadura)
    {
        this.armadura = armadura;
    }

    public Armadura GetArmadura()
    {
        return armadura;
    }

    public void SetEscudo(Escudo escudo)
    {
        this.escudo = escudo;
    }

    public Escudo GetEscudo()
    {
        return escudo;
    }

    public void Atacar(Inimigo2 inimigo, Arma3 arma)
    {
        inimigo.ReceberDano(arma.GetDano());
        Debug.Log($"{nome} atacou {inimigo.GetNome()} com {arma.GetNome()}, causando {arma.GetDano()} de dano!");
    }

    public void ReceberDano(int dano)
    {
        int defesaTotal = armadura.GetDefesa() + escudo.GetDefesaExtra();
        int danoFinal = dano - defesaTotal;
        vida -= danoFinal;
        Debug.Log($"{nome} recebeu {danoFinal} de dano após defender ({defesaTotal}). Vida restante: {vida}");
    }
}
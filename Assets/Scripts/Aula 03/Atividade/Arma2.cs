using UnityEngine;

public class Arma2
{
    private int forca;
    private string efeito;

    public string Atacar()
    {
        return "Ataque Simples";
    }

    public string Atacar(int forca)
    {
        return "Ataque Simples com " + forca;
    }

    public string Atacar(string efeito)
    {
        return "Ataque simples com um efeito de " + efeito;
    }
}

using UnityEngine;

public class ClasseArma
{
    private string tipo;
    private int balas;

    public string GetTipoDaArma()
    {
        return tipo;
    }

    public void SetTipoDaArma(string tipo)
    {
        this.tipo = tipo;
    }

    public int GetBalas()
    {
        return balas;
    }

    public void SetBalas(int balas)
    {
        this.balas = balas;
    }
}

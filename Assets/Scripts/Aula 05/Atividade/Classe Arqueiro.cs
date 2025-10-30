using UnityEngine;

public class ClasseArqueiro : Personagem
{
    private int flechas;

    public ClasseArqueiro(string nome, int vida, int flechas) : base(nome, vida)
    {
        this.flechas = flechas;
    }

    public void SetFlechas(int flechas)
    {
        this.flechas = flechas;
    }

    public int GetFlechas()
    {
        return flechas;
    }

    public void AtirarFlecha()
    {
        flechas--;
        Debug.Log( nome + " atirou uma flecha! Ele/Ela agora possui " + flechas + " flechas.");
    }
}

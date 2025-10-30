using UnityEngine;

public class AtividadeAula05 : MonoBehaviour
{
    void Start()
    {
        ClasseArqueiro arqueiro = new ClasseArqueiro("Elzer", 40, 5);
        arqueiro.AtirarFlecha();
    }

    void Update()
    {
        
    }
}

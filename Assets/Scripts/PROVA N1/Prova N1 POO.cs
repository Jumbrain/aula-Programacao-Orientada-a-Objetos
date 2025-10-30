using System;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using UnityEngine.UIElements;
public class ProvaN1POO
{
    //Objeto é uma coisa real ou abstrata que possui caracteristicas e comportamentos

    //Uma classe é um modelo(prototipo) que define as variaveis e os metodos(comportamento) comuns a todos os objetos do mesmo tipo.
    //Exemplo: classe é um modelo / molde / projeto de um carro, já o objeto, possuiria seus proprios estados (cor, gasolina, potencia) e seus proprios comportamentos (liga, acelera, breca)

    //Instancia: ato de criar um objeto (instanciação), a classe é uma representação de um objeto, já a instancia de uma classe é o objeto com tempo e espaço de existencia

    //Visibilidade: tipos de visibilidade para componentes de classe (atributos e operações) (variaveis) (Em POO, os metodos são publicos e seus atributos são privados)
    //Public (+) : visivel para todos os objetos de um sistema
    //Private (-) : somente componentes de outras classes podem acessá-los
    //Protected (#) : componentes de outras classes e componentes de subclasses podem acessá-los

    //Metodo Get e Set
    //Get: leem e retornam o valor de um atributo

    private string nome;
    private int vida;
    public string GetNome()
    {
        return nome;
    }
    public int GetVida()
    {
        return vida;
    }

    //Set: responsavel por escrever/alterar o conteudo de um atributo
    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public void SetVida(int vida)
    {
        this.vida = vida;
    }

    //GameObject: um objeto que funciona na Unity, porque ele possui os padrões MonoBehaviour, geralmente ele aparece ao lado do nome do Script que criou na unity
    //Exemplo: se eu quero criar um script de um personagem que funcione na Unity, no script dele estaria assim: CharacterController : MonoBehaviour

    //Metodo Construtor: determina quais ações devem ser executadas quando um objeto dessa classe for instanciado, o nome do método deve ser o mesmo da classe e sem indicação do tipo de retorno.
    //O construtor é invocado no momento da criação / instanciação do objeto atráves do operador new
    //Exemplo Implementação:
    public string cpf;
    public int idade;

    public ProvaN1POO(string cpf, int idade)
    {
        this.cpf = cpf;
        this.idade = idade;
    }

    //Sobrecarga de Métodos
    //Em C#, dois ou mais métodos da mesma classe podem compartilhar o mesmo nome, contanto que suas declarações de parâmetros sejam diferentes (mesmo nome, assinatura diferente).
    
    public string magia;
    public int poder;
    public void Magia(string magia)
    {
        this.magia = magia;
    }
    public void Magia(string magia, int poder)
    {
        this.magia = magia;
        this.poder = poder;
    }

    // Atributos e Métodos estáticos: são pertencentes a classe e não a instancia, podem ser acessados e modificados diretamente pela classe sem a necessidade de instanciação
    // utiliza a palavra chave static

    public static int quantidadePessoas = 0;
    public ProvaN1POO()
    {
        quantidadePessoas++;
    }
    public int getQtdPessoas()
    {
        return quantidadePessoas;
    }

    //Array : uma lista com limite definido que deve ser preenchido pela mesma classe de atributo.
    public string[] magias;
    //magias[0] = bola de fogo;
    //magias[1] = nevasca;

    //Lista : sem limite e pode ser de diferentes classes de atributos, como ints, strings, floats e mais;
}

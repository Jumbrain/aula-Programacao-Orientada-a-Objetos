using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Assets
{
    public class Pessoa
    {
        private string nome;
        private string email;

        public void receberNome(string nome)
        {
            this.nome = nome;
        }

        public string falarMeuNome()
        {
            return "meu nome é " + nome;
        }

        public string perguntar(Pessoa p)
        {
            string mensagem = "qual é o teu nome? ";
            mensagem += p.falarMeuNome();
            return mensagem;
        }
    }
}

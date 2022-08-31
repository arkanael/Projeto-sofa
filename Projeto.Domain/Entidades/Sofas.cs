using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Entidades
{
    public class Sofas
    {
       
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public void SetSofa(string nome, bool inspetor )
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception("Nome não pode ser vazio ou nulo");

            if (inspetor)
                throw new Exception($"O usuário {nome} não tem permissão para cadastrar um novo sofá");

            Nome = nome;
        }
    }
}

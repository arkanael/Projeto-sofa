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
        public bool Avaliacao { get; private set; }
        public int AvaliadoPor { get; set; }
        public DateTime DatAvaliacao { get; set; }

        public void Registrar(string nome, Usuario usuario )
        {
            
            if (string.IsNullOrEmpty(usuario.Nome))
                throw new Exception("Nome não pode ser vazio ou nulo");

            if (usuario.Inspetor)
                throw new Exception($"O usuário {usuario.Nome} não tem permissão para cadastrar um novo sofá");
            
            
            Id = 1;

            Nome = nome;
        }

        public void Avaliar(bool avaliacao, Usuario usuario, int id)
        {
            if (usuario.Inspetor.Equals(false))
                throw new Exception($"O usuário não tem permissão para avaliar o sofá");

            Avaliacao = avaliacao;
            DatAvaliacao = DateTime.Now;
            AvaliadoPor = usuario.Id;
        }
    }
}

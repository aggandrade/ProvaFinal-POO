using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1ARTUR04.code.DTO
{
    class EstoqueDTO
    {
        private int id;
        private string nome;
        private string categoria;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Categoria { get => categoria; set => categoria = value; }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _3A1ARTUR04.code.DTO;
using _3A1ARTUR04.code.DAL;

namespace _3A1ARTUR04.code.BLL
{
    class EstoqueBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_estoque";
        public void Inserir (EstoqueDTO estdto)
        {
            string inserir = $"insert into {tabela} values(null '{estdto.Nome}','{estdto.Categoria}')";
            conexao.ExecutarComando(inserir);
        }
    }
}

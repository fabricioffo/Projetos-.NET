using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//localização da classe dentro do projeto
namespace Projeto01.Entities
{
    //definição da classe
    public class Produto
    {
        //prop + 2x[tab]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}

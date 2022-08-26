using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//declaração da classe no projeto
namespace Projeto01.Repositories
{
    //declaração da classe
    public class ProdutoRepository
    {
        //método para exportar os dados do produto para arquivo TXT
        public void GravarArquivo(Produto produto)
        {
            //definindo o caminho da pasta
            var path = "c:\\temp\\";

            //criando a pasta
            CriarDiretorio(path);

            //abrindo um arquivo em modo de escrita (StreamWriter)
            //realizando a abertura do arquivo de modo a fecha-lo ao final do uso
            using (var streamWriter = new StreamWriter("c:\\temp\\produtos.txt", true)) //o true não deixa sob escrever o arquivo
            {
                //Gravar os dados do produto no arquivo
                streamWriter.WriteLine("Código: "+ produto.Codigo);
                streamWriter.WriteLine("Nome: " + produto.Nome);
                streamWriter.WriteLine("Preço: " + produto.Preco);
                streamWriter.WriteLine("Quantidade: " + produto.Quantidade);
                streamWriter.WriteLine("---");
            } 
        }

        //método para criar uma pasta gravação do arquivo
        private void CriarDiretorio(string path)
        {
            //verificar se o diretorio não existe
            if(!Directory.Exists(path))
            {
                //criar o diretorio
                Directory.CreateDirectory(path);
            }
        }
    }
}

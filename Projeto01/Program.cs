// See https://aka.ms/new-console-template for more information
using Projeto01.Entities; // Importando o namespace
using Projeto01.Repositories; //Importando o namespace


namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {

            //criando um objeto da classe produto
            var produto = new Produto();

            //criando um objeto da classe ProdutoRepository
            var produtoRepository = new ProdutoRepository();


            try //tentativa 
            {
                //mensagem no prompt de comando
                Console.WriteLine("\n **** CADASTRO DE PRODUTOS **** \n");

                Console.Write("Informe o código do produto: ");
                produto.Codigo = int.Parse(Console.ReadLine());

                Console.Write("Informe o nome do produto: ");
                produto.Nome = Console.ReadLine();

                Console.Write("Informe o preço do produto: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("Informe a quantidade do produto: ");
                produto.Quantidade = int.Parse(Console.ReadLine());

                //imprimir os valores informados
                //cw + 2x[tab]
                Console.WriteLine("\nDADOS DO PRODUTO\n");

                Console.WriteLine("Código:" + produto.Codigo);
                Console.WriteLine("Nome:" + produto.Nome);
                Console.WriteLine("Preço:" + produto.Preco);
                Console.WriteLine("Qantidade:" + produto.Quantidade);

                //gravar os dados em arquivo
                produtoRepository.GravarArquivo(produto);

                Console.WriteLine("Produto cadastrado com sucesso!!!!");
            }
            catch(Exception e) //captura da exceção
            {
                //imprimir mensagem de erro
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }

            //pressionar uma tecla para continuar
            Console.ReadKey();
        }
    }
}

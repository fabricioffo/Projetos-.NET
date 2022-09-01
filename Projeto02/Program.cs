using System;
using Projeto02.Entities;
using Projeto02.Utils;
using Projeto02.Repositories;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*** EXPORTADOR DE FUNCIONÁRIOS ***\n");

            try
            {
                var funcionario = new Funcionario();
                funcionario.Setor = new Setor();
                funcionario.Funcao = new Funcao();

                funcionario.Id = Guid.NewGuid();
                funcionario.Nome = ConsoleUtil.ReadString("Nome: ");
                funcionario.CPF = ConsoleUtil.ReadString("CPF: ");
                funcionario.Matricula = ConsoleUtil.ReadString("Matricula: ");
                funcionario.DataAdmissao = ConsoleUtil.ReadDateTime("Data de admissão: ");
                funcionario.Salario = ConsoleUtil.ReadDecimal("Salário: ");
                 
                funcionario.Setor.Id = Guid.NewGuid(); 
                funcionario.Setor.Nome = ConsoleUtil.ReadString("Nome do Setor: ");
                funcionario.Setor.Sigla = ConsoleUtil.ReadString("Sigla: ");

                funcionario.Funcao.Id = Guid.NewGuid();
                funcionario.Funcao.Descricao = ConsoleUtil.ReadString("Descrição da função: ");


                var funcionarioRepository = new FuncionarioRepository();
                funcionarioRepository.Exportar(funcionario);

                Console.WriteLine("\nFuncionario gravado em JSON com sucesso!");

                //importando o funcionário
                var registro = funcionarioRepository.Importar();


                Console.WriteLine("Id do funcionário: " + registro.Id);
                Console.WriteLine("Nome: " + registro.Nome);
                Console.WriteLine("Matrícula: " + registro.Matricula);
                Console.WriteLine("CPF: " + registro.CPF);
                Console.WriteLine("salário: " + registro.Salario);
                Console.WriteLine("Data de admissão: " + registro.DataAdmissao);

                Console.WriteLine("Id do Setor: " + registro.Setor.Id);
                Console.WriteLine("Sigla do Setor: " + registro.Setor.Sigla);
                Console.WriteLine("Nome do Setor: " + registro.Setor.Nome);

                Console.WriteLine("Id da Função : " + registro.Funcao.Id);
                Console.WriteLine("Descrição: " + registro.Funcao.Descricao); 

            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: "+ e.Message);
            }

            Console.ReadKey();
        }
    }
}

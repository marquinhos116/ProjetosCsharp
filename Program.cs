
using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao Gerenciador = new GerenciadorBonificacao();
            


            
            
            
            
            
            Funcionario Carlos = new Funcionario();

            Carlos.Nome = "Carlos";
            Carlos.CPF = "121.806.976-78";
            Carlos.Salario = 2000;


            Gerenciador.Registrar(Carlos);
            

            Diretor Roberta = new Diretor();

            Roberta.Nome = "Roberta";
            Roberta.CPF = "454.658.148-3";
            Roberta.Salario = 5000;

            Gerenciador.Registrar(Roberta);

            Console.WriteLine(Carlos.Nome);
            Console.WriteLine(Carlos.GetBonificacao());

            Console.WriteLine(Roberta.Nome);
            Console.WriteLine(Roberta.GetBonificacao());

            Console.WriteLine("Total de Bonificações é = "  + Gerenciador.GetTotalBonificacao());



            Console.ReadLine();


        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 10;
            double idade1 = 25;
            long idade2 = 30;
            String idade3 = "30";


            int varRecebeDouble = (int) idade1;

            int varRecebeDouble1 = Convert.ToInt16(idade3);


            String nome = "Lucas";
            String nome2 = "Henrique";


            bool verdadeiro = true;

            if (verdadeiro == true) {

                Console.Write("verdadeiro = true");

            }


            if (nome.Length < nome2.Length) {

                Console.Write("\n"+  nome2 + "\n");
            }


            Console.WriteLine("\n" + nome + nome2);
            Console.WriteLine(varRecebeDouble1 + varRecebeDouble);
            
            Console.WriteLine("Executando projeto 2 - Criando Variveis");
            Console.WriteLine("Execução finalizada. tecle para continua!!");
            Console.ReadLine();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Earth1702483_Gabriela

namespace _4Earth1702483_Gabriela
{
    class Program
    {
        static void Main(string[] args)
        {
            Login 1 = new Login();
            1.Email  = "Barbara123@gmail.com";
            1.Nome = "barbara";
            1.ID = 33;

            Console.WriteLine(" Identificação: " + 1.obterNome());
            Console.WriteLine("Identificação: R$" + 1.obterEmail());
            Console.WriteLine(1.GerarHash());

            foreach (var item in 1.GerarLista())
            {
                

              Console.WriteLine(item);
            }


            Console.ReadKey();


        }
    }
    }
}

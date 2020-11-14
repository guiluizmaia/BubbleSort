using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bolha();
            Bolha_Otimizado();
        }

        static void Bolha()
        {
            List<int> elementos = new List<int>();

            bool opcao = true;
            while (opcao)
            {
                Console.Clear();
                Console.WriteLine("Informe o número: ");
                elementos.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Deseja inserir outro número? [s/n]");
                opcao = Console.ReadLine() == "s" ? true : false;
                //operação ternária
            }

            //Ordenação utilizando o Bubble Sort
            for (int i = 0; i < elementos.Count - 1; i++)
            {
                for (int ord = 0; ord < elementos.Count - 1; ord++)
                {
                    int temp = 0;
                    if (elementos[ord] > elementos[ord+1])
                    {
                        temp = elementos[ord + 1];
                        elementos[ord + 1] = elementos[ord];
                        elementos[ord] = temp;
                    }
                }
            }

            foreach(int item in elementos)
                Console.Write(item + " ");

            Console.ReadKey();
        }
        static void Bolha_Otimizado()
        {
            List<int> elementos = new List<int>();
            int varreduras = 0;
            bool opcao = true;
            bool trocou = false;

            while (opcao)
            {
                Console.Clear();
                Console.WriteLine("Informe o número: ");
                elementos.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Deseja inserir outro número? [s/n]");
                opcao = Console.ReadLine() == "s" ? true : false;
                //operação ternária
            }

            //Ordenação utilizando o Bubble Sort
            for (int i = 0; i < elementos.Count - 1; i++)
            {
                trocou = false;
                varreduras++;
                for (int ord = 0; ord < elementos.Count - 1; ord++)
                {
                    int temp = 0;
                    if (elementos[ord] > elementos[ord + 1])
                    {
                        temp = elementos[ord + 1];
                        elementos[ord + 1] = elementos[ord];
                        elementos[ord] = temp;

                        trocou = true;
                    }
                }
                if (!trocou) break;
            }
            Console.WriteLine(varreduras);

            foreach (int item in elementos)
                Console.Write(item + " ");

            Console.ReadKey();
        
    }
}

}

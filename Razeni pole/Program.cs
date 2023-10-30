using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razeni_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte celá čísla a oddělte je čárkou:");
            string vsechnaCislaString = Console.ReadLine();
            char[] oddelovac = new char[] { ',' };
            string[] vsechnaCislaPole = vsechnaCislaString.Split(oddelovac);
            int[] vsechnaCisla = new int[vsechnaCislaPole.Length];
            Console.WriteLine("Vaše zadaná čísla jsou:");
            for (int i = 0; i < vsechnaCislaPole.Length; i++)
            {
                vsechnaCisla[i] = int.Parse(vsechnaCislaPole[i]);
                Console.Write("{0} ", vsechnaCisla[i]);
            }
            Console.WriteLine("Teď je seřadíme sestupně...");

            for (int i = 0; i < vsechnaCisla.Length; i++)
            {
                for (int j = i + 1; j < vsechnaCisla.Length; j++)
                {
                    if (vsechnaCisla[i] < vsechnaCisla[j])
                    {
                        int docasne = vsechnaCisla[i];
                        vsechnaCisla[i] = vsechnaCisla[j];
                        vsechnaCisla[j] = docasne;
                    }
                }
            }
            Console.WriteLine("Sestupně jsou čísla seřazena takto:");
            for (int i = 0; i < vsechnaCisla.Length; i++)
            {
                Console.Write("{0} ", vsechnaCisla[i]);
            }
            Console.WriteLine();
        }
    }
}

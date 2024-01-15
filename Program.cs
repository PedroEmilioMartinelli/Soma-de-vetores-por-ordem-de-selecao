using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace soma_de_vetres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(new int[] { 2, 4, 6 });
            int soma = 0;

            if (list.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                int x = list[0];
                x = x + list[1];
                x = x + list[2];
                Console.WriteLine(x);

            }

        }







    }
}
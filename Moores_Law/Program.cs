﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moores_law
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Pentu a calcula dupa cat timp puterea de calcul va fi de n ori mai mare am folosit formula log2 n=x*18(numarul de luni dupa care se dubleaza)
            
            int n;

            Console.WriteLine("Introdiceti n: ");
            
            n = int.Parse(Console.ReadLine());

            double raspuns;

            raspuns = (Math.Log(n , 2)) * 18;

            Console.WriteLine("Dupa " + (((int)raspuns)/12) + " ani si " + (((int)raspuns) % 12) + " luni puterea de calcul se va imbunatati de " + n + " ori");

            Console.ReadKey();
        }
    }
}

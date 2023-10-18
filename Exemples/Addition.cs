using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp
{
    class Addition
    {
        static void Main(string[] args)
        {
            // déclaration de deux variable et le résultat en Int
            int Input1, Input2, Result;
            Console.WriteLine("Valeur 1 :");
            Input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valeur 2 :");
            Input2 = Convert.ToInt32(Console.ReadLine());
            Result = Input1 + Input2;
            Console.WriteLine("L'addition des deux valeurs est : " + Result.ToString());
            Console.ReadLine();
        }
    }
}

using System;

namespace Aula10Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Dante:");
           Dante dante = new Dante();
           dante.Correr();
           dante.Pular();

           System.Console.WriteLine("Nero:");

           Nero nero = new Nero();
           nero.Correr();
           nero.Pular();
        }
    }

}

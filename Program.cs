using System;

namespace Aula10Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Dante:");
           Dante dante = new Dante();
           dante.Atacar();
           dante.Defender();

           System.Console.WriteLine("Nero:");

           Nero nero = new Nero();
           nero.Atacar();
           nero.Defender();
        }
    }

}

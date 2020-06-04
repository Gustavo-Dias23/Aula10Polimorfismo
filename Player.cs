namespace Aula10Polimorfismo
{
    public class Player
    {
        public virtual void Pular(){
            System.Console.WriteLine("Está pulando normalmente.");
        }
        public virtual void Correr(){
            System.Console.WriteLine("Está correndo normalmente.");
        }
    }
}
namespace Aula10Polimorfismo
{
    public class Player
    {
        public virtual void Atacar(){
            System.Console.WriteLine("Ataca normalmente.");
        }
        public virtual void Defender(){
            System.Console.WriteLine("Defende normalmente.");
        }
    }
}
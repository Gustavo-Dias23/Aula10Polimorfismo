namespace Aula10Polimorfismo
{
    public class Luigi : Player
    {
        public override void Pular(){
            base.Pular();

            System.Console.WriteLine("Luigi agora está pulando com uma altura 30% maior.");
        }
    }
}
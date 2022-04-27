using System;
using Unity;

namespace JPMC_BowlingGame
{
    /// <summary>
    /// Program Class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Roles:");
            int[] pins = new int[21];
            for (int i = 0; i < pins.Length; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int x))
                {
                    pins[i] = x;
                }
            }

            // Use Unity container to get instance of Bowling
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IBowling, Bowling>();
            IBowling bowling = container.Resolve<IBowling>();

            bowling.Roll(pins);
            int finalScore = bowling.GetScore();
            Console.WriteLine("Total Bowling score is:" +finalScore.ToString());
            Console.ReadKey();
        }
    }
}

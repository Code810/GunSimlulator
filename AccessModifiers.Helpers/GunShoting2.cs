

namespace GunSimulator.Helpers
{
    public class GunShoting2
    {
        ConsoleKeyInfo Command;
        int Count;
        public void StartGunShooting(int num = 30)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            Command = key;
            Count = num;
            if (key.Key == ConsoleKey.R) 
            { 
                Reload(); 
            }
            else if (num == 0)
            {
                Console.WriteLine("you're out of bullets"); StartGunShooting(0);
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                StandartShooting();
            }
            else if (key.Key == ConsoleKey.Tab)
            {
                SwitchMode();
            }
            else if (key.Key == ConsoleKey.I)
            {
                Console.WriteLine($"You have {Count} bullets"); num++;
            }
            else
            {
                StartGunShooting(Count);
            }
            StartGunShooting(num - 1);
        }
        public void StandartShooting()
        {
            Console.WriteLine("***shoot***");
            StartGunShooting(Count - 1);
        }
        public void Reload()
        {
            Console.WriteLine("30 bullets reloaded");
            Count = 30;
            StartGunShooting(Count);
        }
        public void AvtoShooting(int num)
        {
            if (num == 0) { Console.WriteLine("you're out of bullets"); StartGunShooting(0); }
            Console.WriteLine("***shoot***");
            AvtoShooting(num - 1);
        }
        public void SwitchMode()
        {
            Console.WriteLine("changed auto shooting mode ");
            
                Command = Console.ReadKey(true);
                if (Command.Key == ConsoleKey.Enter)
                {
                    AvtoShooting(Count);
                }
                else StartGunShooting(Count);
            
        }

    }
}

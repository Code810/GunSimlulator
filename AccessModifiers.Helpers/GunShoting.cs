
using System.Diagnostics.Metrics;

namespace GunSimulator.Helpers
{
    public class GunShoting
    {
        string Command;
        int Count;
        public void StartGunShooting(int num=30)
        {
            string start = Console.ReadLine();
            Command = start;
            Count = num;
            if (Command == "reload") 
            { 
                Reload(); 
            }  
            else if (num == 0) 
            { 
                Console.WriteLine("you're out of bullets"); StartGunShooting(0); 
            }
            else if (Command == "enter") 
            {
                StandartShooting();
            }
            else if (Command == "tab") 
            { 
                SwitchMode(); 
            }
            else if (Command == "info") 
            { 
                Console.WriteLine($"You have {Count} bullets");num++; 
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
            StartGunShooting(Count-1);  
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
            AvtoShooting(num-1);
        }
        public void SwitchMode()
        {
            Console.WriteLine("changed auto shooting mode");
            Command = Console.ReadLine();

                if (Command == "enter")
                {
                    AvtoShooting(Count);
                }
                
            else StartGunShooting(Count);
        }
    }
}

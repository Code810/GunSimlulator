
using System.Diagnostics.Metrics;

namespace AccessModifiers.Helpers
{
    public class GunShoting2
    {
        string Command;
        int Count;
        public void StartGunShoting(int num=30)
        {
            string start = Console.ReadLine();
            Command = start;
            Count = num;
            if (Command == "reload") { Reload(); }  //Console.WriteLine("30 gulle dolduruldu"); Count = 30; }
            else if (num == 0) { Console.WriteLine("Gulleniz bitdi"); StartGunShoting(0); }
            else if (Command == "enter") { StandartShoting(); }
            else if (Command == "tab") { SelectionMode(); }
            else if (Command == "viev") { Console.WriteLine($"{Count} gulleniz qalib");num++; }
            else { StartGunShoting(Count); }
            StartGunShoting(num - 1);
        }
        public void StandartShoting()
        {
            Console.WriteLine("Ates");
            StartGunShoting(Count-1);  
        }
        public void Reload()
        {
            Console.WriteLine("30 gulle dolduruldu");
            Count = 30;
            StartGunShoting(Count);
        }
        public void AvtoShoting(int num)
        {
            if (num == 0) { Console.WriteLine("Gulleniz bitdi"); StartGunShoting(0); }
            Console.WriteLine("Ates");
            AvtoShoting(num-1);
        }
        public void SelectionMode()
        {
            Console.WriteLine("avto rejim ve ya adi rejim :");
            Command = Console.ReadLine();
            if (Command =="avto")
            {
                Command = Console.ReadLine();
                if (Command == "enter")
                {
                    AvtoShoting(Count);
                }
                else StartGunShoting(Count);
            }
            else StartGunShoting(Count);
        }
    }
}

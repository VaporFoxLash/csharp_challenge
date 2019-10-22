using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace donaldStep
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<string>> houseList = new Dictionary<int, List<string>>();
            List<string> lis1 = new List<string>(
                new string[] {"Aliec", "Ariel", "Aurora", "Phil", "Peter", "Olaf", "Phoebus", "Ralph", "Robin"});
            List<string> list2 = new List<string>(
                new string[] {"Bambi", "Belle", "Bolt", "Mulan", "Mowgli", "Mickey", "Silver", "Simba", "Stitch"});
            List<string> list3 = new List<string>(
                new string[] {"Dumbo", "Genie", "Jiminy", "Kuzko", "Kida", "Kenai", "Tarzan", "Tiana", "Winnie"});
            houseList.Add(1, lis1);
            houseList.Add(2, list2);
            houseList.Add(3, list3);

            int n = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[n+1];
            int steps = 0;
            for (int i = 0; i < n; i++)
            {
                names[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                if ((lis1.Contains(names[i]) && list2.Contains(names[i + 1])) ||
                    (list2.Contains(names[i]) && list3.Contains(names[i + 1])))
                {
                    steps++;
                }
                else if ((lis1.Contains(names[i]) && list3.Contains(names[i + 1])) ||
                         (list3.Contains(names[i]) && lis1.Contains(names[i + 1])))
                {
                    steps += 2;
                }
            }
            Console.WriteLine(steps);
        }
    }
}
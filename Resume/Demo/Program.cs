using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Models;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Services> services = new List<Services>();

            Services s1 = new Services();
            s1.Name = "Customer Support";
            s1.Icon = "rs-cust";
            s1.Info = "1 Lorem ipsum dolor sit amet, consectetur adipiscing metus. elit. Quisque rutrum pellentesque imperdiet.";
            services.Add(s1);

            Services s2 = new Services();
            s2.Name = "Sliders";
            s2.Icon = "rs-slide";
            s2.Info = "2 Lorem ipsum dolor sit amet, consectetur adipiscing metus. elit. Quisque rutrum pellentesque imperdiet.";

            services.Add(s2);

            foreach (Services menimServisim in services)
            {
                Console.WriteLine($"{menimServisim.Name} {menimServisim.Icon} - {menimServisim.Info}");
            }

            Console.ReadLine();

        }
    }
}

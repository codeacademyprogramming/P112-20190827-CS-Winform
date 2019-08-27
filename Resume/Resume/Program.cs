using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Models;

namespace Resume
{
    class Program
    {
        static void Main(string[] args)
        {

            Person adam = new Person() {
                Name = "Cavid",
                Surname = "Dadashov",
                Address = "Nerimanov",
                Birthday = new DateTime(1997, 9, 27),
                Email = "javidfd@code.edu.az",
                Freelance = new DateTime(2019, 5, 27),
                Phone = "+994515083898",
                Photo = "/image/cavid.jpeg",
                Position = "Fullstack Developer"
            };

            List<SocialMedia> smList = new List<SocialMedia>();
            

            SocialMedia sm1 = new SocialMedia();
            sm1.Name = "Facebook";
            sm1.IconName = "rsicon-facebook";
            sm1.Link = "www.facebook.com";

            smList.Add(sm1);



            SocialMedia sm2 = new SocialMedia();
            sm2.Name = "Twitter";
            sm2.IconName = "rsicon-twitter";
            sm2.Link = "www.twitter.com";

            smList.Add(sm2);

            SocialMedia sm3 = new SocialMedia();
            sm3.Name = "Instagram";
            sm3.IconName = "rsicon-instagram";
            sm3.Link = "www.instagram.com";

            smList.Add(sm3);

            adam.SocialMedias = smList;



            foreach (SocialMedia item in adam.SocialMedias)
            {
                Console.WriteLine($"{item.Name} {item.IconName}");
            }



            Console.ReadLine();
        }
    }
}

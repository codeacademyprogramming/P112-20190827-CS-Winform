using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Models
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Freelance { get; set; }
        public string Photo { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}

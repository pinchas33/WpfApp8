using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class meneger
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public MailAddress Email { get; set; }
        public string password { get; set; }
        public  string deatales { get; set; } 
        public  List<Soldier> soldiers { get; set; }
    }
}

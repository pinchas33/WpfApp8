using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DO;
using DS;

namespace Dal
{
    internal static class Configuration
    {
        public static meneger staticMeneger { set; get; } = new meneger()
        {
            Email = new MailAddress("rozenbergPincjas@gamil.com"),
            Id = "2",
            Name = "pinchas rozenberg",
            password = "123456",
            soldiers =  DataSource.soldiers,
        };

    }
}

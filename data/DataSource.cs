using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DO;


namespace DS
{
    public static class DataSource

    {
        public static List<Soldier> soldiers { get; set; } = new List<Soldier>();
        public static List<report> reports { get; set; } = new List<report>();
       // public static List<meneger> menegers { get; set; } = new List<meneger>();
        static DataSource()
        {
            Soldier s1 = new Soldier();
            s1.Id = "3";
            s1.firstName = "3";
            s1.lastName = "3";
            s1.phone = "3";
            s1.rank = "3";
            s1.addres = "3";
            s1.Remarks = "3";
            soldiers.Add(s1);

            Soldier s2 = new Soldier();
            s2.Id = "1";
            s2.firstName = "1";
            s2.lastName = "1";
            s2.phone = "1";
            s2.rank = "1";
            s2.addres = "1";
            s2.Remarks = "1";
            soldiers.Add(s2);

            Soldier s3 = new Soldier();
            s3.Id = "2";
            s3.firstName = "2";
            s3.lastName = "2";
            s3.phone = "2";
            s3.rank = "2";
            s3.addres = "2";
            s3.Remarks = "2";
            soldiers.Add(s3);

            //meneger m1 = new meneger();
            //m1.Id = "2";
            //m1.Name = "robot";
            //m1.soldiers = soldiers;
            //menegers.Add(m1);
        }

    }
}

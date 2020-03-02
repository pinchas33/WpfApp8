using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BlApi
{
    public interface IBl
    {
        Soldier GetSoldier(string id);
        void addSoldier(Soldier soldier);
        void updateSoldier(Soldier updateSoldier);
        void DeleteSoldier(string id);
        meneger GetMeneger();

        report GetReport(string id);
        void addReport(report report);

        void updateMeneger(meneger meneger);

        void SendMail();


        IEnumerable<IGrouping<string, Soldier>> GroupsoldierBycriteria();
    }
}

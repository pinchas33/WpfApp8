using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace DalApi
{
    public interface IDal
    {
        Soldier GetSoldier(string id);
        void addSoldier(Soldier soldier);
        void updateSoldier(Soldier updateSoldier);
        void DeleteSoldier(string id);


        report GetReport(string id);
        void addReport(report report);


        meneger GetMeneger(string id);
        void addMeneger(meneger meneger);


    }
}

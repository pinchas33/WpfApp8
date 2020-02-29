using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using DO;
using DS;

namespace Dal
{
    internal sealed class DalObject : IDal
    {
        private DalObject() { }
        public static DalObject Instance { get; } = new DalObject();

        public Soldier GetSoldier(string id)
        {
            Soldier soldier = new Soldier();

            soldier = DataSource.soldiers.FirstOrDefault(tempSoldier => tempSoldier.Id == id);
            if (soldier == null)
            {
                throw new ArgumentNullException();
            }
            return soldier;
        }
        public void addSoldier(Soldier soldier)
        {
            if (DataSource.soldiers.Any(tempSoldier => tempSoldier.Id == soldier.Id))
            {
                throw new ArgumentException();
            }
            DataSource.soldiers.Add(soldier);
        }

        public void updateSoldier(Soldier updateSoldier)
        {
            DataSource.soldiers.Remove(DataSource.soldiers.FirstOrDefault(tempSoldier => tempSoldier.Id == updateSoldier.Id));
            DataSource.soldiers.Add(updateSoldier);
        }

        public void DeleteSoldier(string id)
        {
            DataSource.soldiers.Remove(DataSource.soldiers.FirstOrDefault(tempSoldier => tempSoldier.Id == id));
        }

        public report GetReport(string id)
        {
            report report = new report();

            report = DataSource.reports.FirstOrDefault(tempREport => tempREport.idOfReport == id);
            if (report == null)
            {
                throw new ArgumentNullException();
            }
            return report;
        }
        
        public void addReport(report report)
        {
            //if (DataSource.reports.Any(tempREport => tempREport.idOfReport == report.idOfReport))
            //{
            //    throw new ArgumentException();
            //}
            DataSource.reports.Add(report);
        }

        public meneger GetMeneger(string id)
        {
            meneger meneger = new meneger();
            meneger = DataSource.menegers.FirstOrDefault(tempMeneger => tempMeneger.Id == id);
            return meneger;
        }
        public void addMeneger(meneger meneger)
        {
            if (DataSource.menegers.Any(tempmeneger => tempmeneger.Id == meneger.Id))
            {
                throw new ArgumentNullException();
            }
            DataSource.menegers.Add(meneger);
        }

    }
}

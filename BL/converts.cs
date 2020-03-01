using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DalApi;
using DO;

namespace BL
{
    public static class Converts
    {
        static readonly IDal dalObject = DalFactory.GetDal();

        static public T ConvertTypes<T, S>(S original)
        {
            try
            {
                T target = (T)Activator.CreateInstance(typeof(T));

                PropertyInfo[] propsOriginal = original.GetType().GetProperties();
                PropertyInfo[] propsTarget = target.GetType().GetProperties();
                PropertyInfo targProp;


                foreach (var origProp in propsOriginal)
                {
                    targProp = propsTarget.FirstOrDefault(targ => origProp.Name == targ.Name);
                    if (targProp.Name == "soldiers")
                    {
                        switch(target)
                        {
                            case BO.meneger meneger:
                                complateSoldierToBO(target, original);
                                break;
                            case DO.meneger meneger:
                                complateSoldierToDO(target, original);
                                break;
                            default: break;
                        }
  
                    }
                    else if (targProp.Name == "Reports")
                    {
                          complateReport(target, original);                
                    }
                    else if (targProp != null)
                    {
                        object obj = origProp.GetValue(original);
                        targProp.SetValue(target, obj);
                    }
                }

                return target;
            }
            catch (NullReferenceException ex)
            {
                throw new NullReferenceException(ex.Message);
            }
        }

        private static BO.meneger complateSoldierToBO<T, S>(T target, S original)
        {
            List<DO.Soldier> DOsoldiers = (original as DO.meneger).soldiers;
            List<BO.Soldier> BOsoldiers = new List<BO.Soldier>();
            if (DOsoldiers != null)
            {
                foreach (var s in DOsoldiers)
                {
                    BOsoldiers.Add(ConvertTypes<BO.Soldier, DO.Soldier>(s));
                }
            }
            //else
            //{
            //    (target as meneger).soldiers = null;
            //}

            (target as BO.meneger).soldiers = BOsoldiers;
            return (target as BO.meneger);
        }

        private static DO.meneger complateSoldierToDO<T, S>(T target, S original)
        {
            List<DO.Soldier> DOSoldier = new List<DO.Soldier>();

            List<BO.Soldier> BOReport = (original as BO.meneger).soldiers;
            if (BOReport.Count > 0)
            {
                foreach (var d in BOReport)
                {
                    DOSoldier.Add(ConvertTypes<DO.Soldier, BO.Soldier>(d));
                }
            }
            else
            {
                (target as meneger).soldiers = null;
            }

            (target as DO.meneger).soldiers = DOSoldier;
            return (target as DO.meneger);
        }

        private static DO.report complateReport<T, S>(T target, S original)
        {
            List<DO.DetalsOfReport> DOreport = new List<DO.DetalsOfReport>();

            List<BO.DetalsOfReport> BOReport = (original as BO.report).Reports; 
            foreach (var d in BOReport)
            {
                DOreport.Add(ConvertTypes<DO.DetalsOfReport, BO.DetalsOfReport>(d));
            }

            (target as DO.report).Reports = DOreport;
            return (target as DO.report);
        }
    }
}

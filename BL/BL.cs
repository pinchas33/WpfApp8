﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using BlApi;
using DalApi;
using System.Net.Mail;

namespace BL
{
    class BL : IBl
    {
        static readonly IDal dalObject = DalFactory.GetDal();

        public Soldier GetSoldier(string id)
        {
            try
            {
                return Converts.ConvertTypes<BO.Soldier, DO.Soldier>(dalObject.GetSoldier(id));
            }
             catch (ArgumentNullException ex)
            {
                throw ex;
            }
        }
        public void addSoldier(Soldier soldier)
        {
            dalObject.addSoldier(Converts.ConvertTypes<DO.Soldier, BO.Soldier>(soldier));
        }

        public void updateSoldier(Soldier updateSoldier)
        {
            dalObject.updateSoldier(Converts.ConvertTypes<DO.Soldier, BO.Soldier>(updateSoldier));
        }

        public void DeleteSoldier(string id)
        {
            dalObject.DeleteSoldier(id);
        }

        public meneger GetMeneger()
        {
            try
            {
                return Converts.ConvertTypes<BO.meneger, DO.meneger>(dalObject.GetMeneger());
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
        }

        public void updateMeneger(meneger meneger)
        {
            try
            {
                dalObject.updateMeneger(Converts.ConvertTypes<DO.meneger, BO.meneger>(meneger));
            }
            catch 
            {
                throw new ArgumentNullException();
            }
        }


        public IEnumerable<IGrouping<string, Soldier>> GroupsoldierBycriteria()
        {
            List<BO.Soldier> soldiers = Converts.ConvertTypes<BO.meneger, DO.meneger>(dalObject.GetMeneger()).soldiers;

            return (from s in soldiers
                    group s by s.firstName);
            
        }

        public report GetReport(string id)
        {
            try
            {
                return Converts.ConvertTypes<BO.report, DO.report>(dalObject.GetReport(id));
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
        }

        public void addReport(report report)
        {
            dalObject.addReport(Converts.ConvertTypes<DO.report, BO.report>(report));
        }

        public void SendMail()
        {
            MailMessage mail = new MailMessage();

            mail.To.Add(GetMeneger().Email);
            mail.From = new MailAddress ("z4480g@Gmail.com");
            mail.Subject = "הצעת חופשה";
            mail.Body = "יש לי הצעת חופשה בשבילך!";
            mail.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Timeout = 20000;
            smtp.Credentials = new System.Net.NetworkCredential(GetMeneger().Email.ToString(), GetMeneger().password);
            smtp.EnableSsl = true;
            smtp.SendMailAsync(mail);
        }

    }
}

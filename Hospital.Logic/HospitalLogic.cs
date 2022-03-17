using Hospital.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Logic
{
    /*
    1- The HospitalLogic class using to be the main class that manage all the methods.
    2- Using singelton Desine Patteren to refernce all opjects of HospitalLogic to one opject.
    3- Using proxy Desine Patteren to divide the methods to interfaces, on the basis that
    every employee take his part of methods.
    4- Using Repository Patteren to open one connection to database.
     */
    public class HospitalLogic
    {
        #region Singelton defnetion
        private static HospitalLogic hospitalLogic;
        private static readonly object lockObject = new object();

        public static HospitalLogic GetHospitalLogic()
        {
            if (hospitalLogic == null)
            {
                lock (lockObject)
                {
                    hospitalLogic = new HospitalLogic();
                }
            }
            return hospitalLogic;
        }
        #endregion

        PatientLogic patientLogic = new PatientLogic();

        AccountLogic accountLogic = new AccountLogic();

        SecretaryLogic secretaryLogic = new SecretaryLogic();

        NurseLogic nurseLogic = new NurseLogic();

        DoctorLogic doctorLogic = new DoctorLogic();


    }
}

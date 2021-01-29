﻿using System;
using System.Collections.Generic;
using System.Text;

//============================================================
// Student Number : S10205100, S10203193
// Student Name : Seo Shin Youn, Phua Cheng Ann
// Module Group : T09 
//============================================================
namespace Prg_Assg_CASY
{
    class Visitor:Person
    {
        private string passportNo;
        private string nationality;

        public string PassportNo
        {
            get { return passportNo; }
            set { passportNo = value; }
        }
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        public Visitor(string aName, string aPassportNo, string aNationality):base(aName)
        {
            PassportNo = aPassportNo;
            Nationality = aNationality;
        }

        public override double CalculateSHNCharges()
        {
            double charge = 0;
            foreach (TravelEntry TE in TravelEntryList)
            {
                if (TE.LastCountyOfEmbarkation == "Vietnam" || TE.LastCountyOfEmbarkation == "New Zealand" || TE.LastCountyOfEmbarkation == "MACAO SAR")
                {
                    charge = 200 + 80;
                }
                else
                {
                    charge = 200 + 2000 + TE.ShnStay.CalculateTravelCost(TE.EntryMode, TE.EntryDate);
                }
            }
            return charge *= 1.07;
        }

        public override string ToString()
        {
            return base.ToString() + "\tPassport Number: " + PassportNo + "\tNationality: " + Nationality;
        }
    }
}

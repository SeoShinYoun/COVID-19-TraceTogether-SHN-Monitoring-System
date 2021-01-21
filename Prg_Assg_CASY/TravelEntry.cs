﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Prg_Assg_CASY
{
    class TravelEntry
    {
        //Fields
        private string lastCountryOfEmbarkation;
        private string entryMode;
        private DateTime entryDate;
        private DateTime shnEndDate;
        private SHNFacility shnStay;
        private bool isPaid;

        //Properties
        public string LastCountyOfEmbarkation
        {
            get { return lastCountryOfEmbarkation; }
            set { lastCountryOfEmbarkation = value; }
        }
        public string EntryMode
        {
            get { return entryMode; }
            set { entryMode = value; }
        }
        public DateTime EntryDate
        {
            get { return entryDate; }
            set { entryDate = value; }
        }
        public DateTime ShnEndDate
        {
            get { return shnEndDate; }
            set { shnEndDate = value; }
        }
        public SHNFacility ShnStay 
        {
            get { return shnStay; }
            set { shnStay = value; }
        }
        public bool IsPaid
        {
            get { return isPaid; }
            set { isPaid = value; }
        }
        //Constructors
        public TravelEntry() { }

        public TravelEntry(string aLastCountryOfEmbarkation, string aEntryMode, DateTime aEntryDate)
        {
            LastCountyOfEmbarkation = aLastCountryOfEmbarkation;
            EntryMode = aEntryMode;
            EntryDate = aEntryDate;
        }
        
        public void AssignSHNFacility(SHNFacility facility)
        {

        }

        public void CalculateSHNDuration()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
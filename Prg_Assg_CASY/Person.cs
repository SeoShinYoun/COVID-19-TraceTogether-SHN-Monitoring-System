﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Prg_Assg_CASY
{
    class Person
    {
        private string name;
        private List<SafeEntry> safeEntryList;
        private List<TravelEntry> travelEntryList;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person() { }

        public Person(string n)
        {
            name = n;
        }

        public void AddTravelEntry(TravelEntry TE)
        {
            travelEntryList.Add(TE);
        }

        public void AddSafeEntry(SafeEntry SE)
        {
            safeEntryList.Add(SE);
        }

        /*public double CalculateSHNCharges()
        {

        }*/

        public override string ToString()
        {
            return base.ToString() + "\nName of person: " + Name; 
        }


    }


}

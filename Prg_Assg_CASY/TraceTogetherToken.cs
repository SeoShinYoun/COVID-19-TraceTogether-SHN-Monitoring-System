﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Prg_Assg_CASY
{
    class TraceTogetherToken
    {
        private string serialNo;
        private string collectionLocation;
        private DateTime expiryDate;

        public string SerialNo
        {
            get { return serialNo; }
            set { serialNo = value; }
        }

        public string CollectionLocation
        {
            get { return collectionLocation; }
            set { collectionLocation = value; }
        }

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        public TraceTogetherToken() { }

        public TraceTogetherToken(string sn, string cl, DateTime ed)
        {
            SerialNo = sn;
            CollectionLocation = cl;
            ExpiryDate = ed;
        }

        public bool IsEligibleForReplacement()
        {
            DateTime currentDate = DateTime.Now;
            DateTime diffOfOneMonth = ExpiryDate.AddMonths(-1); /* subtracting one month from the expiration date, where 'diffofonemore' would be store the value*/

            if (currentDate < diffOfOneMonth) /* If The current date is 'less than' which is not one month from the expiration date, the user would not be eligible for a trace together token replacement*/
            {
                Console.WriteLine("You are not eligible for a replacement of your Trace Together Token!");
                return false;
            }
            else /* Else if the current date is one month from the expiration date, the user would hence be available for the replacement of the Trace Together Token*/
            {
                Console.WriteLine("You are eligble for a replacement of your Trace Together Token!");
                return true;
            }
            
        }

        public ReplaceToken(string sn, string cl)
        {

        }
  




    }
}

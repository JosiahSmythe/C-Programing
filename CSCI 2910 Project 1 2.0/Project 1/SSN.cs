//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Project: Project 1
// Description: Object Orented Programing 
// Course: Server Side Web Programing
// Author: Smythe, Josiah, smythejg@etsu.edu, Department of Computing, East Tennessee State University
// Created: Wednesday, Femuary 16, 2019
// Copyright: Josiah Smythe, 2019
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Text;

namespace Project_1
{   /// <summary>
    /// makes a Socil security number that is out side the bonds of real SSN
    /// </summary>
    public class SSN
    {   
        /// <summary>
        /// string for holding the SSN
        /// </summary>
        public string socialSecuritNumber { get; set; }
        /// <summary>
        /// generates a socail securiy number when called and sets it to the string socialSecuritNumber 
        /// </summary>
        public void GenerateSSN()
        {
            
            Random rand = new Random();
            StringBuilder tempSSN = new StringBuilder();
            
            tempSSN.Append(0);
            tempSSN.Append(rand.Next(3, 9));
            tempSSN.Append(rand.Next(4, 9));
            
            
            // I created a system to generate valid SSN for each person based on their address. 
            // I dicovered that that was no allowed for this project, but i left it in to show work
            
//            
//            
//            if (StateAbreveation.Equals("AL"))
//            {
//                tempSSN.Append(4);
//                tempSSN.Append(rand.Next(16, 25));
//                
//            }
//            else if (StateAbreveation.Equals("AK"))
//            {
//                tempSSN.Append(574);
//            }
//            else if (StateAbreveation.Equals("AZ"))
//            {
//                tempSSN.Append(60);
//                tempSSN.Append(rand.Next(0, 2));
//            }
//            else if (StateAbreveation.Equals("AR"))
//            {
//                tempSSN.Append(4);
//                tempSSN.Append(rand.Next(29,33));
//            }
//            else if (StateAbreveation.Equals("CA"))
//            {
//                tempSSN.Append(6);
//                tempSSN.Append(rand.Next(0, 3));
//                tempSSN.Append(rand.Next(2, 7));
//            }
//            else if (StateAbreveation.Equals("CO"))
//            {
//                tempSSN.Append(52);
//                tempSSN.Append(rand.Next(1, 5));
//            }
//            else if (StateAbreveation.Equals("CT"))
//            {
//                tempSSN.Append(0);
//                tempSSN.Append(rand.Next(40, 50));
//            }
//            else if (StateAbreveation.Equals("DE"))
//            {
//                tempSSN.Append(22);
//                tempSSN.Append(rand.Next(1, 3));
//            }
//            else if (StateAbreveation.Equals("FL"))
//            {
//                tempSSN.Append(26);
//                tempSSN.Append(rand.Next(1, 8));
//            }
//            else if (StateAbreveation.Equals("GA"))
//            {
//                tempSSN.Append(2);
//                tempSSN.Append(rand.Next(52, 61));
//            }
//            else if (StateAbreveation.Equals("HI"))
//            {
//                tempSSN.Append(57);
//                tempSSN.Append(rand.Next(5, 7));
//            }
//            else if (StateAbreveation.Equals("ID"))
//            {
//                tempSSN.Append(51);
//                tempSSN.Append(rand.Next(8, 10));
//            }
//            else if (StateAbreveation.Equals("IL"))
//            {
//                tempSSN.Append(3);
//                tempSSN.Append(rand.Next(18, 62));
//            }
//            else if (StateAbreveation.Equals("IN"))
//            {
//                tempSSN.Append(3);
//                tempSSN.Append(rand.Next(0, 2));
//                tempSSN.Append(rand.Next(3,8));
//            }
//            else if (StateAbreveation.Equals("IA"))
//            {
//                tempSSN.Append(rand.Next(478,486));
//            }
//            else if (StateAbreveation.Equals("KS"))
//            {
//                tempSSN.Append(rand.Next(509,516));
//            }
//            else if (StateAbreveation.Equals("KY"))
//            {
//                tempSSN.Append(rand.Next(400, 408));
//            }
//            else if (StateAbreveation.Equals("LA"))
//            {
//                tempSSN.Append(rand.Next(433,440));
//                
//            }
//            else if (StateAbreveation.Equals("ME"))
//            {
//                tempSSN.Append(0);
//                tempSSN.Append(0);
//                tempSSN.Append(rand.Next(4, 8));
//            }
//            else if (StateAbreveation.Equals("MD"))
//            {
//                tempSSN.Append(rand.Next(212, 221));
//            }
//            else if (StateAbreveation.Equals("MA"))
//            {
//                tempSSN.Append(0);
//                tempSSN.Append(rand.Next(10, 35));
//            }
//            else if (StateAbreveation.Equals("MI"))
//            {
//                tempSSN.Append(rand.Next(362,387));
//            }
//            else if (StateAbreveation.Equals("MN"))
//            {
//                tempSSN.Append(rand.Next(468, 478));
//            }
//            else if (StateAbreveation.Equals("MS"))
//            {
//                tempSSN.Append(rand.Next(425,429));
//            }
//            else if (StateAbreveation.Equals("MO"))
//            {
//                tempSSN.Append(rand.Next(486,501));
//            }
//            else if (StateAbreveation.Equals("MT"))
//            {
//                tempSSN.Append(rand.Next(516,518));
//            }
//            else if (StateAbreveation.Equals("NE"))
//            {
//                tempSSN.Append(rand.Next(505,509));
//            }
//            else if (StateAbreveation.Equals("NV"))
//            {
//                tempSSN.Append(530);
//            }
//            else if (StateAbreveation.Equals("NH"))
//            {
//                tempSSN.Append(0);
//                tempSSN.Append(0);
//                tempSSN.Append(rand.Next(1,4));
//            }
//            else if (StateAbreveation.Equals("NJ"))
//            {
//                tempSSN.Append(rand.Next(135,159));
//            }
//            else if (StateAbreveation.Equals("NM"))
//            {
//                tempSSN.Append(585);
//            }
//            else if (StateAbreveation.Equals("NY"))
//            {
//                tempSSN.Append(rand.Next(0,2));
//                if (tempSSN[0].ToString().Equals("0"))
//                {
//                    tempSSN.Append(rand.Next(50,100));
//                }
//                else
//                {
//                    tempSSN.Append(rand.Next(0,4));
//                    tempSSN.Append(rand.Next(0,5));                    
//                }
//
//                
//            }
//            else if (StateAbreveation.Equals("NC"))
//            {
//                tempSSN.Append(rand.Next(237,247));
//            }
//            else if (StateAbreveation.Equals("ND"))
//            {
//                tempSSN.Append(rand.Next(501,503));
//            }
//            else if (StateAbreveation.Equals("OH"))
//            {
//                tempSSN.Append(rand.Next(268,303));
//            }
//            else if (StateAbreveation.Equals("OK"))
//            {
//                tempSSN.Append(rand.Next(440,449));
//            }
//            else if (StateAbreveation.Equals("OR"))
//            {
//                tempSSN.Append(rand.Next(540,545));
//            }
//            else if (StateAbreveation.Equals("PA"))
//            {
//                tempSSN.Append(rand.Next(159,212));
//            }
//            else if (StateAbreveation.Equals("RI"))
//            {
//                tempSSN.Append(0);
//                tempSSN.Append(rand.Next(35,40));
//            }
//            else if (StateAbreveation.Equals("SC"))
//            {
//                tempSSN.Append(rand.Next(247,252));
//            }
//            else if (StateAbreveation.Equals("SD"))
//            {
//                tempSSN.Append(rand.Next(503,505));
//            }
//            else if (StateAbreveation.Equals("TX"))
//            {
//                tempSSN.Append(rand.Next(449,468));
//            }
//            else if (StateAbreveation.Equals("TN"))
//            {
//                tempSSN.Append(rand.Next(408,416));
//            }
//            else if (StateAbreveation.Equals("UT"))
//            {
//                tempSSN.Append(rand.Next(646,648));
//            }
//            else if (StateAbreveation.Equals("VT"))
//            {
//                tempSSN.Append(0);
//                tempSSN.Append(0);
//                tempSSN.Append(rand.Next(8,10));
//            }
//            else if (StateAbreveation.Equals("VA"))
//            {
//                tempSSN.Append(rand.Next(223,232));
//            }
//            else if (StateAbreveation.Equals("WA"))
//            {
//                tempSSN.Append(rand.Next(531,540));
//            }
//            else if (StateAbreveation.Equals("WV"))
//            {
//                tempSSN.Append(rand.Next(232,237));
//            }
//            else if (StateAbreveation.Equals("WI"))
//            {
//                tempSSN.Append(rand.Next(387,400));
//            }
//            else if (StateAbreveation.Equals("WY"))
//            {
//                tempSSN.Append(520);
//            }
//            else
//            {
//                Console.Out.WriteLine("[ False State Abreveation ]");
//            }

            tempSSN.Append("-");
            tempSSN.Append(rand.Next(0, 9));
            tempSSN.Append(rand.Next(0, 9));
            tempSSN.Append("-");
            tempSSN.Append(rand.Next(0, 9));
            tempSSN.Append(rand.Next(0, 9));
            tempSSN.Append(rand.Next(0, 9));
            tempSSN.Append(rand.Next(0, 9));
            


            socialSecuritNumber = tempSSN.ToString();
        }
        
        /// <summary>
        /// returns the socialSecuritNumber as a string
        /// <returns>string</returns>
        public string ToString()
        {
            return socialSecuritNumber;
        }
    }
}
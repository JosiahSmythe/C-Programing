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
{    
    /// <summary>
    /// phone number creates a valid phone number and also offers the option to delimit it
    /// </summary>
    public class PhoneNumber
    {    
        /// <summary>
        /// stringbuilder for the phonenumber allowing it to be created and delimited
        /// </summary>
        private StringBuilder phoneNumber = new StringBuilder();
        
        /// <summary>
        /// main method for the phonenumber class that generates the phonenumber
        /// </summary>
        public PhoneNumber()
        {
            GeneratePhoneNumber();
        }
        /// <summary>
        /// generates a phone number that keeps the second that third numbers from matching
        /// </summary>
        public void GeneratePhoneNumber()
        {
            StringBuilder tempString = new StringBuilder();
            Random rand = new Random();
            
            phoneNumber.Append(rand.Next(2,9));
            int secondNumber = rand.Next(0,9);
            
            phoneNumber.Append(secondNumber);
            int thirdNumber = rand.Next(0, 9);
            
            // loop and create a new number for the third digit until it doesn't equal the second number
            while (secondNumber.Equals(thirdNumber))
            {
                thirdNumber = rand.Next(0, 9);
            }

            for (int i = 0; i < 8; i++)
            {
                phoneNumber.Append(rand.Next(0, 9));
            }

        }

        /// <summary>
        /// Returns the generated phone number delimited by the char passed in. Format example [123-456-7890]
        /// </summary>
        /// <param name="character of any type"></param>
        /// <param name="delimiter"></param>
        /// <returns>string</returns>
        public string PhoneNumberDelimited(char delimiter)
        {
            phoneNumber.Insert(3, delimiter);             
            phoneNumber.Insert(7, delimiter);
            return phoneNumber.ToString();
        }
        /// <summary>
        /// returns the vlaues phone numebr delimited by the genaric delimiter '-'
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Phone Number : " + PhoneNumberDelimited('-');
        }
    }
}
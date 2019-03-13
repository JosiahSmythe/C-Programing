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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Project_1
{
    /// <summary>
    /// creates genaric information for a online information
    /// </summary>
    public class Internet
    {
        /// <summary>
        /// string for the email set later
        /// </summary>
        private string email { get; set; }
        /// <summary>
        /// stirng variable to store the password generated later
        /// </summary>
        private string password { get; set; }
        /// <summary>
        /// string holding the TLD generated later
        /// </summary>
        private string topLevelDomain { get; set; }
        /// <summary>
        /// string for the domain name generated later
        /// </summary>
        private string domainName { get; set; }
        /// <summary>
        /// stirng for the url generated from the TLD and the DN
        /// </summary>
        private string url { get; set; }
        /// <summary>
        /// string for the iPv4Address that will be generated later
        /// </summary>
        private string iPV4Address { get; set; }
        /// <summary>
        /// string for the mac address generated later
        /// </summary>
        private string macAddress { get; set; }
        /// <summary>
        /// string for the phonenumber gathered from the phonmunber class
        /// </summary>
        private string phoneNumber { get; set; }
        /// <summary>
        /// credidCard generated from CreditCard class
        /// </summary>
        private CreditCard creditCard { get; set; }
        /// <summary>
        /// calls all the methods that create the TLD, DN, the url, generate ipv4address, and mac addres
        /// also creates a phonenumber and creditcard
        /// </summary>
        public Internet()
        {
            GenerateTopLevelDomain();            
            GenerateDomainName();
            GenerateURL();
            GenerateIPV4Address();
            GenerateMacAddress();

            PhoneNumber tempNumber = new PhoneNumber();
            phoneNumber = tempNumber.PhoneNumberDelimited('-');

            CreditCard tempCard = new CreditCard();
            creditCard = tempCard;
        }
        
        /// <summary>
        /// generates an email based on the first and last names passed in
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public string GenerateEmail(string firstName, string lastName)
        {
           StringBuilder tempEmail = new StringBuilder();
           tempEmail.Append(lastName.ToLower());
           tempEmail.Append(firstName.Remove(1).ToUpper());
           tempEmail.Append("@exampleemail");
           tempEmail.Append(topLevelDomain);
           
           email = tempEmail.ToString();
           return email;
           
        }
        
        /// <summary>
        /// generates a password by adding and converting the first and last names passed in
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void GeneratePassword(string firstName, string lastName)
        {
            StringBuilder passwordBuilder = new StringBuilder();
            Random rand = new Random();
            char[] symbols = new[] {'#', '@', '$', '%', '&'};
            
            passwordBuilder.Append(firstName.ToUpper()[rand.Next(firstName.Length)]);            
            passwordBuilder.Append(lastName.ToLower()[rand.Next(lastName.Length)]);
            passwordBuilder.Append(symbols[rand.Next(symbols.Length)]);
            passwordBuilder.Append(firstName.ToUpper()[rand.Next(firstName.Length)]);
            passwordBuilder.Append(lastName.ToLower()[rand.Next(lastName.Length)]); 
            for (int i = 0; i < 4; i++)
            {
                passwordBuilder.Append(rand.Next(0, 9));
            }
            passwordBuilder.Append(symbols[rand.Next(symbols.Length)]);
            password = passwordBuilder.ToString();
           
        }
        
        /// <summary>
        /// generates a top level domain useining the enum TLDNames for refrence
        /// </summary>
        public void GenerateTopLevelDomain()
        {
            StringBuilder tempTLD = new StringBuilder();
            Random rand = new Random();
            
            Array tLdNames = Enum.GetNames(typeof(TLDNames));
            tempTLD.Append(".");
            tempTLD.Append(tLdNames.GetValue(rand.Next(tLdNames.Length)));

            topLevelDomain = tempTLD.ToString();
            
        }

        /// <summary>
        /// generates a domain name and utilizes the enum DomainNames for refrence
        /// </summary>
        public void GenerateDomainName()
        {
            Random rand = new Random();
            Array domainNames = Enum.GetNames(typeof(DomainNames));            
            domainName = (domainNames.GetValue(rand.Next(domainNames.Length))).ToString();
        }

        /// <summary>
        /// generates a url with the TLD and domain name
        /// </summary>
        public void GenerateURL()
        {
            StringBuilder tempURL = new StringBuilder();
            tempURL.Append("https://www.");
            tempURL.Append(domainName);
            tempURL.Append(topLevelDomain);

            url = tempURL.ToString();
        }
        
        /// <summary>
        /// generates an ipV4address acording to the stardereds there of
        /// </summary>
        public void GenerateIPV4Address()
        {
            Random rand = new Random();
            List<int> iPAddressStartersList = new List<int>();
            StringBuilder tempiPAddress = new StringBuilder();
            
            iPAddressStartersList.Add(10);
            iPAddressStartersList.Add(100);
            iPAddressStartersList.Add(172);
            iPAddressStartersList.Add(192);
            iPAddressStartersList.Add(198);
            var iPAddresStart = iPAddressStartersList[rand.Next(iPAddressStartersList.Count)];

            if (iPAddresStart.Equals(10))
            {
                tempiPAddress.Append(iPAddresStart);
                for (int i = 0; i < 3; i++)
                {
                    tempiPAddress.Append(".");
                    for (int j = 0; j < 1; j++)
                    {
                        tempiPAddress.Append(rand.Next(0, 256));
                    }
                    
                }                
            }
            else if (iPAddresStart.Equals(100))
            {
                tempiPAddress.Append(iPAddresStart);
                tempiPAddress.Append(".");
                tempiPAddress.Append(rand.Next(64, 128));
                for (int i = 0; i < 2; i++)
                {
                    tempiPAddress.Append(".");
                    for (int j = 0; j < 1; j++)
                    {
                        tempiPAddress.Append(rand.Next(0, 256));
                    }
                    
                }                
            }
            else if (iPAddresStart.Equals(172))
            {
                
                tempiPAddress.Append(iPAddresStart);
                tempiPAddress.Append(".");
                tempiPAddress.Append(rand.Next(16, 31));
                for (int i = 0; i < 2; i++)
                {
                    tempiPAddress.Append(".");
                    for (int j = 0; j < 1; j++)
                    {
                        tempiPAddress.Append(rand.Next(0, 256));
                    }
                    
                }                
            }
            else if (iPAddresStart.Equals(192))
            {
                tempiPAddress.Append(iPAddresStart);

                int[] beginingNumber = new[] {0, 168};
                string startingNumber = "168";//beginingNumber[rand.Next(beginingNumber.Length)].ToString();
                
                if (startingNumber.Equals("0"))
                {
                    for (int i = 0; i < 2; i++)
                    {
                        tempiPAddress.Append(".");
                        tempiPAddress.Append("0");
                    }
                    for (int i = 0; i < 1; i++)
                    {
                        tempiPAddress.Append(".");
                        tempiPAddress.Append(rand.Next(0, 256));         
                    }
                }
                else if (startingNumber.Equals("168"))
                {
                    tempiPAddress.Append(".");
                    tempiPAddress.Append("168");
                    for (int i = 0; i < 2; i++)
                    {
                        tempiPAddress.Append(".");
                        tempiPAddress.Append(rand.Next(0, 256));         
                    }
                }
                
                
                
                
                                
            }
            else if (iPAddresStart.Equals(198))
            {
                
                tempiPAddress.Append(iPAddresStart);
                tempiPAddress.Append(".");
                tempiPAddress.Append(rand.Next(18, 20));
                for (int i = 0; i < 2; i++)
                {
                    tempiPAddress.Append(".");
                    tempiPAddress.Append(rand.Next(0, 256));
                    
                }                
            }
            else
            {
                Console.Out.WriteLine("False start to the address"); 
            }

            iPV4Address = tempiPAddress.ToString();
        }

        /// <summary>
        /// generates a mac address by converting an array of bytes to hex and delimeting
        /// </summary>
        public void GenerateMacAddress()
        {
            Random rand = new Random();
            byte[] byteArrayMacAddress = new byte[6];
            rand.NextBytes(byteArrayMacAddress);
            string tempMacAddress = string.Concat(byteArrayMacAddress.Select(bypeAt => $"{bypeAt:X2}:").ToArray());
            
            macAddress = tempMacAddress.Trim(':');

        }
        
        /// <summary>
        /// updates the users email by complicating the preveous email using the first name
        /// </summary>
        /// <param name="badEmail"></param>
        /// <param name="firstName"></param>
        public void UpdateEmail(string badEmail, string firstName)
        {
            StringBuilder tempEmail = new StringBuilder();
            StringBuilder tempNumbers = new StringBuilder();
            tempEmail.Append(badEmail);

            string shortName = firstName.Remove(2, firstName.Length - 2);
            var charName = shortName.ToCharArray();
            
            foreach (var letter in charName)
            {
                int hexLetters = Convert.ToInt32(letter);
                tempNumbers.Append(hexLetters);
            }
            for (int i = 0; i < tempEmail.Length; i++)
            {
                if (tempEmail[i].Equals('@'))
                {
                    tempEmail.Insert(i, tempNumbers);
                    break;
                }
            }
            email = tempEmail.ToString();
        }
        /// <summary>
        /// returns the values of the internet class as an string
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return "\n    ======= Internet ========" + "\n Email            : " + email + "\n Password         : " + password + "\n URL              : " + url + "\n iPV4Address      : " + iPV4Address + "\n Mac Address      : " + macAddress + "\n Phone Number     : " + phoneNumber + "\n     ===== Credit Card =====" +creditCard;
        }
    }
}
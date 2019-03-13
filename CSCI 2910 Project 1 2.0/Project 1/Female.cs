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
using System.Drawing;

namespace Project_1
{
    /// <summary>
    /// Female class that extends from the Person class
    /// </summary>
    public class Female : Person
    {    
        /// <summary>
        /// Female Title is the prefx to be added to the persons full name
        /// </summary>
        private FemaleTitle title { get; set; }
        /// <summary>
        /// It is the Female classes first name veraible that will be set later
        /// </summary>
        private FemaleFirstName firstName { get; set; }
        /// <summary>
        /// It is the Female classes first name veraible that will be set later
        /// </summary>
        private LastName femaleLastname { get; set; }
        /// <summary>
        /// string that stores an email created throught the Internet class
        /// </summary>
        private string femaleEmail { get; set; }
        /// <summary>
        /// Internet object for the female class
        /// </summary>
        private Internet femaleInternet { get; set; }
        /// <summary>
        /// creates a ColorGenerator variable for storing a randome color object
        /// </summary>
        private ColorGenerator femaleFavoriteColor;

        /// <summary>
        /// Defult constructor for the Female Class. Set the Birthdate, the FirstName, Title, LastName, femaleInternet, the address, SSN and a company
        /// </summary>
        public Female()
        {
    
            Random number = new Random();
            
            Birthdate = DateTime.Now.AddDays(-new Random().Next((30 * 365), (60 * 365)));
               
            Array FemaleNames = Enum.GetValues(typeof(FemaleFirstName));
            firstName = (FemaleFirstName)FemaleNames.GetValue(number.Next(FemaleNames.Length));

            Array TitleNames = Enum.GetValues(typeof(FemaleTitle));
            title = (FemaleTitle)TitleNames.GetValue(number.Next(TitleNames.Length));

            Array FemaleLastNames = Enum.GetValues(typeof(LastName));
            femaleLastname = (LastName) FemaleLastNames.GetValue(number.Next(FemaleLastNames.Length));

            Console.Out.WriteLine(femaleLastname);

            Internet tempFemaleInternet = new Internet();
            femaleEmail = tempFemaleInternet.GenerateEmail(firstName.ToString(), femaleLastname.ToString());
            tempFemaleInternet.GeneratePassword(firstName.ToString(), lastName.ToString());
            femaleInternet = tempFemaleInternet;
            
            ColorGenerator mine = new ColorGenerator();
            femaleFavoriteColor = mine;
            
            address = new Address();
            
            var tempSocal = new SSN();
            tempSocal.GenerateSSN();
            SocialSecurityNumber = tempSocal;
            
            company = new Company();
        }
        
        /// <summary>
        /// Gets the random age defined by the birthdate
        /// </summary>
        /// <returns>Returns an int for the age</returns>
        public override int GetAge()
        {
            var Today = DateTime.Now;
            var Age = Today.Year - Birthdate.Year;
            if (Birthdate > Today.AddYears(-Age)) Age--;
            return Age;
            
        }
        /// <summary>
        /// Returns the Female class values: FirstName, LastName, Title, Age, Birthdate
        /// </summary>
        /// <returns>Title, FirstName, LastName, Age, Birthdate</returns>
        public override string ToString()
        {
            return "\n [ ====== Female Person ====== ]" + "\n First Name     : " + title + ". " + firstName 
                   + "\n Last Name      : " + femaleLastname + "\n SSN            : " + SocialSecurityNumber.ToString() 
                   +  "\n Email          : " + femaleEmail + "\n Age Today      : " + GetAge() + "\n BirthDate      : " 
                   + Birthdate.ToShortDateString() + femaleInternet.ToString() + femaleFavoriteColor.ToString() + address.ToString() + company;
        }
    }
}
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
    /// Male class that extends from the Person class
    /// </summary>
    public class Male : Person
    {    
        /// <summary>
        /// Male Title is the prefx to be added to the persons fullname
        /// </summary>
        private MaleTitle title { get; set; }
        /// <summary>
        /// It is the Male classes first name veraible that will be set later
        /// </summary>
        private MaleFirstName firstName { get; set; }
        /// <summary>
        /// It is the Male classes first name veraible that will be set later
        /// </summary>
        private LastName maleLastName { get; set; }
        
        /// <summary>
        /// string that stores an email created throught the Internet class
        /// </summary>
        private string maleEmail { get; set; }
        /// <summary>
        /// Internet object for the male class
        /// </summary>
        private Internet maleInternet { get; set; }
        
        /// <summary>
        /// creates a ColorGenerator variable for storing a randome color object
        /// </summary>
        private ColorGenerator maleFavoriteColor;
        
        /// <summary>
        /// Defult constructor for the Male Class. Set the Birthdate, the FirstName, Title, LastName, maleInternet, the address, SSN and a company
        /// </summary>
        public Male()
        {
            Random number = new Random();
            
            Birthdate = DateTime.Now.AddDays(-new Random().Next((30 * 365), (60 * 365)));
            
            Array MaleNames = Enum.GetValues(typeof(MaleFirstName));
            firstName = (MaleFirstName)MaleNames.GetValue(number.Next(MaleNames.Length));
            
            Array TitleNames = Enum.GetValues(typeof(MaleTitle));
            title = (MaleTitle)TitleNames.GetValue(number.Next(TitleNames.Length));

            Array MaleLastNames = Enum.GetValues(typeof(LastName));
            maleLastName = (LastName) MaleLastNames.GetValue(number.Next(MaleLastNames.Length));
            
            
            Internet tempMaleInternet = new Internet();
            maleEmail = tempMaleInternet.GenerateEmail(firstName.ToString(), maleLastName.ToString());
            tempMaleInternet.GeneratePassword(firstName.ToString(), maleLastName.ToString());

            maleInternet = tempMaleInternet;

            ColorGenerator tempMaleColor = new ColorGenerator();
            maleFavoriteColor = tempMaleColor;
            
            address = new Address();
            
            var tempSocial = new SSN();
            tempSocial.GenerateSSN();
            SocialSecurityNumber = tempSocial;
            
            company = new Company();
        }
        
        
        
        /// <summary>
        /// Gets the random age defined by the birthdate
        /// </summary>
        /// <returns>Returns an int for the age</returns>
        public override int GetAge()
        {
            DateTime Today = DateTime.Now;
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
            return "\n  [ ====== Male Person ====== ]" + "\n First Name     : " + title + ". " + firstName + "\n Last Name      : " 
                   + maleLastName + "\n SSN            : "    + SocialSecurityNumber.ToString()  +  "\n Email          : " + maleEmail +  "\n Age Today      : " 
                   + GetAge() +"\n BirthDate      : " + Birthdate.ToShortDateString() + maleInternet.ToString() 
                   + maleFavoriteColor.ToString() + address.ToString() + company;
        }
    }
}
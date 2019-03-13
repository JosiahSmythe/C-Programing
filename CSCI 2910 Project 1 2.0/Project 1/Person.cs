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
using System.Runtime.InteropServices;


namespace Project_1
{
    /// <summary>
    /// Abstract Base Class that the Male and Female classes are derived from
    /// </summary>
    public abstract class Person
    {   /// <summary>
        /// public variable last name for all persons Male or Female
        /// </summary>
        public  LastName lastName { get; set; }
        /// <summary>
        /// public variable last name for all persons Male or Female
        /// </summary>
        public  DateTime Birthdate { get; set; }
        /// <summary>
        /// instacheates a SSN for the derived classes male and female
        /// </summary>
        public SSN SocialSecurityNumber { get; set; }
        
        /// <summary>
        /// instacheates a Address for the derived classes male and female
        /// </summary>
        public Address address { get; set; }
        /// <summary>
        /// instacheates a Company for the derived classes male and female
        /// </summary>
        public Company company { get; set; }
        /// <summary>
        /// creates a variable for the age values in the male and female classes
        /// </summary>
        /// <returns>An random age between 30 and 60 years old as of today</returns>
        public abstract int GetAge();

    }
}
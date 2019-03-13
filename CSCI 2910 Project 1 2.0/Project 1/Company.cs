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

namespace Project_1
{    
    /// <summary>
    /// creates a company with a name, company suffic, and a job title
    /// </summary>
    public class Company
    {    
        /// <summary>
        /// company name stored as a sting that is created later
        /// </summary>
        private string companyName { get; set; }
        
        /// <summary>
        ///  company suffic created later and stored as a string
        /// </summary>
        private string companySuffix { get; set; }
        /// <summary>
        /// company job title sotred as a string
        /// </summary>
        private string jobTitle { get; set; }
        
        /// <summary>
        /// creates a company by utilizing the methods that create the values of its name, suffic and job title
        /// </summary>
        public Company()
        {
            GenerateCompanyName();
            GenerateCompanySuffix();
            GenerateJobTitle();


        }
        /// <summary>
        /// creates a company name from a random selection from the enum class CompanyNames
        /// </summary>
        public void GenerateCompanyName()
        {
            Random rand = new Random();
            Array companyNames = Enum.GetValues(typeof(CompanyNames));
            companyName = companyNames.GetValue(rand.Next(companyNames.Length)).ToString();
        }
        /// <summary>
        /// selects a company suffix at random from the enum commpansuffixes
        /// </summary>
        public void GenerateCompanySuffix()
        {
            Random rand = new Random();
            Array companySuffixes = Enum.GetValues(typeof(CompanySuffixes));
            companySuffix = companySuffixes.GetValue(rand.Next(companySuffixes.Length)).ToString();
        }
        /// <summary>
        /// creates a random job title for the company user from the enum JobTitles
        /// </summary>
        public void GenerateJobTitle()
        {
            Random rand = new Random();
            Array JobTitles = Enum.GetValues(typeof(JobTitles));
            jobTitle = JobTitles.GetValue(rand.Next(JobTitles.Length)).ToString();
        }
        /// <summary>
        /// returns the values of the created company as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "\n   ====== Employment =====" + "\n Company Name   : " + companyName + " " + companySuffix + ".\n Position       : " + jobTitle;
        }
    }
}
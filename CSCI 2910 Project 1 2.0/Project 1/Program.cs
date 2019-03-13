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
using System.ComponentModel.DataAnnotations;
//using Lab1;

namespace Project_1
{
    /// <summary>
    /// this is the main class driver for the Project 1 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// the main method that drives all the classes and creats male and female persons aswell as a text file
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Male myMale = new Male();
            Console.Out.WriteLine(myMale.ToString());
            
            Female myFemale = new Female();
            Console.Out.WriteLine(myFemale.ToString());
                
            Text myFile = new Text();
            //Console.Out.WriteLine(myFile.ToString());
               
        }
    }
}
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
    /// creates a randome color with values for hex, rgb and a color name
    /// </summary>
    public class ColorGenerator
    {    
        /// <summary>
        /// stores the value of the color as a hexidicimal in a string
        /// </summary>
        private string hexColor { get; set; }
        /// <summary>
        /// stores the value of the color as a rgb color in a string
        /// </summary>
        private string rgbColor { get; set; }
        /// <summary>
        /// stores the color name as a string
        /// </summary>
        private Color colorName { get; set; }
        
        /// <summary>
        /// drives this class by creating the values for each the, hexColor, rgbColor, the colorname 
        /// </summary>
        public ColorGenerator()
        {
            CreateRandomColor();
            ConvertToHex(colorName);
            GenerateRGBValue(colorName);
        }
        /// <summary>
        /// creates a random color from the System.Drawing.Color class the enum KnownColor
        /// </summary>
        public void CreateRandomColor()
        {
            Random rand = new Random();
            KnownColor[] colorNames = (KnownColor[]) Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = colorNames[rand.Next(colorNames.Length)];
            colorName = Color.FromKnownColor(randomColorName);
        }
        /// <summary>
        /// converts the color to a hexidecimal color representaiton
        /// </summary>
        /// <param name="color"></param>
        public void ConvertToHex ( Color color )
        {
            hexColor = string.Concat("#", (color.ToArgb() & 0x00FFFFFF).ToString("X6"));
        }
        /// <summary>
        /// converts the color value to a rgbvalue
        /// </summary>
        /// <param name="color"></param>
        public void GenerateRGBValue(Color color)
        {
            rgbColor = (color.R.ToString() + ", "+ color.G.ToString() + ", " + color.B.ToString());
           
        }
        
        /// <summary>
        /// returns the values of the ColorGenerator object as as string
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return  "\n    ==== Favorite Color ====" + "\n Color Name    : " + colorName.Name + "\n Hex Value     : " + hexColor + "\n RGB Number    : " + rgbColor;

        }

    }
}
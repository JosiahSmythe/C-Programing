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
using System.Collections;
using System.Linq;
using System.Text;

namespace Project_1
{    
    /// <summary>
    /// generats all the value needed to formulate a mock credit card
    /// </summary>
    public class CreditCard
    {    
        /// <summary>
        /// string holding the card type name
        /// </summary>
        public string cardType { get; set; }
        /// <summary>
        /// string card number holding the credit card number
        /// </summary>
        public string cardNumber { get; set; }
        /// <summary>
        /// string holding the CVV number for this card
        /// </summary>
        public string cvvNumber { get; set; }
        /// <summary>
        /// string experation date set from the DateTime class
        /// </summary>
        public string experationDate { get; set; }
        
        /// <summary>
        /// main driver for the credit card class, sets and calls the methods to create it
        /// </summary>
        public CreditCard()
        {
            Array cardTypes = Enum.GetNames(typeof(CardTypes));
            Random rand = new Random();
            cardType = cardTypes.GetValue(rand.Next(cardTypes.Length)).ToString();

            Random randNum = new Random();
            StringBuilder cardStringBuilder = new StringBuilder();
            int[] startingCardNumberArray;
            if (cardType.Equals(CardTypes.American_Express.ToString()))
            {
                StringBuilder stringBuilderAmericanExpress = new StringBuilder();
                startingCardNumberArray = new[] {34, 37};
                int beginingNumber = startingCardNumberArray[randNum.Next(startingCardNumberArray.Length)];
                int randomeNumber = randNum.Next(15,16);
                randomeNumber = randomeNumber - (beginingNumber.ToString().Length);  
                for (int i = 0; i < randomeNumber; i++)
                {
                    stringBuilderAmericanExpress.Append(randNum.Next(0,9));
                }
                cardStringBuilder.Append(beginingNumber);
                cardStringBuilder.Append(stringBuilderAmericanExpress);

                cardNumber = cardStringBuilder.ToString();
            }
            else if(cardType.Equals(CardTypes.Discovery.ToString()))
            {              
                StringBuilder test = new StringBuilder();
                startingCardNumberArray = new[] {6011, 64, 65};
                int beginingNumber = startingCardNumberArray[randNum.Next(startingCardNumberArray.Length)];
                int randomeNumber = randNum.Next(16,20);
                randomeNumber = randomeNumber - (beginingNumber.ToString().Length);  
                for (int i = 0; i < randomeNumber; i++)
                {
                    test.Append(randNum.Next(0,9));
                }
                cardStringBuilder.Append(beginingNumber);
                cardStringBuilder.Append(test);

                cardNumber = cardStringBuilder.ToString();
            }
            else if (cardType.Equals(CardTypes.Mastercard.ToString()))
            {
                StringBuilder stringBuilderMastercard = new StringBuilder();
                int firstRandomStart = randNum.Next(51, 56);
                int secondRandomStart = randNum.Next(222100, 272100);
                
                startingCardNumberArray = new[] {firstRandomStart, secondRandomStart};
                int beginningNumber = startingCardNumberArray[randNum.Next(startingCardNumberArray.Length)];
                int stringLength = 16;
                stringLength = stringLength - (beginningNumber.ToString().Length);  
                for (int i = 0; i < stringLength; i++)
                {
                    stringBuilderMastercard.Append(randNum.Next(0,9));
                }
                cardStringBuilder.Append(beginningNumber);
                cardStringBuilder.Append(stringBuilderMastercard);
                cardNumber = cardStringBuilder.ToString();
            }
            else if (cardType.Equals(CardTypes.Visa.ToString()))
            {
                StringBuilder stringBuilderVisa = new StringBuilder();

                int beginningNumber = 4;
                int cardLength = 16;
                cardLength = cardLength - (beginningNumber.ToString().Length);  
                for (int i = 0; i < cardLength; i++)
                {
                    stringBuilderVisa.Append(randNum.Next(0,9));
                }
                cardStringBuilder.Append(beginningNumber);
                cardStringBuilder.Append(stringBuilderVisa);

                cardNumber = cardStringBuilder.ToString();

            }
            else
            {
                Console.Out.WriteLine("Not a valid CardName");
            }
            GenerateCVV();
            GenerateExperationDate();
        }

        
        /// <summary>
        /// generates and sets the experation date by using the DateTime class
        /// </summary>
        public void GenerateExperationDate()
        {
            string tempExperationDate = DateTime.Now.AddDays(new Random().Next(2 * 365,4 * 365)).ToShortDateString();            
            experationDate = tempExperationDate.Remove(2, 3);

        }
        
        /// <summary>
        /// updates the credit card by creating a new CreditCard wen called
        /// </summary>
        public void UpdateCardNumber()
        {
            new CreditCard();
            
        }
        /// <summary>
        /// generates a random CVV number for the credit card  
        /// </summary>
        public void GenerateCVV()
        {
            StringBuilder cVVNumberBuilder = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < rand.Next(3,5); i++)
            {
                cVVNumberBuilder.Append(rand.Next(0,9));
            }
            cvvNumber = cVVNumberBuilder.ToString();
        }

        /// <summary>
        /// returns the values of this class as a stiring
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "\n Credit Card Type : " + cardType + "\n Card Number      : " + cardNumber + "\n Expiration Date  : " +
                   experationDate + "\n CVV Number       : " + cvvNumber;
        }
        
    }
}
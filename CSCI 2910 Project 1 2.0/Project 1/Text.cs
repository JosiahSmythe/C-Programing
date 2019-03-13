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
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Project_1
{
    /// <summary>
    /// This class collects and minipulates the text in the file "FixedSampleText.txt"
    /// </summary>
    public class Text
    {
        /// <summary>
        /// this string will be set to a random sentence from the text file
        /// </summary>
        private string randomSentence { get; set; }
        /// <summary>
        /// this string will be set to a random word from the text file 
        /// </summary>
        private string randomWord { get; set; }
        /// <summary>
        /// this string list will hold all the sentences from the text file
        /// </summary>
        private List<string> sentences { get; set; }
        /// <summary>
        /// this sting list will hold all the words in the text file
        /// </summary>
        private List<string> words { get; set; }
        /// <summary>
        /// a string that is a randome length cut from the text file
        /// </summary>
        private string paragraph { get; set; }
        /// <summary>
        /// a string of random length in the same sequence as they were in the text file
        /// </summary>
        private string wordString { get; set; }
        /// <summary>
        /// string holding the unchanged text from the file
        /// </summary>
        private string allWords { get; set; }
        /// <summary>
        /// counter for the number of sentences gathered
        /// </summary>
        private int sentCounter { get; set; }
        /// <summary>
        /// counter for the number of words gathered
        /// </summary>
        private int wordCounter { get; set; }
        /// <summary>
        /// iniciates all the functions of this method including, reading in the file,
        /// calling the methods that, create the word and sentence lists, create randome words and sentences
        /// and create paragraph and stirngs of random words
        /// </summary>
        public Text()
        {
            Random rand = new Random(); 
            
            allWords = File.ReadAllText("FixedSampleText.txt");
            CreatWordsList(allWords);
            CreateSentenceList(allWords);
            CreateRandomeSentence();
            CreateRandomWord();
            
            CreateParagraph();
            CreateWordString(rand.Next(0,wordCounter));
            
        }
        /// <summary>
        /// Creates a list of all words in the string passed in
        /// </summary>
        /// <param name="textFile"></param>
        public void CreatWordsList(string textFile)
        {
            words = new List<string>();

            string[] delimiters = {"*"," *","* ",",'","--'","('","!\" \""
                +"?'",".\"'",",\"",".\""," \"","\n'","'--","--"
                + " '","!'","?"," '","' ",",","',", ".'"," ","_"
                +"/",";", ":","(", ")",".","!","\r","\n" };

            var tempWordList = textFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in tempWordList)
            {
                words.Add(word);
                wordCounter++;
            }
            
        }
        
        /// <summary>
        /// creates a list of all the sentences from the passed in string
        /// </summary>
        /// <param name="textFile"></param>
        public void CreateSentenceList(string textFile)
        {
            sentences = new List <string>();
            
            
            var tempSentList =  Regex.Split(textFile, @"(?<=[.?!:])");

            for (int i = 0; i < tempSentList.Length; i++)
            {
                sentences.Add(tempSentList[i]);
                sentCounter++;
            }
            
            StringBuilder allWords = new StringBuilder();
            
            foreach (var VARIABLE in sentences)
            {
                allWords.Append(VARIABLE);
                allWords.Append("\n");
            }
        }

        /// <summary>
        /// sets the randomeWord string to a random word from the word list
        /// </summary>
        public void CreateRandomWord()
        {
            Random rand = new Random();
            int RandomInt = rand.Next(0, wordCounter);
            randomWord = words[RandomInt];
        }
        
        /// <summary>
        /// set the random sentence string to a randome sentence from the sentence list
        /// </summary>
        public void CreateRandomeSentence()
        {
           
            Random rand = new Random();
            int RandomInt = rand.Next(0, sentCounter);
            randomSentence = sentences[RandomInt];
        }
        
        /// <summary>
        /// creates a paragraph of senteces in subsequent order of a random length
        /// </summary>
        public void CreateParagraph()
        {
            StringBuilder tempParagraph = new StringBuilder();
            Random rand = new Random();

            int loopCounter = 0;
            int randomNumberOfSent = rand.Next(0, sentCounter);
            int randomStartingPoint = rand.Next(0, sentCounter-randomNumberOfSent);

            while (loopCounter != randomNumberOfSent)
            {
                if (loopCounter + randomNumberOfSent > sentCounter)
                {
                    break;
                }
                tempParagraph.Append(sentences[randomStartingPoint]);
                tempParagraph.Append(" ");
                loopCounter++;
                randomStartingPoint++;               
                
            }
            paragraph = tempParagraph.ToString();
        }
        
        /// <summary>
        /// creates a string of subsequent words with a length passed in 
        /// </summary>
        /// <param name="numOfWords"></param>
        public void CreateWordString(int numOfWords)
        {
        
            StringBuilder wordStringBuilder = new StringBuilder();
            Random rand = new Random();
            int loopCounter = 0;
            int randomStartingPoint = rand.Next(0, wordCounter-numOfWords);
            
            while (loopCounter != numOfWords)
            {
                if (loopCounter + numOfWords > wordCounter)
                {
                    break;
                }
                wordStringBuilder.Append(words[randomStartingPoint]);
                wordStringBuilder.Append(" ");
                loopCounter++;
                randomStartingPoint++;
            }
            wordString = wordStringBuilder.ToString();

        }

        /// <summary>
        /// retuns values created and gathered in this class as a string
        /// </summary>
        /// <returns>Method as a stirng</returns>
        public override string ToString()
        {
            return "\n\n   ===== Text ===== " + " \n Random Sentence : \n" + randomSentence + "\n\n Random Word : " +
                   randomWord +
                   "\n===============================================================" +
                   "\nIf you would like to see a randome paragrah or list of words, \nthen call those methods specificly within the Text class. \n       WARNING THE RESULTS WILL BE MASSIVE!";

        }
    }
}
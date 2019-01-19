using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CapstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string sentence = "";
            string endCharacter ="";//left empty in case there is no end character
            while (sentence == "")
            {
                Console.Write("Hi! Welcome to Pig Latin translator" + "\n" + "Please enter the word to translate: ");

                sentence = Console.ReadLine(); //we will split the sentence and store the splits and call each one by "word"
            }
            if (sentence.EndsWith(".") || sentence.EndsWith("?") || sentence.EndsWith("!"))
            {
                endCharacter = sentence.Substring(sentence.Length - 1);
                sentence = sentence.Substring(0, sentence.Length - 1);
            }
            string [] words=sentence.Split(' ');  //intelliscence informs that .split forms a string array
            for (int i=0; i<words.Length;i++)
            {
                words[i] = WordToPigLatin(words[i]);
                if (i != words.Length - 1)
                {
                    words[i] = words[i] + " ";
                    Console.Write(words[i]);
                }
                else
                {
                    Console.WriteLine(words[i] + endCharacter);
                }
            }//for loop for sentence words
            
            
                         
        }
        public static string WordToPigLatin(string word) //if we did "void" instead of "string" we would need to have the CW() to print the words in this method (instead of main).
        {
            // if i did void instead of string, I do not want return, just the CW()
            char[] vowel = new char[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };

            char[] special = new char[] { '?', '!', '@', '#', '$', '%', '^', '&', '*', '.', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            if (word.IndexOfAny(special)!=-1)
                {//it does nothing
            }
            else if (word.StartsWith("a") || word.StartsWith("e") || word.StartsWith("i") || word.StartsWith("o") || word.StartsWith("u"))
            {
                word = (word + "way");

            }            
            else
            {
                int length = word.Length;
                for (int i = 0; i < length && 0 != word.IndexOfAny(vowel, 0, 1); i++) //in the IndexOfAny it is searching slot 0 reading 1 character and comparing set to the array 'vowel'. if it has a vowel=0, if not, -1.
                {
                    word = word.Substring(1) + word.Substring(0, 1);//this starts at the first instance and put it at the end                  
                }//end of for loop
                word = word + "ay";
                
            }
            return word;
        }


       
    }
}

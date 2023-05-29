using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Text.RegularExpressions;

namespace CodingChallenges
{
    class Program
    {
        /// <summary>
        /// Create a function that takes two numbers as arguments (num, length) and returns an array of multiples
        /// of num until the array length reaches length.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="lenght"></param>
        public static int[] ArrayMultiples(int num, int lenght)
        {
            var returnArray = new List<int>();
            returnArray.Add(num);
            var currentValue = num;
            for (var firstValue = 1; firstValue <= lenght-1; firstValue++)
            {
                returnArray.Add(currentValue+num);
                currentValue = currentValue + num;
            }
            return returnArray.ToArray();
        }
        
        /// <summary>
        /// Create a function that takes a single character as an argument and returns the char code of its lowercased /
        /// uppercased counterpart.
        /// Examples
        /// Given that
        /// - "A" char code is: 6
        /// - "a" char code is: 97
        /// CounterpartCharCode("A") ➞ 97
        /// CounterpartCharCode("a") ➞ 65
        /// Notes
        /// The argument will always be a single character.
        /// Not all inputs will have a counterpart (e.g. numbers), in which case return the input's char code.
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static int CounterpartCharCode(char symbol)
        {
            int returnValue = 0;
            if (symbol.ToString().ToUpper() == symbol.ToString()) // to Lower
            {
              // I convert it to Lower
              int abc = symbol.ToString().ToLower().ToCharArray()[0];
              returnValue = abc;
            }
            else // ToUpper
            {
                int abc = symbol.ToString().ToUpper().ToCharArray()[0];
                returnValue = abc;
            }
            return returnValue;
        }
        
        /// <summary>
        /// Given a fraction as a string, return whether or not it is greater than 1 when evaluated.
        /// Examples
        /// GreaterThanOne("1/2") ➞ false
        /// GreaterThanOne("7/4") ➞ true
        /// GreaterThanOne("10/10") ➞ false
        /// Note : Fractions must be strictly greater than 1 (see example #3).
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool GreaterThanOne(string str)
        {
            var isGreaterThanOne = false;
            var integerValues = str.Split('/');
            decimal formula = decimal.Parse(integerValues[0]) / decimal.Parse(integerValues[1]);
            if (formula > 1)
            {
                isGreaterThanOne = true;
            }
            return isGreaterThanOne;
        }
        
        /// <summary>
        /// Create a function that takes a single string as argument and returns an ordered array
        /// containing the indices of all capital letters in the string.
        /// IndexOfCapitals("eDaBiT") ➞ [1, 3, 5]
        /// IndexOfCapitals("eQuINoX") ➞ [1, 3, 4, 6]
        /// IndexOfCapitals("determine") ➞ []
        /// IndexOfCapitals("STRIKE") ➞ [0, 1, 2, 3, 4, 5]
        /// IndexOfCapitals("sUn") ➞ [1]
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int[] IndexOfCapitals(string str)
        {

            List<int> returnArray = new List<int>();
            char[] temp = str.ToCharArray();
            Regex test = new Regex("[A-Z]");
            for (int oneChar = 0; oneChar < temp.Length; oneChar++)
            {
                if (char.IsLetter(temp[oneChar]));
                {
                    if (char.IsUpper(temp[oneChar]))
                    {
                        returnArray.Add(oneChar);
                    }
                }
            }

            if (returnArray.Count == 0)
            {
                int[] myIntArray = new int[0];
                return myIntArray;
            }

            return returnArray.ToArray();
        }
        
        /// <summary>
        /// Count the amount of ones in the binary representation of an integer. For example, since 12 is 1100 in binary, the return value should be 2.
        /// Examples
        /// CountOnes(0) ➞ 0
        /// CountOnes(100) ➞ 3
        /// CountOnes(999) ➞
        /// Notes
        /// The input will always be a valid integer (number).
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int CountOnes(int i)
        {
            string binaryRep = Convert.ToString(i, 2);
            int counter = 0;

            foreach (char SingleChar in binaryRep.ToCharArray())
            {
                int s = int.Parse(SingleChar.ToString());
                if (s == 1)
                {
                    counter++;
                }
            }
            return counter;
        }
        
        /// <summary>
        /// Create a function that takes an array of arrays with numbers. Return a new (single) array with the largest numbers of each.
        /// Examples
        /// FindLargest([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]]) ➞ [7, 90, 2]
        /// FindLargest([[-34, -54, -74], [-32, -2, -65], [-54, 7, -43]]) ➞ [-34, -2, 7]
        /// FindLargest([[0.4321, 0.7634, 0.652], [1.324, 9.32, 2.5423, 6.4314], [9, 3, 6, 3]]) ➞ [0.7634, 9.32, 9]
        /// Notes
        /// Watch out for negative numbers.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static double[] FindLargest(double[][] values) 
        {
            List<double> returnArray = new List<double>();
            foreach (double[] eachSingleArray in values)
            {
                returnArray.Add(eachSingleArray.Max());
            }

            return returnArray.ToArray();
        }
        
        /// <summary>
        /// Create a function that finds the word "bomb" in the given string (not case sensitive). If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".
        /// Examples
        /// Bomb("There is a bomb.") ➞ "Duck!!!"
        /// Bomb("Hey, did you think there is a bomb?") ➞ "Duck!!!"
        /// Bomb("This goes boom!!!") ➞ "There is no bomb, relax."
        /// Notes
        /// "bomb" may appear in different cases (i.e. uppercase, lowercase, mixed).
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static string Bomb(string txt)
        {
            Regex abc = new Regex("(bomb)", RegexOptions.IgnoreCase);
            string returnValue = abc.IsMatch(txt) ? "Duck!!!" : "There is no bomb, relax.";
            return returnValue;
        }
        
        /// <summary>
        /// Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
        /// Examples
        /// ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"
        /// ReverseCase("MANY THANKS") ➞ "many thanks"
        /// ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
        /// Notes
        /// N/A
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseCase(string str) 
        {
            StringBuilder reversedString = new StringBuilder();
            
            char[] b = str.ToCharArray();
            foreach (char singleLetter in b)
            {
                if (char.IsUpper(singleLetter))
                {
                    reversedString.Append(singleLetter.ToString().ToLower());
                }
                else
                {
                    reversedString.Append(singleLetter.ToString().ToUpper());
                }
            }
            return reversedString.ToString();
        }


        /// <summary>
        /// Main to test algorithms
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //ArrayMultiples(7, 5);
            //char b = 'A';
            //Console.WriteLine(CounterpartCharCode(b));
            //Console.WriteLine(GreaterThanOne("7/4"));
            //IndexOfCapitals("Fo?.arg~{86tUx=|OqZ!");
            //Console.WriteLine(CountOnes(12));
            //Console.WriteLine(Bomb("Hey, did you find the BoMb?"));
            Console.WriteLine(ReverseCase("Happy Birthday"));
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

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
        /// Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.
        /// To illustrate:
        /// "123"
        /// We reverse "123" to get "321" and then add "123" to the end, resulting in "321123".
        /// Examples
        /// ReverseAndNot(123) ➞ "321123"
        /// ReverseAndNot(152) ➞ "251152"
        /// ReverseAndNot(123456789) ➞ "987654321123456789"
        /// Notes
        /// i is a non-negative integer.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string ReverseAndNot(int i)
        {
            StringBuilder output = new StringBuilder();
            var charArrfromStr = i.ToString().ToCharArray();
            
            Array.Reverse(charArrfromStr);
            foreach (char singleCharInReversed in charArrfromStr)
            {
                output.Append(singleCharInReversed.ToString());
            }

            output.Append(i.ToString());
            return output.ToString();
        }
        
        /*
         * Create a function that takes an array of integers and strings, converts integers to strings, and
         * returns the array as a string array.
         * Examples
         * ParseArray([1, 2, "a", "b"]) ➞ ["1", "2", "a", "b"]
         * ParseArray(["abc", 123, "def", 456]) ➞ ["abc", "123", "def", "456"]
         * ParseArray([1, 2, 3, 17, 24, 3, "a", "123b"]) ➞ ["1", "2", "3", "17", "24", "3", "a", "123b"]
         * ParseArray([]) ➞ []
         */
        public static string[] ParseArray (object[] arr)
        {
            List<string> output = new List<string>();
            foreach (var b in arr)
            {
                output.Add(b.ToString());
            }
            return output.ToArray();

        }
        
        /*Create a function that accepts a string of space separated numbers and returns
         the highest and lowest number (as a string).
         Examples
         HighLow("1 2 3 4 5") ➞ "5 1"
         HighLow("1 2 -3 4 5") ➞ "5 -3"
         HighLow("1 9 3 4 -5") ➞ "9 -5"
         HighLow("13") ➞ "13 13"
         Notes
         All numbers are valid Int32, no need to validate them.
         There will always be at least one number in the input string.
         Output string must be two numbers separated by a single space, and highest number is first.
         */
        public static string HighLow(string str)
        {
            var StrSplit = str.Split(' ');
            int[] strSplitToIntArr = new int[StrSplit.Length];

            for (int i = 0; i < strSplitToIntArr.Length; i++)
            {
                strSplitToIntArr[i] = int.Parse(StrSplit[i]);
            }

            int max = strSplitToIntArr.Max();
            int min = strSplitToIntArr.Min();

            return max + " " + min;
        }
        
        /*
         * A strong Scottish accent makes every vowel similar to an "e", so you should replace every
         * vowel with an "e". Additionally, it is being screamed, so it should be in block capitals.
         * Create a function that takes a string and returns a string.
         * Examples
         * ToScottishScreaming("hello world") ➞ "HELLE WERLD"
         * ToScottishScreaming("Mr. Fox was very naughty") ➞ "MR. FEX WES VERY NEEGHTY"
         * ToScottishScreaming("Butterflies are beautiful!") ➞ "BETTERFLEES ERE BEEETEFEL!"
         * Notes
         * Make sure to include all punctuation that is in the original string.
         * You don't need any more namespaces than are already given.
         */
        public static string ToScottishScreaming(string str) {
		    // find every vowel and replace it with e
            // capitalise
            var initialArray = str.ToCharArray();
            StringBuilder builder = new StringBuilder();
            foreach (char b in initialArray)
            {
                // a e o u 
                if (b.ToString().ToLower().Equals("a") 
                    || b.ToString().ToLower().Equals("i")
                    || b.ToString().ToLower().Equals("o") 
                    || b.ToString().ToLower().Equals("u"))
                {
                    builder.Append("e");
                }
                else
                {
                    builder.Append(b.ToString());
                }
            }

            return builder.ToString().ToUpper();

        }
        
        
        /*
         * Create a function that takes an array of non-negative integers and strings and return a new array without
         * the strings.
         * Examples
         * FilterArray([1, 2, "a", "b"]) ➞ [1, 2]
         * FilterArray([1, "a", "b", 0, 15]) ➞ [1, 0, 15]
         * FilterArray([1, 2, "aasf", "1", "123", 123]) ➞ [1, 2, 123]
         * Notes
         * Zero is a non-negative integer.
         * The given array only has integers and strings.
         * Numbers in the array should not repeat.
         * The original order must be maintained.
         */
        public static int[] FilterArray(object[] arr)
        {
            // loop / try parse to int add return
            List<int> output = new List<int>();
            foreach (var b in arr)
            {
                try
                {
                    output.Add(int.Parse(b.ToString()));
                } catch { }
            }

            List<int> filtered = new List<int>();
            foreach (var c in output.ToArray().Distinct())
            {
                filtered.Add(c);
            }

            return filtered.ToArray();
        }
        
        
        /*
         * Create a function that takes an array of positive and negative numbers.
         * Return an array where the first element is the count of positive numbers and the second element is the sum of negative numbers.
         * Examples
         * CountPosSumNeg([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15]) ➞ [10, -65]
         * // There are a total of 10 positive numbers.
         * // The sum of all negative numbers equals -65.
         * CountPosSumNeg([92, 6, 73, -77, 81, -90, 99, 8, -85, 34]) ➞ [7, -252]
         * CountPosSumNeg([91, -4, 80, -73, -28]) ➞ [2, -105]
         * CountPosSumNeg([]) ➞ []
         * Notes
         * If given an empty array, return an empty array: []
         * Cast sum to int, don't mind the remaining decimal places.
         * 0 is not positive.
         */
        public static int[] CountPosSumNeg(double[] arr) 
        {
            // loop find negative and positives
            // add positives to array1 add negatives to array2
            // sum positives sum negatives add to a third array

            if (arr.Length == 0)
            {
                int[] b = new int[0];
                return b;
            }

            List<double> positives = new List<double>();
            List<double> negatives = new List<double>();

            foreach (double c in arr)
            {
                if (c > 0)
                {
                    positives.Add(c);
                }
            }

            foreach (double d in arr)
            {
                if (d < 0)
                {
                    negatives.Add(d);
                }
            }

            var negativeSum = negatives.AsQueryable().Sum().ToString();
            
            List<int> output = new List<int>();
            output.Add(positives.Count);
            output.Add(int.Parse(negativeSum));
            return output.ToArray();

        }
        
        /*
         * Write a function that returns the greatest common divisor (GCD) of two integers.
         * Examples
         * gcd(32, 8) ➞ 8
         * gcd(8, 12) ➞ 4
         * gcd(17, 13) ➞ 1
         * Notes
         * Both values will be positive.
         * The GCD is the largest factor that divides both numbers.
         */
        public static int gcd(int n1, int n2)
        {
            while (n2 != 0)
            {
                int temp = n2;
                n2 = n1 % n2;
                n1 = temp;
            }
            return n1;
        }
        
        /*
         * Usually when you sign up for an account to buy something, your credit card number, phone number or answer
         * to a secret question is partially obscured in some way. Since someone could look over your shoulder,
         * you don't want that shown on your screen. Hence, the website masks these strings.
         * Your task is to create a function that takes a string, transforms all but the last four characters
         * into "#" and returns the new masked string.
         * Examples
         * Maskify("4556364607935616") ➞ "############5616"
         * Maskify("64607935616") ➞ "#######5616"
         * Maskify("1") ➞ "1"
         * Maskify("") ➞ ""
         * Notes
         * The maskify function must accept a string of any length.
         * An empty string should return an empty string (fourth example above).
         */
        public static string Maskify(string str) 
        {
            var strLen = str.Length;
            var strStartFrom = strLen - 4;
            var toArr = str.ToArray();
            var builder = new StringBuilder();
            for (int i = 0; i < strLen - 4; i++)
            {
                builder.Append("#");
            }

            for (int i = strStartFrom; i < strLen; i++)
            {
                builder.Append(toArr[i]);
            }

            return builder.ToString();
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
            //Console.WriteLine(ReverseCase("Happy Birthday"));
            //Console.WriteLine(ReverseAndNot(123));
            //Console.WriteLine(HighLow("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6"));
            //FilterArray(new object[] { 1, 2, "aasf", "1", "123", 123 });
            //CountPosSumNeg(new double[] { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 });
            //gcd(8, 12);
            //Console.WriteLine(Maskify("4556364607935616"));
        }
    }
}
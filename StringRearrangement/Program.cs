using System;

namespace StringRearrangement
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalText = "They are cow actually which they really need";
            string[] splitWord = new string[originalText.Length];
            string tempString = null;
            int count = 0;
            string finalString = null;
            var words = originalText.ToLower().Split(" ");
            foreach (var word in words)
            {
                splitWord[count] = word;
                count++;
            }
            for (int j = 0; j < count - 1; j++)
            {
                for (int k = 0; k < count - j - 1; k++)
                {
                    if (splitWord[k].Length > splitWord[k + 1].Length)
                    {
                        tempString = splitWord[k];
                        splitWord[k] = splitWord[k + 1];
                        splitWord[k + 1] = tempString;
                    }
                }
            }

            for (int j = 0; j < count; j++)
            {
                finalString += splitWord[j] + " ";
            }

            Console.WriteLine(char.ToUpper(finalString[0]) + finalString.Substring(1).Trim() + ".");
        }
    }
}

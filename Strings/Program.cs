using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string isFound = "";
            string alicesParagraph = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string lowerAlicesParagraph = alicesParagraph.ToLower();

            Console.WriteLine("What term do you want to search for in the book 'Alice’s Adventures in Wonderland'? ");
            string userSearchTerm = Console.ReadLine();
            string lowerSearchTerm = userSearchTerm.ToLower();

            if (lowerAlicesParagraph.IndexOf(lowerSearchTerm) < 0){
                isFound = "False";
            }
            else{
                isFound = "True";
            }
            string firstAlicesParagraph = alicesParagraph.Substring(0, lowerAlicesParagraph.IndexOf(lowerSearchTerm));
            //Console.WriteLine(firstAlicesParagraph);
            int termIndex = 1;
            int termLength = 4;
            int termIndexPlusLength = termIndex + termLength;
            int paragraphLength = lowerAlicesParagraph.Length;
            string lastAlicesParagraph = alicesParagraph.Substring(termIndexPlusLength, paragraphLength - termIndexPlusLength);
            //Console.WriteLine(lastAlicesParagraph);
            string EditedAlicesParagraph = firstAlicesParagraph + lastAlicesParagraph;
            //Console.WriteLine(EditedAlicesParagraph);

            Console.WriteLine("Was the search term '" + userSearchTerm + "' found in the book 'Alice’s Adventures in Wonderland'?(True or False): " + isFound);
            Console.WriteLine("Index of term: " + lowerAlicesParagraph.IndexOf(lowerSearchTerm));
            Console.WriteLine("Length of term: " + lowerSearchTerm.Length);
            Console.WriteLine("Paragraph with term removed: " + EditedAlicesParagraph);


        }
    }
}

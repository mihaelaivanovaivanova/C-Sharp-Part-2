using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIslands = int.Parse(Console.ReadLine());
            string[] flightToIslands = new string[numberOfIslands];
            for (int i = 0; i < numberOfIslands; i++)
            {
                flightToIslands[i] = Console.ReadLine();
            }
            StringBuilder requests = new StringBuilder();
            string currentRequest = Console.ReadLine();
            while (currentRequest != "Have a break")
            {
                requests.Append(currentRequest + " ");
                currentRequest = Console.ReadLine();
            }
            string[] separatedRequests = requests.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < separatedRequests.Length - 1; i += 2)
            {
                string SearchedIslandOne = flightToIslands[int.Parse(separatedRequests[i])];
                string SearchedIslanTwo = separatedRequests[i + 1];
                int indexOne = SearchedIslandOne.IndexOf(SearchedIslanTwo + " ");
                int indexTwo = SearchedIslandOne.IndexOf(" " + SearchedIslanTwo);
                if (indexOne > -1 && ((indexOne-1>-1 && SearchedIslandOne.Substring(indexOne-1,1)==" ")||(indexOne - 1 < -1))
                    || indexTwo > -1)
                {
                    Console.WriteLine("There is a direct flight.");
                }
                else if (SearchedIslandOne == "None"
                    || SearchedIslandOne == "None")
                {
                    Console.WriteLine("No flights available.");
                }
                else
                {
                    Console.WriteLine("There are flights, unfortunately they are not direct, grandma :(");
                }
            }
        }
    }
}

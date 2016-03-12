namespace MobilePhoneProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class GSMCallHistoryTest  // Task 12
    {
        public static GSM testGSM = new GSM();

        // Adding some calls
        public static DateTime testCall2Date = DateTime.Parse("08/03/2015 19:15:30");
        public static DateTime testCall3Date = DateTime.Parse("09/03/2015 14:07:18");
        public static DateTime testCall4Date = DateTime.Parse("10/03/2015 08:15:55");
        public static DateTime testCall5Date = DateTime.Parse("10/03/2015 12:37:03");
        public static DateTime testCall1Date = DateTime.Parse("10/03/2015 09:25:10");

        public static DateTime[] dateTime = new DateTime[] { testCall2Date, testCall3Date, testCall4Date, testCall5Date, testCall1Date };

        public static string[] phoneNumbers = new string[] { "0899638562", "0899634562", "0899637589", "0889658562", "0899638545" };

        public static int[] durationArray = new int[] { 20, 34, 24, 12, 32 };

        public static List<Call> generateCalls = new List<Call>();

        public static List<Call> CreateCalltestHistory()
        {
            //Call[] generateCalls = new Call[5];
            for (int i = 0; i < dateTime.Length; i++)
            {
                generateCalls.Add(new Call(dateTime[i], phoneNumbers[i], durationArray[i]));
            }
            return generateCalls;
        }

        public static void CalculateAndPrintTestcallsPrice()
        {
            decimal price = GSM.CalculateTotalCallPrice(generateCalls, 0.37M); //using method of the GSM class
            Console.WriteLine("Total price of test calls: {0:F2}", price);
        }

        public static void RemoveLongestCall()
        {
            List<Call> longestCall = generateCalls.OrderBy(x => x.Duration).ToList(); //getting the longest call from the list of calls
            longestCall.RemoveAt(longestCall.Count - 1);
            decimal price = GSM.CalculateTotalCallPrice(longestCall, 0.37M); //using method of the GSM class
            Console.WriteLine("Total price without longest call: {0:F2}", price);
        }
    }
}

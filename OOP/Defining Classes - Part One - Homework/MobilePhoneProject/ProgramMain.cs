namespace MobilePhoneProject
{
    using System;

    public class ProgramMain
    {
        static void Main()
        {
            var testGSM = new GSM();

            Console.WriteLine(GSM.iPhone4S.ToString()); // Displaying Iphone info

            var gsms = GSMTest.GenerateGSMs(); //Task 7 - GSM Test Class info
            GSMTest.PrintGSMsInfo(gsms);

            //problem 12

            var callsRegister = GSMCallHistoryTest.CreateCalltestHistory();  // Print Call History
            GSM.PrintCallHistory(callsRegister);
            GSMCallHistoryTest.CalculateAndPrintTestcallsPrice();   // Printing the total price of the Call History
            Console.WriteLine(new string('-', 50));
            GSMCallHistoryTest.RemoveLongestCall();                 // Printing the total price witout the longest call
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Clearing Data........");             // Clearing call history and printing the empty List<Call>;
            callsRegister.Clear();
            GSM.PrintCallHistory(callsRegister);
            Console.WriteLine("Call History data cleared !");
        }
    }
}
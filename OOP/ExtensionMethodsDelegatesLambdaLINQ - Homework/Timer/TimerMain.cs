namespace Timer
{
    using System;

    //Using delegates write a class Timer that can execute certain method at each t seconds.

    class TimerMain
    {
        static void Main()
        {
            Timer timer = new Timer(5);

            timer.SomeMethods += FirstTestMethod;
            timer.SomeMethods += SecondTestMethod;
            timer.ExecuteMethods();
        }

        public static void FirstTestMethod()
        {
            Console.WriteLine("This is the first method and will be executed every couple of seconds");
        }

        public static void SecondTestMethod()
        {
            Console.WriteLine("This is the second method and will be executed every couple of seconds");
        }
    }
}

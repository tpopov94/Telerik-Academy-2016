namespace MobilePhoneProject
{
    using System;

    public class GSMTest
    {
        static string[] manufacturers = new string[] { "Samsung", "Sony", "Nokia", "Sagem", "Telefoni Aparati" };
        static string[] model = new string[] { "Galaxy", "Petrohan", "Balkan", "Vitoshka", "Super Lubo" };
        static decimal[] priceRange = new decimal[] { 1000m, 900m, 300m, 400m, 20m };
        static string[] owner = new string[] { "Petko", "Stamat", "Dinko", "Bat Georgi", "Kuci" };

        public static GSM[] GenerateGSMs()
        {
            GSM[] gsms = new GSM[5];
            var b = new Battery("Bateriq Raketa", 300, 25, BatteryType.LiPoly);
            var disp = new Display(400, 20000);

            for (int i = 0; i < 5; i++)
            {
                gsms[i] = new GSM(model[i], manufacturers[i], priceRange[i], owner[i], b, disp);
            }

            return gsms;
        }

        public static void PrintGSMsInfo(GSM[] gsms)
        {
            for (int i = 0; i < gsms.Length; i++)
            {
                Console.WriteLine("Generated GSM {0}: {1}", i + 1, string.Join(" ", gsms[i]));
            }

            Console.WriteLine("IPhone info: {0}", GSM.IPhone4S);
        }
    }
}

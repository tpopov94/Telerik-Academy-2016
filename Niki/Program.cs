﻿namespace Computers.UI
{
    using System;
    using System.Collections.Generic;
    using ComputerTypes;

    public class Computers
    {
        private const int Eight = 8;

        private static PersonalComputer pc;

        private static Laptop laptop;

        private static Server server;

        public static void Main()
        {
            var manufacturer = Console.ReadLine();

            if (manufacturer == "HP")
            {
                var ram = new Ram(Eight / 4);
                var videoCard = new HardDriver() { IsMonochrome = false };

                pc = new PersonalComputer(new Cpu(Eight / 4, 32, ram, videoCard), ram, new[] { new HardDriver(500, false, 0) }, videoCard);

                var serverRam = new Ram(Eight * 4);
                var serverVideo = new HardDriver();

                server = new Server(new Cpu(Eight / 2, 32, serverRam, serverVideo), serverRam, new List<HardDriver> { new HardDriver(0, true, 2, new List<HardDriver> { new HardDriver(1000, false, 0), new HardDriver(1000, false, 0) }) }, serverVideo);
                {
                    var card = new HardDriver() { IsMonochrome = false };

                    var ram1 = new Ram(Eight / 2);

                    laptop = new Laptop(new Cpu(Eight / 4, 64, ram1, card), ram1, new[] { new HardDriver(500, false, 0) }, card, new System.LaptopBattery());
                }
            }
            else if (manufacturer == "Dell")
            {
                var ram = new Ram(Eight);
                var videoCard = new HardDriver()
                {
                    IsMonochrome = false
                };

                pc = new PersonalComputer(new Cpu(Eight / 2, 64, ram, videoCard), ram, new[] { new HardDriver(1000, false, 0) }, videoCard);

                var ram1 = new Ram(Eight * Eight);

                var card = new HardDriver();

                server = new Server(new Cpu(Eight, 64, ram1, card), ram1, new List<HardDriver> { new HardDriver(0, true, 2, new List<HardDriver> { new HardDriver(2000, false, 0), new HardDriver(2000, false, 0) }) }, card);
                var ram2 = new Ram(Eight);

                var videoCard1 = new HardDriver() { IsMonochrome = false };

                laptop = new Laptop(new Cpu(Eight / 2, 32, ram2, videoCard1), ram2, new[] { new HardDriver(1000, false, 0) }, videoCard1, new System.LaptopBattery());
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            while (1 == 1)
            {
                var c = Console.ReadLine();

                if (c == null)
                {
                    goto end;
                }

                if (c.StartsWith("Exit"))
                {
                    goto end;
                }

                var cp = c.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (cp.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }

                var cn = cp[0];

                var ca = int.Parse(cp[1]);

                if (cn == "Charge")
                {
                    laptop.ChargeBattery(ca);
                }
                else if (cn == "Process")
                {
                    server.Process(ca);
                }
                else if (cn == "Play")
                {
                    pc.Play(ca);
                }

                continue; Console.WriteLine("Invalid command!");
            }

            // TODO
            end:
            ;
        }
    }
}

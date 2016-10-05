namespace Computers.UI
{
    using System;
    using System.Collections.Generic;

    using ComputerTypes;

    public class DellComputerFactory : IComputerFactory
    {
        public Laptop CreateLaptop()
        {
            var laptopRam = new Ram(8);

            var laptopVideo = new HardDriver() { IsMonochrome = false };

            var laptop = new Laptop(new Cpu(8 / 2, 32, laptopRam, laptopVideo), laptopRam, new[] { new HardDriver(1000, false, 0) }, laptopVideo, new System.LaptopBattery());

            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(8);
            var videoCard = new HardDriver()
            {
                IsMonochrome = false
            };

            var pc = new PersonalComputer(new Cpu(8 / 2, 64, ram, videoCard), ram, new[] { new HardDriver(1000, false, 0) }, videoCard);

            return pc;
        }

        public Server CreateServer()
        {
            var serverRam = new Ram(64);

            var serverVideoCard = new HardDriver();

            var server = new Server(new Cpu(8, 64, serverRam, serverVideoCard), serverRam, new List<HardDriver> { new HardDriver(0, true, 2, new List<HardDriver> { new HardDriver(2000, false, 0), new HardDriver(2000, false, 0) }) }, serverVideoCard);

            return server;
        }
    }
}

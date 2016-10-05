namespace Computers.UI
{
    using System;
    using System.Collections.Generic;
    using ComputerTypes;

    public class Computers
    {
        private static PersonalComputer pc;

        private static Laptop laptop;

        private static Server server;

        public static void Main()
        {
            CreateComputers();

            ProcessCommand();
        }

        private static void CreateComputers()
        {
            var manufacturer = Console.ReadLine();
            IComputerFactory computerFactory;

            if (manufacturer == "HP")
            {
                computerFactory = new HpComputerFactory();
            }
            else if (manufacturer == "Dell")
            {
                computerFactory = new DellComputerFactory();
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            pc = computerFactory.CreatePersonalComputer();

            laptop = computerFactory.CreateLaptop();

            server = computerFactory.CreateServer();
        }

        private static void ProcessCommand()
        {
            while (true)
            {
                var c = Console.ReadLine();

                if (c == null)
                {
                    break;
                }

                if (c.StartsWith("Exit"))
                {
                    break;
                }

                var cp = c.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (cp.Length != 2)
                {
                    throw new ArgumentException("Invalid command!");
                }

                var commandName = cp[0];

                var commandArgument = int.Parse(cp[1]);

                if (commandName == "Charge")
                {
                    laptop.ChargeBattery(commandArgument);
                }
                else if (commandName == "Process")
                {
                    server.Process(commandArgument);
                }
                else if (commandName == "Play")
                {
                    pc.Play(commandArgument);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }

        private static void Hp()
        {
        }

        private static void Dell()
        {
        }
    }
}

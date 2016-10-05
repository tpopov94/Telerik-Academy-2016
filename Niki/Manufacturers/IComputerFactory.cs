namespace Computers.UI
{
    using ComputerTypes;

    public interface IComputerFactory
    {
        PersonalComputer CreatePersonalComputer();

        Laptop CreateLaptop();

        Server CreateServer();
    }
}

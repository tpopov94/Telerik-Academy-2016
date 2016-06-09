namespace MobilePhoneProject
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        public static GSM iPhone4S = new GSM("I6", "Apple", 500, "Some Guy", new Battery("some", 15, 200, BatteryType.NiMH), new Display(5, 200));

        private string model; // Task 1
        private string manufacturer; // Task 1
        private decimal price; // Task 1
        private string owner; // Task 1
        private Battery battery; // Task 1
        private Display display; // Task 1
        private List<Call> callHistory; // Task 9

        // Constructors:
        //Parametless Constructor 
        public GSM() // Task 2
        {
            this.model = "Standart";
            this.manufacturer = "None";
            this.price = 0m;
            this.owner = "None";
            this.Battery = battery;
            this.Display = display;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display) // Task 2
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }


        //Properties:  // Task 5

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (value.Length <= 0 || value.Length >= 25)
                {
                    throw new ArgumentOutOfRangeException("Model name should be longer than 0 and shorter than 25 symbols");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (value.Length <= 0 || value.Length >= 25)
                {
                    throw new ArgumentOutOfRangeException("Model name should be longer than 0 and shorter than 25 symbols");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentOutOfRangeException("Price should be > 0 and <= 10000");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                if (value.Length <= 0 || value.Length >= 30)
                {
                    throw new ArgumentOutOfRangeException("Owner name should be longer than 0 and shorter than 30 symbols");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            private set { this.battery = value; }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }

        public List<Call> CallHistory // Task9
        {
            get { return this.callHistory; }
            private set { this.callHistory = value; }
        }

        //Methods
        //Task 4
        public override string ToString()
        {
            Console.WriteLine(new string('-', 50));
            var GSMInfo = "Manufacturer: " + this.Manufacturer + "\r\nModel: " + this.Model + "\r\nPrice: " + this.Price + "\r\nOwner: " + this.Owner;
            var BatteryInfo = "\r\nBattery Model: " + this.Battery.BatteryModel + "\r\nBattery Type: " + this.Battery.BatteryType + "\r\nHours Idle: " + this.Battery.HoursIdle + "\r\nHours Talk: "
            + this.Battery.HoursTalk;
            var DisplayInfo = "\r\nDisplay Size: " + this.Display.Size + "\r\nNumber Of Colors: " + this.Display.NumberOfColors;
            return string.Join("", GSMInfo, BatteryInfo, DisplayInfo);
        }

        // Task 10
        public void AddCalls(DateTime date, string phoneNumber, int duration)
        {
            this.CallHistory.Add(new Call(date, phoneNumber, duration));

        }

        public List<Call> DeleteCalls(Call call)
        {
            this.CallHistory.Remove(call);
            return new List<Call>(this.callHistory);
        }

        public List<Call> ClearCallHistory()
        {
            this.CallHistory.Clear();
            return new List<Call>(this.callHistory);
        }

        // Task 11

        public static decimal CalculateTotalCallPrice(List<Call> call, decimal price)
        {
            int totalDuration = 0;
            for (int i = 0; i < call.Count; i++)
            {
                totalDuration += call[i].Duration;
            }
            decimal totalPrice = totalDuration * price;
            return totalPrice;
        }

        public static void PrintCallHistory(List<Call> calls)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Call History");
            for (int i = 0; i < calls.Count; i++)
            {
                Console.WriteLine("Call History{0}: {1}", i + 1, string.Join(" ", calls[i]));
                Console.WriteLine(new string('-', 50));
            }
        }

    }
}

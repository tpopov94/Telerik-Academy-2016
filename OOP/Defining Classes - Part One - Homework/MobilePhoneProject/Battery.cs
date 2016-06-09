namespace MobilePhoneProject
{
    using System;

    public class Battery
    {
        private string batteryModel; // Task 1
        private int hoursIdle; // Task 1
        private int hoursTalk; // Task 1
        private BatteryType batteryType;// Task 3

        //Parametless Constructor 
        public Battery() // Task 2
        {
            this.batteryModel = "None";
            this.hoursIdle = 0;
            this.hoursTalk = 0;
            this.batteryType = BatteryType.LiIon;
        }

        public Battery(string batteryModel, int hoursIdle, int hoursTalk, BatteryType batteryType) // Task 2
        {
            this.batteryModel = batteryModel;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        //Properties:  // Task 5

        public string BatteryModel
        {
            get { return this.batteryModel; }
            private set
            {
                if (value.Length == 0 || value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("Model name should be longer than 0 and shorter than 20 symbols");
                }
                else
                {
                    this.batteryModel = value;
                }
            }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            private set
            {
                if (value <= 0 || value >= 500)
                {
                    throw new ArgumentOutOfRangeException("Battery Idle hours should be betweeb 0 and 500");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0 || value >= 500)
                {
                    throw new ArgumentOutOfRangeException("Battery talk hours should be between 0 and 500");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            private set { this.batteryType = value; }
        }


        // Methods
        /*public override string ToString()
        {
            return String.Format("Model: {0}, Hours idle: {1}, Hours talk: {2}, Type: {3}",
            this.batteryModel, this.hoursIdle, this.hoursTalk, this.batteryType);
        }*/
    }
}

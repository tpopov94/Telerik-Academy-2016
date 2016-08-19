namespace MineSweeper
{
    public class Points
    {
        private string name;
        private int points;

        public Points()
        {
        }

        public Points(string name, int points)
        {
            this.PlayerName = name;
            this.PlayerPoints = points;
        }

        public string PlayerName
        {
            get 
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int PlayerPoints
        {
            get
            {
                return this.points;
            }

            set
            {
                this.points = value;
            }
        }
    }
}

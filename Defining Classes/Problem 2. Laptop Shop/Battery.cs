namespace Problem_2.Laptop_Shop
{
    using System;

    class Battery
    {
        private string batteryType;
        private int batteryCells;
        private double batteryVoltage;
        private double batteryLife;

        public Battery() : this("Default", 1, 1, 1) { } //DEFAULT

        public Battery(string batteryType, int batteryCells, double batteryVoltage, double batteryLife)
        {
            this.BatteryType = batteryType;
            this.BatteryCells = batteryCells;
            this.BatteryVoltage = batteryVoltage;
            this.BatteryLife = batteryLife;
        }

        public string BatteryType
        {
            get { return this.batteryType; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Uknown Battery type");
                }

                this.batteryType = value;
            }
        }

        public int BatteryCells
        {
            get { return batteryCells; }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Cells can not be less than 1");
                }

                this.batteryCells = value;
            }
        }

        public double BatteryVoltage
        {
            get { return this.batteryVoltage; }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Battery voltage can not be less than 1");
                }

                this.batteryVoltage = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery life can not be negative number");
                }

                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Battery: {0}, {1}-Cells, {2} mAh\r\nBattery life: {3} hour(s).",
                this.batteryType, this.batteryCells, this.batteryVoltage, this.batteryLife);
        }
    }
}

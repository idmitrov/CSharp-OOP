namespace Problem_2.Laptop_Shop
{
    using System;

    class Laptop
    {
        //CONSTANTS
        private const string negativeValueErr = "can not be negative number";
        private const string nullOrEmptyValueErr = "can not be empty";

        //FIELDS

        //REQUIRED FIELDS
        private string model;
        private decimal price;

        //OPTIONAL FIELDS
        private string manifacturer;
        private string processor;
        private string ram;
        private string grapicsCard;
        private string hdd;
        private string screen;
        private Battery battery;

        //CONSTRUCTOR
        public Laptop(string model, decimal price,
            string manifacturer = null, string processor = null,
            string ram = null, string gpu = null, string hdd = null,
            string screen = null, Battery battery = null)
        {
            //REQUIRED
            this.Model = model;
            this.Price = price;
            //OPTIONAL
            this.Manifacturer = manifacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GPU = gpu;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = new Battery();
        }

        //REQUIRED PROPS

        //MODEL (CAN BE SET ONLY IN CONSTRUCTOR)
        public string Model
        {
            get { return this.model; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format("Model {0}", nullOrEmptyValueErr));
                }
                this.model = value;
            }
        }

        //PRICE
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(String.Format("Price {0}", negativeValueErr));
                }
                this.price = value;
            }
        }

        //OPTIONAL PROPS

        //MANIFACTURER
        public string Manifacturer
        {
            get { return this.Manifacturer; }
            set
            {
                if (value != null && string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format("Manifacturer {0}", nullOrEmptyValueErr));
                }
                this.manifacturer = value;
            }
        }

        //PROCESSOR
        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value != null && string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format("Processor {0}", nullOrEmptyValueErr));
                }
                this.processor = value;
            }
        }

        //RAM
        public string RAM
        {
            get { return this.ram; }
            set
            {
                if (value != null && string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format("RAM {0}", nullOrEmptyValueErr));
                }
                this.ram = value;
            }
        }

        //GPU
        public string GPU
        {
            get { return this.grapicsCard; }
            set
            {
                if (value != null && string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format("Graphics card {0}", nullOrEmptyValueErr));
                }
                this.grapicsCard = value;
            }
        }

        //HDD
        public string HDD
        {
            get { return this.hdd; }
            set
            {
                if (value != null && string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format("HDD {0}", nullOrEmptyValueErr));
                }
                this.hdd = value;
            }
        }

        //SCREEN
        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value != null && string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format("SCREEN {0}\r\n", nullOrEmptyValueErr));
                }
                this.screen = value;
            }
        }

        //BATTERY
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        //OVERRIDE TO STRING
        public override string ToString()
        {
            string laptopSpecs = "Simple laptop description:\r\n\r\n";

            //MODEL
            laptopSpecs += String.Format("Model: {0}\r\n", this.model);

            //MANIFACTURER
            if (this.manifacturer != null)
            {
                laptopSpecs += String.Format("Manifacturer: {0}\r\n", this.manifacturer);
            }

            //PROCESSOR
            if (this.processor != null)
            {
                laptopSpecs += String.Format("Processor: {0}\r\n", this.processor);
            }

            //RAM
            if (this.ram != null)
            {
                laptopSpecs += String.Format("RAM: {0}\r\n", this.ram);
            }

            //GPU
            if (this.grapicsCard != null)
            {
                laptopSpecs += String.Format("Grapgics card: {0}\r\n", this.grapicsCard);
            }

            if (this.hdd != null)
            {
                laptopSpecs += String.Format("HDD: {0}\r\n", this.hdd);
            }

            //SCREEN
            if (this.screen != null)
            {
                laptopSpecs += String.Format("Screen: {0}\r\n", this.screen);
            }

            //BATTERY
            if (battery.BatteryType != "Default")
            {
                laptopSpecs += String.Format("{0}\r\n", this.battery);
            }

            //PRICE
            laptopSpecs += String.Format("Price: {0}\r\n", this.price);

            return laptopSpecs;
        }
    }
}

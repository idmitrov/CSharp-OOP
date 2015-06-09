
namespace Problem_3.PC_Catalog
{
    using System;

    class Component : Constants
    {
        private string name;
        private decimal price;
        private string details;

        public Component(string name, decimal price, string details = null)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format("Name {0}", EmptyValErr));
                }

                this.name = value;
            }   
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(String.Format("Price {0}", NegativeValErr));    
                }

                this.price = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format("Details {0}", EmptyValErr));
                }

                this.details = value;
            }
        }
    }
}


namespace Problem_3.PC_Catalog
{
    using System;

    class Component : Constants
    {
        //FIELDS
        private string name;
        private decimal price;
        private string details;

        //CONSTRUCTOR
        public Component(string name, decimal price, string details = null)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details; //(OPTIONAL)
        }

        //PROP NAME
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

        //PROP PRICE
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

        //PROP DETAILS (OPTIONAL)
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

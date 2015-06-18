namespace Problem_3.Company_Hierarchy.Company.Employees.Resources
{
    using System;

    class Sale
    {
        // FIELDS
        private string productName;
        private decimal productPrice;
        private DateTime productDate;

        // CONSTRUCTOR
        public Sale(string name, decimal price, DateTime date)
        {
            this.ProductName = name;
            this.ProductPrice = price;
            this.ProductDate = date;
        }

        // PRODUCT NAME
        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("ProductName", "cannot be NULL or Whitespace.");
                }
                this.productName = value;
            }
        }

        // PRODUCT PRICE
        public decimal ProductPrice
        {
            get { return this.productPrice; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("ProductProce", "cannot be negative value.");
                }
                this.productPrice = value;
            }
        }

        // DATE
        public DateTime ProductDate
        {
            get { return this.productDate; }
            set
            {
                if (value.GetType() != typeof (DateTime))
                {
                    throw new ArgumentException("productDate", "is not valid DateTime format.");
                }
                this.productDate = value;
            }
        }

        // TO STRING
        public override string ToString()
        {
            return String.Format("Product: {0}, Price: {1}, Saled: {2}\r\n", this.productName, this.productPrice, this.productDate);
        }
    }
}

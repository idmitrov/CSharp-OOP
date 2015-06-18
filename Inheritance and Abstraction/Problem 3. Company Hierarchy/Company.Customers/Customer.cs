namespace Problem_3.Company_Hierarchy.Company.Customers
{
    using System;
    using Interfaces;

    class Customer : Person, ICustomer
    {
        // FIELDS
        private decimal netPurchaseAmount;

        // CONSTRUCTOR
        public Customer(string firstName, string lastName, long id, decimal purchaseAmount) 
            : base(firstName, lastName, id)
        {
            this.netPurchaseAmount = purchaseAmount;
        }
        
        // NET PURCHASE AMOUNT
        public decimal NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("NetPurchaseAmount", "cannot be negative value.");
                }
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            string custumerInfo = String.Format("Purchased amountL: {0} EUR", this.netPurchaseAmount);

            return base.ToString() + "\r\n" + custumerInfo;
        }
    }
}

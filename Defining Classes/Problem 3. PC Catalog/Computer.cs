﻿namespace Problem_3.PC_Catalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Computer : Constants
    {
        //FIELDS
        private string name;
        private List<Component> components;
        private decimal price;

        //CONSTRUCTOR
        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
            this.Price = price;
        }

        //PROP NAME
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format("Computer name {0}", EmptyValErr));
                }

                this.name = value;
            }
        }

        //AUTO PROP COMPONENTS
        public List<Component> Components { get; set; }

        //PROP PRICE
        public decimal Price
        {
            get { return this.price; }
            private set
            {
                if (Components.Count < 1)
                {
                    throw new ArgumentException(String.Format("Components {0}", EmptyCollectionError));
                }

                this.price = Components.Sum(component => component.Price); ;
            } 
        }

        //OVERRIDE TO STRING
        public override string ToString()
        {
            string computerInfo = String.Format("Computer name: {0}\r\nComponents:\r\n\r\n", this.name);

            foreach (var component in this.Components)
            {
                computerInfo += String.Format("{0} ({1}) -> {2}лв (BGN)\r\n", component.Name, component.Details, component.Price);
            }

            computerInfo += String.Format("\r\nTotal price: {0}лв (BGN)\r\n", this.Price);

            return computerInfo;
        }
    }
}

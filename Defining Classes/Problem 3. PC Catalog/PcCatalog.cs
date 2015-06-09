/*
•   Define a class Computer that holds name, several components and price. 
    The components (processor, graphics card, motherboard, etc.)
    should be objects of class Component, which holds name, details (optional) and price. 
•	Define several constructors that take different sets of arguments.
    Use proper variable types. Use properties to validate the data.
    Throw exceptions when improper data is entered.
•	Add a method in the Computer class that displays the name, each of the components'
    name and price and the total computer price.
    The total price is the sum of all components' price. Print the prices in BGN currency format.
•	Create several Computer objects, sort them by price, and print them on the console using the created display method.
*/

namespace Problem_3.PC_Catalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PcCatalog
    {
        static void Main()
        {
            //DESKTOP COMPONENTS
            var desktopComponents = new List<Component>()
            {
                new Component("Intel core i7", 499.99M, "Intel 3rd Generation CPU"),
                new Component("Samsung ASDF", 60, "RAM 6GB SAMSUNG KIT"),
                new Component("Samsung ASDF", 60, "RAM 4GB SAMSUNG KIT"),
                new Component("AMD Radeon XXXX", 297.89M, "ATI Grapics cards family"),
                new Component("Realtek ALCXX", 95, "Realtek 7.1 chanel sound card"),
                new Component("SEAGATE", 250, "1TB HDD"),
                new Component("Samsung XYZ", 200, "Samsung 17 FULL HD monitor"),
                new Component("Microsoft standart mouse", 20, "Wireless mouse"),
                new Component("Microsoft standart keyboard", 45, "Wireless keyboard")
            };

            //LAPTOP COMPONENTS
            var laptopComponents = new List<Component>()
            {
                new Component("Intel core i7", 499.99M, "Intel 3rd Generation CPU"),
                new Component("Samsung ASDF", 120, "RAM 8GB SAMSUNG KIT"),
                new Component("Nvidia GeForce XXXX", 300, "Nvidia Grapics cards family"),
                new Component("Realtek ALCXX", 75, "Realtek 5.1 chanel sound card"),
                new Component("Samsung", 200, "750GB HDD"),
                new Component("Standart PnP Monitor", 100, "15.6 monitor"),
                new Component("Synaptics Touchpad", 40, "Touchpad")
            };

            //UILTRABOOK COMPONENTS
            var ultraBookComponents = new List<Component>()
            {
                new Component("Intel core i3", 299.99M, "Intel 3rd Generation CPU"),
                new Component("Samsung ASDF", 60, "RAM 4GB SAMSUNG KIT"),
                new Component("Nvidia GeForce XYZX", 230, "Nvidia Grapics cards family"),
                new Component("Realtek ALCXX", 45, "Realtek 2 chanel sound card"),
                new Component("LG", 100, "500GB HDD"),
                new Component("Standart PnP Monitor", 100, "14 monitor"),
                new Component("Synaptics Touchpad", 40, "Touchpad")
            };

            //PC CATALOG
            var pcCatalog = new List<Computer>()
            {
               new Computer("Desktop PC", desktopComponents),
               new Computer("Laptop", laptopComponents),
               new Computer("Ultrabook", ultraBookComponents)
            };

            //PRINT ALL PC's FROM THE PC CATALOG (ORDERED BY THE PRICE)
            foreach (var device in pcCatalog.OrderBy(x => x.Price))
            {
                Console.WriteLine(device);
            }
        }
    }
}

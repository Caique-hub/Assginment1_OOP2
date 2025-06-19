using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.Write("Enter the item number of an appliance: ");

            // Create long variable to hold item number

            long itemNumber = 0;

            // Get user input as string and assign to variable.

            string input = Console.ReadLine();

            // Convert user input from string to long and store as item number variable.

            long.TryParse(input, out itemNumber);

            // Create 'foundAppliance' variable to hold appliance with item number
            Appliance? foundAppliance = null;
            
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            
            foundAppliance = null;

            // Loop through Appliances
            
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable

            // Break out of loop (since we found what need to)

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."

            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance

            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.

            // Create list to hold found Appliance objects

            // Iterate through loaded appliances
                // Test current appliance brand matches what user entered
                    // Add current appliance in list to found list


            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            Console.WriteLine("Possible options:");

            Console.WriteLine("0 - Any");
            Console.WriteLine("2 - Double doors");
            Console.WriteLine("3 - Three doors");
            Console.WriteLine("4 - Four doors");

            Console.WriteLine("Enter number of doors: ");
            string input = Console.ReadLine();
            short doors;

            if (!short.TryParse(input, out doors) || (doors != 0 && doors != 2 && doors != 3 && doors != 4))
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            List<Appliances> found = new List<Appliances>();

            foreach (var appliance in Appliances)
            {
                if (appliance is Refrigerator refrigerator)
                {
                    if (doors == 0 || refrigerator.Doors == doors)
                    {
                        found.Add(appliance);
                    }
                }
            }
            DisplayApplianceFromList(found, 0);
        }

        public override void DisplayVacuums()
        {
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Residential");
            Console.WriteLine("2 - Commercial");

            Console.Write("Enter grade: ");
            string gradeInput = Console.ReadLine();
            string grade;

            switch (gradeInput)
            {
                case "0":
                    grade = "Any";
                    break;
                case "1":
                    grade = "Residential";
                    break;
                case "2":
                    grade = "Commercial";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - 18 Volt");
            Console.WriteLine("2 - 24 Volt");

            Console.Write("Enter voltage: ");
            string voltageInput = Console.ReadLine();
            short voltage;

            switch (voltageInput)
            {
                case "0":
                    voltage = 0;
                    break;
                case "1":
                    voltage = 18;
                    break;
                case "2":
                    voltage = 24;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            List<Appliances> found = new List<Appliances>();

            foreach (var appliance in Appliances)
            {
                if (appliance is Vacuum vacuum)
                {
                    if ((grade == "Any" || vacuum.Grade == grade) && (voltage == 0 || vacuum.BatteryVoltage == voltage))
                    {
                        found.Add(appliance);
                    }
                }
            }

            DisplayAppliancesFromList(found, 0);
        }
            
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"

            // Write "Enter room type:"

            // Get user input as string and assign to variable

            // Create character variable that holds room type

            // Test input is "0"
                // Assign 'A' to room type variable
            // Test input is "1"
                // Assign 'K' to room type variable
            // Test input is "2"
                // Assign 'W' to room type variable
            // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method
                // return;

            // Create variable that holds list of 'found' appliances

            // Loop through Appliances
                // Test current appliance is Microwave
                    // Down cast Appliance to Microwave

                    // Test room type equals 'A' or microwave room type
                        // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"

            // Write "Enter sound rating:"

            // Get user input as string and assign to variable

            // Create variable that holds sound rating

            // Test input is "0"
                // Assign "Any" to sound rating variable
            // Test input is "1"
                // Assign "Qt" to sound rating variable
            // Test input is "2"
                // Assign "Qr" to sound rating variable
            // Test input is "3"
                // Assign "Qu" to sound rating variable
            // Test input is "4"
                // Assign "M" to sound rating variable
            // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method

            // Create variable that holds list of found appliances

            // Loop through Appliances
                // Test if current appliance is dishwasher
                    // Down cast current Appliance to Dishwasher

                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                        // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            Console.WriteLine("Appliance Types");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 – Refrigerators");
            Console.WriteLine("2 – Vacuums");
            Console.WriteLine("3 – Microwaves");
            Console.WriteLine("4 – Dishwashers");

            Console.Write("Enter type of appliance:");
            string typeInput = Console.ReadLine();

            Console.Write("Enter number of appliances: ");
            string numInput = Console.ReadLine();

            if (!int.TryParse(numInput, out int num) || num < 0)
            {
                Console.WriteLine("Invalid number of appliances.");
                return;
            }

            List<Appliances> found = new List<Appliances>();

            foreach (var appliance in Appliances)
            {
                switch (typeInput)
                {
                    case "0":
                        found.Add(appliance);
                        break;
                    case "1":
                        if (appliance is Refrigerator)
                        {
                            found.Add(appliance);
                        }
                        break;
                    case "2":
                        if (appliance is Vacuum)
                        {
                            found.Add(appliance);
                        }
                        break;
                    case "3":
                        if (appliance is Microwave)
                        {
                            found.Add(appliance);
                        }
                        break;
                    case "4":
                        if (appliance is Dishwasher)
                        {
                            found.Add(appliance);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid appliance type.");
                        return;
                }
            }

            // Randomize the List
            RandomList rng = new Random();
            int n = found.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Appliances value = found[k];
                found[k] = found[n];
                found[n] = value;
            }

            DisplayAppliancesFromList(found, num);
        }
    }
    }
}

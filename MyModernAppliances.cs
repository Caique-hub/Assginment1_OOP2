// MyModernAppliances is the main implementation class for managing appliance operations in the application.
// It provides user-interactive features such as checking out appliances, searching by brand, displaying appliances by type,
// and generating random appliance lists, ensuring all user prompts and outputs match the required specifications.

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

            foreach (Appliance appliance in Appliances)
            {
                // Test appliance item number equals entered item number
                if (appliance.ItemNumber == itemNumber)
                {
                    // Assign appliance in list to foundAppliance variable
                    foundAppliance = appliance;

                   // Break out of loop (since we found what need to)
                    break;
                }
            }
            
            // Test appliance was not found (foundAppliance is null)
            if (foundAppliance == null)
            {
                // Write "No appliances found with that item number."
                Console.WriteLine("No appliances found with that item number.");
                return; // Exit method
            }


            // Otherwise (appliance was found)
            else             {
                // Write "Appliance found: {foundAppliance}"
                Console.WriteLine($"Appliance found: {foundAppliance}");
            }
            // Test found appliance is available
            if (foundAppliance.IsAvailable)
            {
                // Checkout found appliance
                foundAppliance.Checkout();

                // Write "Appliance has been checked out."
                Console.WriteLine("Appliance has been checked out.");
            }
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."
            else
            {
                 Console.WriteLine("The appliance is not available to be checked out."); 
            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.Write("Enter brand to search for: ");
            // Create string variable to hold entered brand
            string brand = null;

            // Get user input as string and assign to variable.
            string input = Console.ReadLine();

            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate through loaded appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test current appliance brand matches what user entered
                if (appliance.Brand.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    // Add current appliance in list to found list
                    found.Add(appliance);
                }
            }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
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
     Console.WriteLine("Possible options: ");

     // Write "0 - Any"
     Console.WriteLine("0 - Any");

     // Write "1 - Kitchen"
     Console.WriteLine("1 - Kitchen");

     // Write "2 - Work site"
     Console.WriteLine("2 - Work site");

     // Write "Enter room type:"
     Console.WriteLine("Enter room type: ");

     // Get user input as string and assign to variable
     string input = Console.ReadLine();

     // Create character variable that holds room type
     char roomType;

     // Test input is "0"
     // Assign 'A' to room type variable
     if (input == "0")
         roomType = 'A';

     // Test input is "1"
     // Assign 'K' to room type variable
     else if (input == "1")
         roomType = 'K';

     // Test input is "2"
     // Assign 'W' to room type variable
     else if (input == "2")
         roomType = 'W';


     // Otherwise (input is something else)

         // Write "Invalid option."
         else
         {
              Console.WriteLine("Invalid Option.");

         // Return to calling method
         // return;
              return;
         }

     // Create variable that holds list of 'found' appliances
     List<Appliance> found = new List<Appliance>();

     // Loop through Appliances
     foreach (Appliance appliance in Appliances)
  

         // Test current appliance is Microwave
             // Down cast Appliance to Microwave
             if (appliance is Microwave microwave)
         {
             // Test room type equals 'A' or microwave room type
             // Add current appliance in list to found list
             if (roomType == 'A' || microwave.RoomType == roomType)
                     {
                         found.Add(appliance);
                     }
         }

     // Display found appliances

     // DisplayAppliancesFromList(found, 0);
     DisplayAppliancesFromList(found, 0);
 }
        /// <summary>
        /// Displays dishwashers
        /// </summary>
public override void DisplayDishwashers()
{
    Console.WriteLine("Possible options:");
    Console.WriteLine("0 - Any");
    Console.WriteLine("1 - Quietest");
    Console.WriteLine("2 - Quieter");
    Console.WriteLine("3 - Quiet");
    Console.WriteLine("4 - Moderate");
    Console.WriteLine("Enter sound rating:");

    string input = Console.ReadLine();
    string soundRating;

    switch (input)
    {
        case "0":
            soundRating = "Any";
            break;
        case "1":
            soundRating = "Qt";
            break;
        case "2":
            soundRating = "Qr";
            break;
        case "3":
            soundRating = "Qu";
            break;
        case "4":
            soundRating = "M";
            break;
        default:
            Console.WriteLine("Invalid option.");
            return;
    }

    List<Appliance> found = new List<Appliance>();

    foreach (Appliance appliance in Appliances)
    {
        if (appliance is Dishwasher dishwasher)
        {
            if (soundRating == "Any" || dishwasher.SoundRating == soundRating)
            {
                found.Add(dishwasher);
            }
        }
    }

    DisplayAppliancesFromList(found, 0);
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

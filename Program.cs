using ShippersContext;

namespace UWS_InternetScripting_Week3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--WEEK 3 EXERCISES--");  //TODO: Add week date
        Console.WriteLine("Please select from the following options to view the exercise outcome:");
        Console.WriteLine("1: View Shippers");  //TODO: Add Exercise name here
        Console.WriteLine("2: NAME_HERE");  //TODO: Add Exercise name here
        Console.WriteLine("3: NAME_HERE");  //TODO: Add Exercise name here
        Console.WriteLine("4: NAME_HERE");  //TODO: Add Exercise name here
        Console.WriteLine("5: Quit");
        Console.WriteLine("Created by: Aaron Hamilton | Banner ID:B00869530");
        Console.WriteLine("");
        Console.Write("Select an option: ");
        String choice = Console.ReadLine();

        if (choice == "1")
        {
            Exercise1();
        } else if (choice == "2")
        {
            Exercise2();
        }else if (choice == "3")
        {
            Exercise3();
        }else if (choice == "4")
        {
            Exercise4();
        }else if (choice == "5")
        {
            AnyKeyQuit();
        }

        static void Exercise1()
        {
            Console.WriteLine("View all of the information contained within the 'Shippers' table.");
            Console.WriteLine();
            
            ShippersDatabase db = new ShippersDatabase();


            List<Shipper> shippers = db.Shippers.ToList();

            foreach (Shipper shipper in shippers)
            {
                Console.WriteLine($"{shipper.ShipperID}: {shipper.ShipperName} | Number: {shipper.Phone}");
            }
            AnyKeyQuit();
        }

        static void Exercise2()
        {
            //TODO: Add Exercise here
            AnyKeyQuit();
        }

        static void Exercise3()
        {
            //TODO: Add Exercise here
            AnyKeyQuit();
        }
        
        static void Exercise4()
        {
            //TODO: Add Exercise here
            AnyKeyQuit();
        }

        static void AnyKeyQuit()
        {
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}

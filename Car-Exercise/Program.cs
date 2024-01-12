
using Car_Exercise;
using System.Runtime.Intrinsics.X86;
MyDbContext context = new MyDbContext();
CrudsOperations operations = new CrudsOperations(context);

//operations.CreateCarData();
//operations.GetCarData();
Print print = new Print();

while (true)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(">> ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Welcome CRUDS operations ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(">> ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("you have currently ( ");
    Console.ForegroundColor = ConsoleColor.Blue; Console.Write(operations.GetNumberOfCars());  // print the total number of cars in db
   
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" )Cars on your DataBase.");
    Console.ForegroundColor = ConsoleColor.White;

    // Print the main Choices from class print
    print.mainChoices();

    string mainChoice = Console.ReadLine();

    switch (mainChoice)
    {
        case "1":
            operations.CreateCarData();
                           

            break;
        case "2":

            operations.GetCarData();
            break;
        case "3":
            operations.UpdateCarData();
            break;
        case "4":

            operations.DeleteCarData();
            break;
        case "5":
            operations.UpdateCarData();
            Environment.Exit(0);              // to close the program

            break;
        default:                            // error message if enter invaled value
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}



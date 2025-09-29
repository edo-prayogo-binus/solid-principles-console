using solid_principles_console.Services;

class Program
{
    #region general
    readonly static string _rootPathSharedFiles = AppDomain.CurrentDomain.BaseDirectory;
    readonly static DirectoryInfo _dir = new DirectoryInfo(_rootPathSharedFiles);
    readonly static string _rootFolder = _dir?.Parent?.Parent?.Parent?.Parent?.Parent?.FullName ?? throw new InvalidOperationException("Root path not found.");
    readonly static string _rootPathFolderShared = Path.Combine(_rootFolder, "shared", "files");
    #endregion

    static void Main(string[] args)
    {
        ChoosePrinciles();
    }

    #region helpers


    private static void ChoosePrinciles()
    {
        Console.WriteLine("Choose a principle to demonstrate:");
        Console.WriteLine("1. Single Responsibility Principle (SRP)");
        Console.WriteLine("2. Open/Closed Principle (OCP)");
        Console.WriteLine("3. Liskov Substitution Principle (LSP)");
        Console.WriteLine("4. Interface Segregation Principle (ISP)");
        Console.WriteLine("5. Dependency Inversion Principle (DIP)");
        Console.Write("Enter the number of the principle (1-5): ");
        var choice = Console.ReadLine();
        Console.WriteLine(choice);
        switch (choice)
        {
            case "1":
                OptionPrinciples.SingleResponsibilityPrinciple(_rootPathFolderShared);
                ChoosePrinciplesAgain();
                break;
            case "2":
                OptionPrinciples.OpenClosedPrinciple();
                ChoosePrinciplesAgain();
                break;
            case "3":
                OptionPrinciples.LiskovSubstitutionPrinciple();
                ChoosePrinciplesAgain();
                break;
            case "4":
                OptionPrinciples.InterfaceSegregationPrinciple();
                ChoosePrinciplesAgain();
                break;
            case "5":
                // DependencyInversionPrinciple();
                ChoosePrinciplesAgain();
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                break;
        }
    }

    private static void ChoosePrinciplesAgain()
    {

        Console.Write("Do you want to choose another principle? (y/n): ");
        var again = Console.ReadLine();
        Console.Clear();
        if (again?.ToLower() == "y")
        {
            ChoosePrinciles();
        }
        else
        {
            Console.WriteLine("Exiting the program. Goodbye!");
        }
    }

    #region option 

    #endregion

    #endregion
}


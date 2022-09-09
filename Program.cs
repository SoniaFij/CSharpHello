// Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Congrats!\n");
        Console.Write("The first lines of code work!\n");
        Console.WriteLine("This is the first line");
        Console.WriteLine("This is the second line");
        Console.WriteLine("Additional\twhitespace"); // \t
        Console.WriteLine("\"Nested\" quotation"); // \"string\"
        Console.WriteLine("c:\\source\\repos"); // to use a backslash as a string use \\

        //Format the output of the command-line application using character escape sequences

        Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
        Console.WriteLine("Invoice: 1021\t\tComplete!");
        Console.WriteLine("Invoice: 1022\t\tComplete!");
        Console.WriteLine("\nOutput Directory:\t");

        Console.WriteLine(@"    c:\source\repos
    (""this is where your code goes"")");


        Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");


        // To generate Japanese invoices:
        // Nihon no seikyū-sho o seisei suru ni wa:
        Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
        Console.WriteLine(@"c:\invoices\app.exe -j");

        string firstName = "Czesław";
        string greeting = "Cześć, ";
        string message = greeting + firstName + "!\n";
        Console.WriteLine(message);

        string message2 = $"{greeting} {firstName}!";
        Console.WriteLine(message);

        string projectName1 = "First-Project";
        Console.WriteLine($@"C:\Output\{projectName1}\Data");


        string projectName = "ACME";
        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";






    }
}
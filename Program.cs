namespace ConsoleApp1;
class Program
{
    static void Main()
    {
        /*
        Console.Write("Enter name -> ");
        string name = Console.ReadLine();
        Console.Write("Enter age -> ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter weight -> ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Name: {name}\nAge: {age}\nWeight: {weight}");
        */

        /*
        byte a = 4;
        byte b = (byte)(a + 70);

        int A = 600;
        byte B = (byte)A;
        Console.WriteLine(B);

        var result = Math.Pow(2, 10);

        Console.WriteLine(1.0 / 0.0);
        Console.WriteLine(0.0 / 0.0);

        int x = 5, y = 10;
        (x, y) = (y, x);
        Console.WriteLine($"x = {x}\ny = {y}");

        Console.WriteLine(Convert.ToInt32(1.5));//2
        Console.WriteLine(Convert.ToInt32(2.5));//2

        int z = 0;
        if (int.TryParse(Console.ReadLine(), out z))
        {
            Console.WriteLine("Good - " + z);
        }
        else
        {
            Console.WriteLine("Error!");
        }
        */

        //First Practice
        /* //No 1
        Console.Write("Shop name -> ");
        string Name = Console.ReadLine();
        Console.Write("Securety count -> ");
        int SecureCount = Convert.ToInt32(Console.ReadLine());
        Console.Write("Securety cams count -> ");
        int SecureCamCount = Convert.ToInt32(Console.ReadLine());
        Console.Write("Is there card payment -> ");
        string CardPayment = Console.ReadLine();
        Console.Write("Carts count -> ");
        int CartCount = Convert.ToInt32(Console.ReadLine());
        Console.Write("Logo's color -> ");
        string LogoColor = Console.ReadLine();
        Console.Write("Average price -> ");
        double AveragePrice = Convert.ToDouble(Console.ReadLine());
        */

        //No 2
        short a = 350;
        int b = 3500;

        b += (short)a;
        Console.WriteLine($"Short -> {b}");
    }
}
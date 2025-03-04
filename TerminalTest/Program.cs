using System.Numerics;

namespace TerminalTest;

class Program
{
  static void Main(string[] args)
  {
    // string projectName = "ACME";
    // string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

    // Console.WriteLine("View English output:\n\t"
    //  + $@"c:\Exercise\{projectName}\data.txt" +
    //   "\n"
    //   + russianMessage
    //   + ":" + "\n\t"
    //   + $@"c:\Exercise\{projectName}\ru-Ru\data.txt");

    while (true)
    {
      Console.WriteLine("\nConverting Fahrenheit to Celsius:\n Input Fahrenheit below.");
      string fahrenheitString = Console.ReadLine();
      if (decimal.TryParse(fahrenheitString, out decimal fahrenheit))
      {

        decimal celsius = (fahrenheit - 32m) * (5m / 9m);
        Console.WriteLine($"{fahrenheit} Fahrenheit converts to {celsius} Celsius.");
        break;
      }
      else
      {
        Console.WriteLine("Unknown error; please try again.");
      }
      ;



      // if(){
      //   Console.WriteLine(celsius);
      //   break;
      // }


    }
    ;


    //mathoperations

    // int value = 1;
    // value++;
    // Console.WriteLine("First: " + value);
    // Console.WriteLine($"Second: {value++}");
    // Console.WriteLine("Third " + value);
    // Console.WriteLine("Fourth: " + (++value));


    // int value = 1;

    // value = value + 1;
    // Console.WriteLine("First increment: " + value);

    // value += 1;
    // Console.WriteLine("Second increment: " + value);
    // value++;
    // Console.WriteLine("First increment: " + value);
    // value = value - 1;
    // Console.WriteLine("First increment: " + value);
    // value -= 1;
    // Console.WriteLine("First increment: " + value);
    // value--;
    // Console.WriteLine("First increment: " + value);


    // decimal decimalQuotient = 7.0m / 5;
    // Console.WriteLine($"Decimal Quotient: {decimalQuotient}");

    // int firstNumber = 7;
    // int secondNumber = 5;
    // decimal sum = firstNumber / secondNumber;
    // Console.WriteLine($"The first sum is equal to {sum}.");
    // decimal sum2 = (decimal)firstNumber / (decimal)secondNumber;
    // Console.WriteLine($"The second sum is equal to {sum2}.");
    // Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
    // Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
    //         int sum = 7 + 5;
    //         int difference = 7 - 5;
    //         int product = 7 * 5;
    //         int quotient = 7 / 5;

    //         Console.Write("\n");
    //         Console.WriteLine("Sum: " + sum);
    //         Console.WriteLine("Difference: " + difference);
    //         Console.WriteLine("Product: " + product);
    //         Console.WriteLine("Quotient: " + quotient);
  }
}

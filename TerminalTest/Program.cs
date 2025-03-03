namespace TerminalTest;

class Program
{
    static void Main(string[] args)
    {
        string projectName = "ACME";

        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

        Console.WriteLine("View English output:\n\t"
         + $@"c:\Exercise\{projectName}\data.txt" +
          "\n"
          + russianMessage
          + ":" + "\n\t"
          + $@"c:\Exercise\{projectName}\ru-Ru\data.txt");
        //         You may only use either the Console.WriteLine() or the Console.Write() method twice.
        //         Use character escape sequences, verbatim strings, unicode, and string interpolation to generate the output.
        //         View English output:
        //     c:\Exercise\ACME\data.txt

        //   Посмотреть русский вывод:
        //   c:\Exercise\ACME\ru - RU\data.txt
    }
}

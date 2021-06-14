using System;

namespace ConsoleApp2
{
    class Program 
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Please choose LED to turn On/Off: ");
        int day = Convert.ToInt32(Console.ReadLine());
       

            switch (day)
        {
            case 1:
                Console.WriteLine("[!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] ");
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");
                break;
            case 2:
                Console.WriteLine("[ ] [!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] ");
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");
                break;
            case 3:
                Console.WriteLine("[ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ] [ ]");
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");
                break;
            case 4:
                Console.WriteLine("[ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ]");
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");
                break;
            case 5:
                Console.WriteLine("[ ] [ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ]");
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");
                break;
            case 6:
                Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [!] [ ] [ ] [ ] [ ]");
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");
                break;
            case 7:
                Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [!] [ ] [ ] [ ]");
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");
                break;
            case 8:
                Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [!] [ ] [ ]");
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");
                break;
            case 9:
                Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!] [ ]");
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");
                break;  
            case 10:
                Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!]");
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");
                break;  
            
        }
    }
    }
}

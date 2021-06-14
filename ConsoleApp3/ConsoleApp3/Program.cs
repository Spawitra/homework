using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input nuber 0-10: ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 0:
                    Console.WriteLine(x + "= ศูนย์");

                    break;
                case 1:
                    Console.WriteLine(x + "= หนึ่ง");

                    break;
                case 2:
                    Console.WriteLine(x + "= สอง");

                    break;
                case 3:
                    Console.WriteLine(x + "= สาม");

                    break;
                case 4:
                    Console.WriteLine(x + "= สี่");

                    break;
                case 5:
                    Console.WriteLine(x + "= ห้า");

                    break;
                case 6:
                    Console.WriteLine(x + "= หก");

                    break;
                case 7:
                    Console.WriteLine(x + "= เจ็ด");

                    break;
                case 8:
                    Console.WriteLine(x + "= แปด");

                    break;
                case 9:
                    Console.WriteLine(x + "= เก้า");

                    break;
                case 10:
                    Console.WriteLine(x + "= สิบ");

                    break;
            }
            }
    }
}

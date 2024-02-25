using System;
using System.Xml.Serialization;

internal class Tasks
{
    public static void FirstTask()
    {
        int number;
        Console.Write("Enter number:\n >>> ");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number % 15 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }    
        }
    }
    public static void SecondTask()
    {
        int value, percent;
        Console.Write("Enter first number:\n >>> ");
        if (int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Enter second number:\n >>> ");
            if (int.TryParse(Console.ReadLine(), out percent))
            {
                Console.WriteLine(value / 100.0 * percent);
            }
        }
    }
    public static void ThirdTask()
    {
        int first, second, third, fourth;
        Console.Write("Enter number:\n >>> ");
        if (int.TryParse(Console.ReadLine(), out first))
        {
            Console.Write("Enter number:\n >>> ");
            if (int.TryParse(Console.ReadLine(), out second))
            {
                Console.Write("Enter number:\n >>> ");
                if (int.TryParse(Console.ReadLine(), out third))
                {
                    Console.Write("Enter number:\n >>> ");
                    if (int.TryParse(Console.ReadLine(), out fourth))
                    {
                        Console.WriteLine(first * 1000 + second * 100 + third * 10 + fourth);
                    }
                }
            }
        }
    }
    public static void FourthTask()
    {
        string number;
        int first, second;
        Console.Write("Enter number:\n >>> ");
        number = Console.ReadLine();
        Console.Write("Enter first parameter:\n >>> ");
        if (int.TryParse(Console.ReadLine(), out first))
        {
            Console.Write("Enter second parameter:\n >>> ");
            if (int.TryParse(Console.ReadLine(), out second))
            {
                if (number.Length == 6 && first > 0 && first < 7 && second > 0 && second < 7)
                {
                    char[] number_c = number.ToCharArray();
                    var temp = number_c[first - 1];
                    number_c[first - 1] = number_c[second - 1];
                    number_c[second - 1] = temp;
                    Console.WriteLine(number_c);
                }
                else
                {
                    Console.WriteLine("Bad input");
                }
            }
        }
    }
    public static void FifthTask()
    {
        DateTime date = new DateTime();
        Console.Write("Enter date (MM.DD.YYYY):\n >>> ");
        if (DateTime.TryParse(Console.ReadLine(), out date))
        {
            string season;
            switch (date.Month)
            {
                case 12:
                case 1:
                case 2:
                    season =  "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    season = "";
                    break;
            }
            string dayOfWeek = date.ToString("dddd");

            Console.WriteLine($"{season} {dayOfWeek}");
        }
    }
    public static void SixthTask()
    {
        Console.Write("Enter temperature:\n >>> ");
        int temperature;
        if (int.TryParse(Console.ReadLine(), out temperature))
        {
            Console.WriteLine("Choose:");
            Console.WriteLine("1: F° -> C°");
            Console.Write("2: C° -> F°\n >>> ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1)
                {
                    Console.WriteLine((temperature - 32) * 5 / 9);
                }
                else if (choice == 2)
                {
                    Console.WriteLine(temperature * 9 / 5 + 32);
                }
                else
                {
                    Console.WriteLine("Bad input");
                }
            }
        }
    }
    public static void SeventhTask()
    {
        int begin, end;
        Console.Write("Enter begin:\n >>> ");
        if (int.TryParse(Console.ReadLine(), out begin))
        {
            Console.Write("Enter end:\n >>> ");
            if (int.TryParse(Console.ReadLine(), out end))
            {
                if (begin > end)
                {
                    int temp = begin;
                    begin = end;
                    end = temp;
                }
                for (int i = begin; i < end; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}

using System;

internal class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        Console.WriteLine("Цвет:\n" +
            "1)Зеленый\n" +
            "2)Синий\n" +
            "3)Желтый\n" +
            "4)Голубой\n" +
            "5)Красный\n" +
            "6)Magenta\n" +
            "7)Тёмно-синий\n" +
            "8)Тёмно-голубой\n" +
            "9)Тёмно-красный\n\n");
        int numOfColor = int.Parse(Console.ReadLine());
        StringWithColor.Print(str, numOfColor);

        Console.ReadKey();
    }
}

static class StringWithColor
{
    public static void Print(string str, int num)
    {
        ConsoleColor colour = Color(num);
        Console.ForegroundColor = colour;
        Console.WriteLine(str);
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public static ConsoleColor Color(int num)
    {
        if (Enum.IsDefined(typeof(ColorEnum), num))
        {
            return (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Enum.GetName(typeof(ColorEnum), num));
        }
        else
        {
            return ConsoleColor.Gray;
        }
    }
}
enum ColorEnum : int
{
    Green = 1,
    Blue = 2,
    Yellow = 3,
    Cyan = 4,
    Red = 5,
    Magenta = 6,
    DarkBlue = 7,
    DarkCyan = 8,
    DarkRed = 9
}

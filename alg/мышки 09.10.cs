using System;
using System.Text;

class Program
{
    static int FindLastEatenMouse(int totalMice, int catStep, int whiteMousePosition)
    {
        int[] mice = new int[totalMice];
        for (int i = 0; i < totalMice; i++)
        {
            mice[i] = i + 1;
        }

        int catIndex = 0;

        while (mice.Length > 1)
        {
            catIndex = (catIndex + catStep - 1) % mice.Length;

            int[] newMice = new int[mice.Length - 1];
            for (int i = 0, j = 0; i < mice.Length; i++)
            {
                if (i != catIndex)
                {
                    newMice[j++] = mice[i];
                }
            }

            mice = newMice;
        }

        if (mice[0] == whiteMousePosition)
        {
            return -1;
        }
        else
        {
            return mice[0];
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Введите общее количество мышей: ");
        int totalMice = int.Parse(Console.ReadLine());

        Console.Write("Введите шаг, с которым кот ест мышь: ");
        int catStep = int.Parse(Console.ReadLine());

        Console.Write("Введите позицию белой мыши: ");
        int whiteMousePosition = int.Parse(Console.ReadLine());

        int result = FindLastEatenMouse(totalMice, catStep, whiteMousePosition);

        if (result == -1)
        {
            Console.WriteLine("Вы правильно указали позицию белой мыши");
        }
        else
        {
            Console.WriteLine($"Последняя съеденная мышь имеет номер: {result}");
        }
    }
}
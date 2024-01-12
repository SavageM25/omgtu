using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("Введите кол-во городов");
    int numberOfcities = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное расстояние от города до заправки");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] cities = new int [numberOfcities];
    int minSumm= Int32.MaxValue;
    int minPosition = 0;
    
    for (int i = 0; i < numberOfcities; i++)
    {
        cities[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    for (int i = 0; i < numberOfcities - 1; i++)
    {
        for (int j = cities[i] + m; j < cities[i+1] - m + 1; j++)
        {
            int summ = 0;
            for (int h = 0; h < numberOfcities; h++)
            {
                summ += Math.Abs(cities[h] - j);
            }
            if (summ < minSumm)
            {
                minSumm = summ;
                minPosition = j;
            }
        }
    }
    if (minSumm == Int32.MaxValue)
    {
        Console.WriteLine("Заправку м/у городами поставить нельзя.");
    }
    else 
    {
        Console.WriteLine("Минимальная возможная сумма путей: " + minSumm);
        Console.WriteLine("Значение позиции: " + minPosition);
    }
  }
}
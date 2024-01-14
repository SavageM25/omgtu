using System;
class Program
{
static void Main()
{
Random number = new Random();
int N = number.Next(0,1000);

int random_num = number.Next(N+1);

Console.WriteLine($"Программа выбрала с помощью датчика случайное число от 0 до {N}. Попробуй угадать)");

int attempt = number.Next(10,40);

Console.WriteLine();

Console.WriteLine($"У тебя есть {attempt} попыток");

Console.WriteLine();

int cnt = 1;

int your_num = -1;

for (int i = attempt; i > 0; i--, cnt++)
{

Console.WriteLine("-----------------------------------");

Console.WriteLine($"У тебя осталось {i} попыток");

your_num = Convert.ToInt32(Console.ReadLine());

if (your_num == random_num)
{
Console.WriteLine();
Console.WriteLine($"Ура!!! Вы смогли угадать число за {cnt} попыток");
break;

}

else if (your_num < random_num)
{
Console.WriteLine("Слишком мало. Возьмите побольше.");
}

else
{
Console.WriteLine("Слишком много. Возьмите поменьше.");
}

if (i - 1 == 0)
{
Console.WriteLine();
Console.WriteLine($"Увы, вы не смогли угадать число за {attempt} попыток.");
cnt--;
}
}

while (your_num != random_num)
{

Console.WriteLine("-----------------------------------");

your_num = Convert.ToInt32(Console.ReadLine());

if (your_num == random_num)
{
Console.WriteLine();
Console.WriteLine($"Ура!!! Вы смогли угадать число за {cnt+1} попыток");
break;
}
else if (your_num < random_num)
{
Console.WriteLine("Слишком мало. Возьмите побольше.");
}
else
{
Console.WriteLine("Слишком много. Возьмите поменьше.");
}
cnt++;

Console.WriteLine($"Вы уже потратили {cnt} попыток");

}

}
}
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int i = 100;
int countZero = 0;
if (number >= 100)
{
    while (i < number)
    {
        countZero = i;
        i *= 10;
    }

    int x = countZero / 100;
    int x1 = number / x;
    Console.WriteLine(x1 % 10);

}


else
{
    Console.WriteLine("Неподходящее число, нет третьей цифры");
}
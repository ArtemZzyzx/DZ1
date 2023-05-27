/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int tretteNumber = Convert.ToInt32(Console.ReadLine());
int max = 1;
if (firstNumber > secondNumber)
{
    max = firstNumber;
}
else
{
    max = secondNumber;
}
if (tretteNumber > max)
{
    Console.WriteLine("Число " + tretteNumber + " является максимальным");
}
else
{
    Console.WriteLine("Число " + max + " является максимальным");
}
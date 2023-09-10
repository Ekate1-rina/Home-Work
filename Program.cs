//Задание №1. Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
//645->5
//78 -> третьей цифры нет 
//32679 -> 6

Console.Write("Введите число:");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num < 99)
{
    Console.WriteLine("Отсутствует третья цифра, необходимо ввести корректное число ");
}

else
{
    while (num > 999)
    
     {
        num = num / 10;
        }
        num = num % 10;
        Console.WriteLine(num);
    
}

// Задание №2. Напишите программу, которая принимает на вход цифру, обозначающую день 
//  недели, и проверяет, является ли этот день выходным.
// 6->да 7->да 1->нет


Console.Write("Введите число:");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num >= 6 && num < 8)
{
Console.WriteLine("Да, выходной день");
}
else
{

    Console.WriteLine("Нет, рабочий день");
}

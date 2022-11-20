// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("введите первое число, пожалуйста) >>");
string FirstInput = Console.ReadLine();
int val1= Convert.ToInt32(FirstInput);
Console.WriteLine("Класс! Теперь введите второе число >>");
string SecondInput = Console.ReadLine();
int val2= Convert.ToInt32(SecondInput);

if (val1>val2)
{ Console.WriteLine($" Мы долго думали и решили, что {val1} больше, чем {val2}");}
else Console.WriteLine($" Мы долго думали и решили, что {val2} больше, чем {val1}");


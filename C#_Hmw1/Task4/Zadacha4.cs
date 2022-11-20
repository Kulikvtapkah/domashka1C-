// Задача 4: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N, пожалуйста) >>");
string FirstInput = Console.ReadLine();
int val= Convert.ToInt32(FirstInput);

int test= 2;

if (val<2)
 Console.WriteLine("Хмм, похоже, нечего выводить..."); 
else  
{Console.WriteLine("Положительные четные числа <=N:");
Console.Write("2");
test+=2;
 while (test<=val)
{Console.Write(", " + test);
test+=2;}
Console.Write("."); 
}
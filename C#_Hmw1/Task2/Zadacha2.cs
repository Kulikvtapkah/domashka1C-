// Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("ОК, нужно 3 числа, поехали!");
Console.WriteLine("введите первое число, пожалуйста) >>");
string FirstInput = Console.ReadLine();
int val1= Convert.ToInt32(FirstInput);

Console.WriteLine("Класс! Теперь введите второе число >>");
string SecondInput = Console.ReadLine();
int val2= Convert.ToInt32(SecondInput);

Console.WriteLine("Отлично справляетесь! Наконец третье число >>");
string ThirddInput = Console.ReadLine();
int val3= Convert.ToInt32(ThirddInput);

int max=val1;
if (val1>val2)
  {if (val1>val3) max = val1;
   else max = val3;}
else  
   {if (val2>val3) max = val2;
   else max = val3;} 

Console.WriteLine($" Ого! Похоже, что {max} больше всех!");


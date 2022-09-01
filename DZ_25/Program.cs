// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int StepNumber(int num1, int num2)
{

   double pow = Math.Pow (num1,num2);
   return Convert.ToInt32(pow);
}


Console.WriteLine(StepNumber(num1, num2));

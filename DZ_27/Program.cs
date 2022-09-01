// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    
    int Length = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < Length; i++)
    {
        advance = number - number % 10; 
        result = result + (number - advance);
        number = number / 10;
    }
    return result;
}

Console.WriteLine(SumNumber(num));


// int num = 4 - 4 % 10; //450 0
// int num2 = 7 + (4 - 0); //2 7
// int num3 = 45/10;//45 4
// Console.WriteLine(num3);


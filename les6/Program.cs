//  Напишите программу, которая принимает 
//  на вход три числа и выдаёт максимальное 
//  из этих чисел.
 Console.Clear();
Console.WriteLine("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max)
{
    max = number2;
}

if (number3 > max)
{
    max = number3;
}
Console.WriteLine("вуаля , ваше максимальное число " + max );

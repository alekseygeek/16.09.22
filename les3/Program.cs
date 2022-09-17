// Чётные числа задача 6
Console.Clear();
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if ( a % 2 == 1)
{
    Console.WriteLine("Число : " + a + " не чётное");
}
else
{
     Console.WriteLine("Число : " + a + " чётное");
}

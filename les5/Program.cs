// программа находит чётные числа , задача 8
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
Console.WriteLine("Чётные числа от 1 до " + num);
while (count <= num)
{
    Console.Write($"{count}");
    count = count + 2;
}  

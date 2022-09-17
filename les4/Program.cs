// какое большее какое меньшее
Console.WriteLine("Введите число А");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
Console.Write(" большее число = " + num_A);
}
{
Console.Write(" меньшее  число = " + num_B);
}

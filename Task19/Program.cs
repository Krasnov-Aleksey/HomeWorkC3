// Нахождени полиндрома
Console.Clear();
Console.Write("Введите 5-ти значное число: ");
int namber = int.Parse(Console.ReadLine()!);
if (namber/10000==namber%10 && namber/1000%10==namber/10%10)
{
    Console.WriteLine($"Число {namber} является полиндромом");
}
else
{
     Console.WriteLine($"Число {namber} не является полиндромом");
}

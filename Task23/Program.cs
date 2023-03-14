Console.Clear();
Console.Write("Введите число: ");
double number=Convert.ToDouble(Console.ReadLine());
double numberCube;
for (int index =1; index<=number;index++)
{
    numberCube=Math.Pow(index,3);
    Console.WriteLine($"Число {index} в кубе = {numberCube}");
}

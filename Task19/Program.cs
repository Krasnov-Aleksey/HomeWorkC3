// Нахождени полиндрома
Console.Clear();
Console.Write("Введите 5-ти значное число: ");
int namber = int.Parse(Console.ReadLine()!);
// int sym1=namber/10000;
// int sym5=namber%10;
// int sym2=namber/1000%10;
// //sym4=sym4%10;
// int sym4=namber/10%10;

if (namber/10000==namber%10 && namber/1000%10==namber/10%10)
{
    Console.WriteLine($"Число {namber} является полиндромом");
}
else
{
     Console.WriteLine($"Число {namber} не является полиндромом");
}
// Console.WriteLine(sym1);
// Console.WriteLine(sym5);
// Console.WriteLine(sym2);
// Console.WriteLine(sym4);

//string str = namber.ToString();
//Console.WriteLine(namber);
// int i = 10;
// string str = i.ToString();
// Console.WriteLine(str);
//Console.WriteLine(Convert.ToInt32(s[0].ToString())*10);
// int sum=0;
// sum=sum+int.Parse(s[i].ToString());


//int namber = int.Parse(Console.ReadLine()!);
//Console.WriteLine(Convert.ToInt32(namber[0].ToString()*0)*10);
//int sym = int.Parse(namber[1].ToString());
// for(int index=0;index<5;index++)
// {
//     if (namber[0]==namber[4])
//     //Console.WriteLine(namber[index]);
// }
// if (namber[0]==namber[4])
// {
//     Console.WriteLine("Да");
// }
//Console.WriteLine();
//Console.WriteLine(s);

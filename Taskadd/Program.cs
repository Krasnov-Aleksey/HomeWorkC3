//Кусты черники
Console.Clear();
int bush =4;
int [] berry=new int[bush];
int sumBerry=0;
int index=0;

while(index<berry.Length)
{
    berry[index]=new Random().Next(1,10);
    Console.Write(berry[index]);
    index++;
}
sumBerry=berry[bush-1]+berry[bush-2]+berry[bush-3];

Console.WriteLine();
Console.Write(sumBerry);


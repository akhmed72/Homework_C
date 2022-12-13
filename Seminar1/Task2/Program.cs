// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите 1-ое число > ");
string inputValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1); 
Console.WriteLine("Введите 2-ое число > ");
string inputValue2 = Console.ReadLine();
int value2 = Convert.ToInt32(inputValue2); 
Console.WriteLine("Введите 3-ое число > ");
string inputValue3 = Console.ReadLine();
int value3 = Convert.ToInt32(inputValue3); 

if(value1 > value2)
{
    if(value1 > value3)
    {
        Console.WriteLine("max= " + value1);
    }
    else
    {
        Console.WriteLine("max= " + value3);
    }
}
else if(value2 > value3)
{
    Console.WriteLine("max= " + value2);
}
else
{
    Console.WriteLine("max= " + value3);
}
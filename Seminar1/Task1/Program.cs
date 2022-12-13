// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите 1-ое число > ");
string inputValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1); 
Console.WriteLine("Введите 2-ое число > ");
string inputValue2 = Console.ReadLine();
int value2 = Convert.ToInt32(inputValue2); 

if(value1 > value2)
{
    Console.WriteLine("max=" + value1 + " min=" + value2);
}
else
{
    Console.WriteLine("min=" + value1 + " max=" + value2);
}
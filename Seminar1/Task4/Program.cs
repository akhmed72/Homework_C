// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N > ");
string inputValue = Console.ReadLine();
int N = Convert.ToInt32(inputValue);

int unN = 1;

while(unN <= N)
{
    if(unN%2 == 0)
    Console.Write( unN + " ");
    unN=unN+1;
}

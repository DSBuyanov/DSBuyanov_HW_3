// Напишите программу, которая на вход принимает
// число и выдает, является ли число четным (делится ли оно на
// два без остатка).

Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine());


if ((N%2) == 0)
 {
   Console.WriteLine("да");
   }
else
    {
       Console.WriteLine("нет");
    }
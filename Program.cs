// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNums(int num)
{
 if(num >= 1) 
 {
   Console.Write(num +  " ");
   ShowNums(num-1); 
 }
}
Console.Write("Enter number: ");
ShowNums(Convert.ToInt32(Console.ReadLine()));
*/ 
//====================================================================================================
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
double SumNums(int num1, int num2)
{
if(num1!= num2)  
    return num1 + SumNums(num1+1,num2);
else
   return num1;
}
Console.Write("Enter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write(SumNums(number1, number2));
*/
//================================================
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
int Akkerman(int number1, int number2)
{
if(number1 == 0)
    return number2 + 1;
if(number2 == 0)
    return Akkerman(number1 - 1, 1);
else 
    return Akkerman(number1 - 1, Akkerman(number1, number2 - 1)); 
}
Console.Write("Enter number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({numberM}, {numberN}) = {Akkerman(numberM, numberN)}");
*/

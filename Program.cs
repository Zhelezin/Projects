
//Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а
//какое меньшее.

/* Console.WriteLine("Enter nunber:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b)
{

Console.WriteLine(a);

}
else Console.WriteLine(b); */



//Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел


/* Console.WriteLine("Enter nunber:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());


if (a > b && a > c)

{

Console.WriteLine(a);
}

else if (b > a && b > c)
{
Console.WriteLine(b);
}

else 
{
Console.WriteLine(c);

}
 */

 //Напишите программу, которая на вход
//принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).

/* Console.WriteLine("Enter nunber:");
int a = int.Parse(Console.ReadLine());

if (a %2 == 0)
{

Console.WriteLine("Yes");

}
else Console.WriteLine("No");  */

//Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все чётные
//числа от 1 до N

/* Console.WriteLine("Enter nunber:");
int a = int.Parse(Console.ReadLine());
int i = 2;
while (i <= a)
{

    Console.Write(i +  " "); 
i+=2;
} */



//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
/* 
int a = new Random().Next(100, 1000);

Console.WriteLine(a);

int num1 = a % 100;
int num2 = num1 / 10;

Console.WriteLine(num2); */


//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

/* 
Console.WriteLine("Enter number: ");
int a = int.Parse(Console.ReadLine());
if (a <=0 || a > 7)

{
    Console.WriteLine("Такого дня недели нет");
}

else if (a<6)
{
    Console.WriteLine("Выходного нет");

}
else if (a == 6)

{
Console.WriteLine("Выходной");

}

else if (a == 7)

{
Console.WriteLine("Выходной");

} */
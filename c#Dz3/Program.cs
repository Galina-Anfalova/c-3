/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Через строку решать нельзя.

14212 -> нет
12821 -> да
23432 -> да*/

/*Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");*/


//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*void Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
  
 double n = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 -z2));

  Console.WriteLine($"Расстояние составляет {n}");
}

Console.WriteLine("Введите координату х1 и у1 и z1");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату х2 и у2 и z2");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

Distance(x1, y1, z1, x2, y2, z2);*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125*/

/*Console.WriteLine("Введите натуральное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x;
string res = $"{x}-> ";
for (int i = 1; i <= x1; i++)
{
    int tmp = i * i * i;
    res += $"{tmp} ";
}
Console.WriteLine(res);*/

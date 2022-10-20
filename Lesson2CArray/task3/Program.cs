
// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y).

void ShowRange(int quart)
{
    if(quart == 1)
       Console.WriteLine("x > 0 and y > 0");
    else if(quart == 2)
       Console.WriteLine("x < 0 and y > 0");
    else if(quart == 3)
       Console.WriteLine("x < 0 and y < 0");
    else if(quart == 4)
       Console.WriteLine("x > 0 and y < 0");
    else
    // if(quart < 1 || quart > 4) можно это не писать, потому что уже кончились варианты
    Console.WriteLine("Wrong number");   
}
Console.Write("input number ");
int quartNum = Convert.ToInt32(Console.ReadLine()); // переменная где хранится значение
ShowRange(quartNum); // вызвали метод


// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int FindNumber(int x, int y)
{
    int z = 0;  
    if(x > 0 && y > 0)
    {
        z = 1;
    }
    if(x < 0 && y > 0)
    {
        z = 2;
    }
    if(x < 0 && y < 0)
    {
        z = 3;
    }
    if(x > 0 && y < 0)
    {
        z = 4;
    }
    return z;
}
Console.Write("input x");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("input y");
int y = Convert.ToInt32(Console.ReadLine());
int z = FindNumber(x,y);
Console.WriteLine($"Show {z}");


// 2. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

double FindNumber(int x1, int y1, int x2, int y2)
{
    double lenght = Math.Sqrt (Math.Pow(x2 - x1, 2) + Math.Pow (y2 - y1, 2));
    return lenght;
}
Console.Write("input x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input y2");
int y2 = Convert.ToInt32(Console.ReadLine());
double lenght = FindNumber(x1, y1, x2, y2);
Console.WriteLine($"Show {Math.Round(lenght,3)}");


// 3. Напишите программу, которая принимает на вход число (N) 
// и выводит квадраты чисел от 1 до N.

void Square(int n)
{
    int current = 1;
    while(current <= n)
    {
        Console.WriteLine(current* current);
        current++;
    }
}
Console.Write("input number ");
int n = Convert.ToInt32(Console.ReadLine());
Square(n);
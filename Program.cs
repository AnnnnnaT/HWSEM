// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
string Pol (int num)
{
    string arr = Convert.ToString(num);
    int i=0;
    int n = arr.Length-1;
    string res = String.Empty;
    while (i<n)
    {   
        if (arr[i] == arr[n]) 
        {
        res = "yes";
        i++;
        n=n-1;
        }
    
        else 
        {
         res = "no";
         i++;
         n=n-1;
        }
    }
    
    return res;
}

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Pol(a)}");
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Dist (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double xx = x1 - x2;
    double xx2 = Math.Pow(xx,2);
    double yy = y1 - y2;
    double yy2 = Math.Pow(yy,2);
    double zz = z1 - z2;
    double zz2 = Math.Pow(zz,2);
    double c = xx2+ yy2+zz2;
    double res = Math.Sqrt(c);
    return res;
}

Console.WriteLine ("Input cordinate x1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input cordinate y1: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input cordinate z1: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"A({a},{b},{c})");
Console.WriteLine();

Console.WriteLine ("Input cordinate x2: ");
int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input cordinate y2: ");
int e = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input cordinate z2: ");
int f = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"B({d},{e},{f})");
Console.WriteLine();

Console.WriteLine($"Distance is {Dist(a,b,c,d,e,f)}");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube (int n)
{
    int i =1;
    while (i<=n)
    {
    Console.WriteLine($"{Math.Pow(i,3)}");
    i++;
    }
}

Console.WriteLine("Input a number: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Cube(d);
*/


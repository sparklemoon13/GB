// Задача 21. Напишите программу, которая принимает на вход координаты
//двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Enter X coord of point A");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y coord of point A");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Z coord of point A");
int zAcoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter X coord of point B");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y coord of point B");
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Z coord of point B");
int zBcoord = Convert.ToInt32(Console.ReadLine());


double DistanceAB (int xAcoord, int yAcoord,int zAcoordcoord, int xBcoord, int yBcoord, int zBcoord)
    //int xa, int ya, int za, int xb, int yb, int zb//
{
    int deltaX = xBcoord-xAcoord;
    int deltaY = yBcoord-yAcoord;
    int deltaZ = zBcoord-zAcoord;
    double LenthAB = Math.Sqrt(deltaX*deltaX+deltaY*deltaY+deltaZ*deltaZ);
    return LenthAB;
}
double Distance = DistanceAB(xAcoord,yAcoord,zAcoord,xBcoord,yBcoord,zBcoord);
Console.WriteLine($"Distance A-B is {Distance:f3}");
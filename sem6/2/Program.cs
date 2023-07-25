//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] CreateValuesMassive()
{
    double[] newArray = new double[4];
    Console.WriteLine("Input k1");
    newArray[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input b1");
    newArray[1] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input k2");
    newArray[2] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input b2");
    newArray[3] = Convert.ToDouble(Console.ReadLine());
    return newArray;
}

void FindPoint(double[] array)
{
    //double XCoord = (b2 - b1)/(k1 - k2);//
    double XCoord = (array[3] - array[1]) / (array[0] - array[2]);
    //double YCoord = k1*XCoord + b1// 
    double YCoord = array[0] * XCoord + array[1];
    Console.WriteLine($"Well, I guess the coords for intersection is:{XCoord:f3} ; {YCoord:f3}");
}
double[] massiveValues = CreateValuesMassive();
FindPoint(massiveValues);
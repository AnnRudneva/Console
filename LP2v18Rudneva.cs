using System; 
class Program 
{ 
    static void Main() 
    { 
        Console.WriteLine("Введите координаты точки:"); 
        double x = Convert.ToDouble(Console.ReadLine()); 
        double y = Convert.ToDouble(Console.ReadLine()); 
        double res = 0; 
        if (x > 0 && y > 0) res = 1; 
        if (x< 0 && y < 0) res = 3; 
        if (x> 0 && y< 0) res = 4; 
        if (x < 0 && y > 0) res = 2; 
        Console.WriteLine("Данная точка находится в "+res+" квадранте."); 
     
    } 
}

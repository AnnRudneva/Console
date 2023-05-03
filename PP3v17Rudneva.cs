/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("x:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("a:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Первое число:");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Второе число:");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Шаг:");
    int step = Convert.ToInt32(Console.ReadLine());
    double q = 0;
    while(b1 <= b2){
       double c1 = x /2;
       double c2 =Math.Pow(2.7,x) * Math.Sin(Math.Pow(a,2));
       double c3 = Math.Sqrt(Math.Pow(a,2) + b1 * Math.Cos(b1));
       q = c1 + c2/c3;
       Console.WriteLine("Результат для "+b1+" =  "+Math.Round(q,4));
       b1+=step;
  } 
}
}
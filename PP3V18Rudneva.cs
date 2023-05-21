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
    Console.WriteLine("шaг:");
    int step = Convert.ToInt32(Console.ReadLine());
    double answer = 0;
    while(b1 <= b2){
     double c1 =2.4 * Math.Cos(Math.Pow(a,3));
     double c2 = Math.Sqrt(Math.Pow(b1,2) - x);
     double c3 = Math.Pow(2.7,a) + b1;
     answer =(c1 + c2) / c3;
     Console.WriteLine("Результат для " + b1 + " = " + Math.Round(answer,4));
     b1+=step;
    }
  }
}

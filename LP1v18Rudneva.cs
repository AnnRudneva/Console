using System;
class HelloWorld {
  static void Main() {
   int  s =Convert.ToInt32(Console.ReadLine());
   double  v =Math.Tanh(s);
   double res = 1 / v;
   Console.WriteLine(res);
   double r = Math.Pow(2.718,s) + Math.Pow(2.718,-s);
   double k = Math.Pow(2.718,s) - Math.Pow(2.718,-s);
   double host = r / k;
   Console.WriteLine(host);
  }
}

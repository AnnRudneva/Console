/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Linq;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите сообщение");
               string str = Console.ReadLine();
                     str = String.Concat(str.OrderBy(ch => ch));
               Console.WriteLine(str);
  }
}
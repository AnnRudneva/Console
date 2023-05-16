/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите сообщение");
               string str = Console.ReadLine();
               string word = "кот";
               int count = 0;
               string[] mas = str.Split(' ');
               foreach (string s in mas) 
               {
                    if (s == word) count++;
               }
 
               Console.WriteLine(count);
  }
}
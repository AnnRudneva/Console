/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
     Console.WriteLine("Введите сообщение");
            string[]vvod = Console.ReadLine().Split(' ');
            string s ="е";
            for (int i = 0; i < vvod.GetLength(0); i++)
            {
                if (vvod[i].Substring(vvod[i].Length-1,1)!=s)
                {
                    Console.Write(vvod[i] + " ");
                }
            }
            
 
    }
  }


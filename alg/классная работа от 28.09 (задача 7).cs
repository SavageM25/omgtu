/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    int b1;
            int Z = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n - 1; i++, b = b1)
            {
                b1 = Convert.ToInt32(Console.ReadLine());
                if ((((b1 * -1) < 0) & ((b * -1) > 0)) | (((b1 * -1) > 0) & ((b * -1) < 0))) { Z += 1; }
            }
            Console.WriteLine("кол-во смены знаков последовательности:" + (Z));
  }
}

/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      int b1,b2,b3,b4,b5,b6,b7,b8,b9,b10;
      int N1=0;
      int N2=0;
      int N3=0;
    b1= Convert.ToInt32(Console.ReadLine());
    b2= Convert.ToInt32(Console.ReadLine());
    b3= Convert.ToInt32(Console.ReadLine());
    b4= Convert.ToInt32(Console.ReadLine());
    b5= Convert.ToInt32(Console.ReadLine());
    b6= Convert.ToInt32(Console.ReadLine());
    b7= Convert.ToInt32(Console.ReadLine());
    b8= Convert.ToInt32(Console.ReadLine());
    b9= Convert.ToInt32(Console.ReadLine());
    b10= Convert.ToInt32(Console.ReadLine());
    if (b1 < 0) {N1 += 1;}
    if (b2 < 0) {N1 += 1;}
    if (b3 < 0) {N1 += 1;}
    if (b4 < 0) {N1 += 1;}
    if (b5 < 0) {N1 += 1;}
    if (b6 < 0) {N1 += 1;}
    if (b7 < 0) {N1 += 1;}
    if (b8 < 0) {N1 += 1;}
    if (b9 < 0) {N1 += 1;}
    if (b10 < 0) {N1 += 1;}
    Console.WriteLine(N1);
    //ex2
    if (Math.Abs(b1) % 10 == 3) {N1 += 1;}
    if (Math.Abs(b2) % 10 == 3) {N1 += 1;}
    if (Math.Abs(b3) % 10 == 3) {N1 += 1;}
    if (Math.Abs(b4) % 10 == 3) {N1 += 1;}
    if (Math.Abs(b5) % 10 == 3) {N1 += 1;}
    if (Math.Abs(b6) % 10 == 3) {N1 += 1;}
    if (Math.Abs(b7) % 10 == 3) {N1 += 1;}
    if (Math.Abs(b8) % 10 == 3) {N1 += 1;}
    if (Math.Abs(b9) % 10 == 3) {N1+= 1;}
    if (Math.Abs(b10) % 10 == 3) {N1 += 1;}
    Console.WriteLine(N1);
    //ex3
    if (Math.Abs(b1) % 3 == Math.Abs(b1) % 5) {N2 += b1;}
    if (Math.Abs(b2) % 3 == Math.Abs(b2) % 5) {N2 += b2;}
    if (Math.Abs(b3) % 3 == Math.Abs(b3) % 5) {N2 += b3;}
    if (Math.Abs(b4) % 3 == Math.Abs(b4) % 5) {N2 += b4;}
    if (Math.Abs(b5) % 3 == Math.Abs(b5) % 5) {N2 += b5;}
    if (Math.Abs(b6) % 3 == Math.Abs(b6) % 5) {N2 += b6;}
    if (Math.Abs(b7) % 3 == Math.Abs(b7) % 5) {N2 += b7;}
    if (Math.Abs(b8) % 3 == Math.Abs(b8) % 5) {N2 += b8;}
    if (Math.Abs(b9) % 3 == Math.Abs(b9) % 5) {N2 += b9;}
    if (Math.Abs(b10) % 3 == Math.Abs(b10) % 5) {N2 += b10;}
    Console.WriteLine(N2);
    // ex4
    if ((b1 >= 0 ) & (b1 % 2 == 0)) {N3 *= b1;}
    if ((b2 >= 0 ) & (b2 % 2 == 0)) {N3 *= b2;}
    if ((b3 >= 0 ) & (b3 % 2 == 0)) {N3 *= b3;}
    if ((b4 >= 0 ) & (b4 % 2 == 0)) {N3 *= b4;}
    if ((b5 >= 0 ) & (b5 % 2 == 0)) {N3 *= b5;}
    if ((b6 >= 0 ) & (b6 % 2 == 0)) {N3 *= b6;}
    if ((b7 >= 0 ) & (b7 % 2 == 0)) {N3 *= b7;}
    if ((b8 >= 0 ) & (b8 % 2 == 0)) {N3 *= b8;}
    if ((b9 >= 0 ) & (b9 % 2 == 0)) {N3 *= b9;}
    if ((b10 >= 0 ) & (b10 % 2 == 0)) {N3 *= b10;}
    Console.WriteLine(N3);
  }
}

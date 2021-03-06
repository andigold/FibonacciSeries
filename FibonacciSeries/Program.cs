﻿using System;

namespace FibonacciSeries {
  class Program {
    static void Main(string[] args) {
      int[] fibonacci = CreateFibonacciSeries(10);

      for (int i = 0; i < fibonacci.Length; i++) {
        Console.Out.Write(fibonacci[i]);
        Console.Out.Write(" ");
      }
      Console.Out.WriteLine();
    }

    static int[] CreateFibonacciSeries(int count) {
      int[] fibonacci = new int[count];
      fibonacci[0] = 1;
      fibonacci[1] = 3;

      for (int i = 2; i < count; i++) {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
      }
      return fibonacci;
    }
  }
}

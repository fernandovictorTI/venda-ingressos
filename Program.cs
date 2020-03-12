using System;
using System.Collections.Generic;

namespace venda_ingressos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[25, 25, 50] Valor esperado True: {0}", Ingresso.Vender(new List<int>() { 25, 25, 50 }));
            Console.WriteLine("[25, 100] Valor esperado False: {0}", Ingresso.Vender(new List<int>() { 25, 100 }));
            Console.WriteLine("[25, 25, 50, 50, 100] Valor esperado False: {0}", Ingresso.Vender(new List<int>() { 25, 25, 50, 50, 100 }));
            Console.WriteLine("[100] Valor esperado False: {0}", Ingresso.Vender(new List<int>() { 100 }));
            Console.WriteLine("[25] Valor esperado True: {0}", Ingresso.Vender(new List<int>() { 25 }));
            Console.WriteLine("[25, 25, 100] Valor esperado False: {0}", Ingresso.Vender(new List<int>() { 25, 25, 100 }));
            Console.WriteLine("[25, 25, 50, 100] Valor esperado True: {0}", Ingresso.Vender(new List<int>() { 25, 25, 50, 100 }));
            Console.WriteLine("[25, 25, 50] Valor esperado True: {0}", Ingresso.Vender(new List<int>() { 25, 25, 50 }));
            Console.WriteLine("[25, 50, 100] Valor esperado False: {0}", Ingresso.Vender(new List<int>() { 25, 50, 100 }));
            Console.WriteLine("[25, 25, 25, 100] Valor esperado True: {0}", Ingresso.Vender(new List<int>() { 25, 25, 25, 100 }));
        }
    }
}

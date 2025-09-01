using System;

namespace CounterProgram{
    class Program {
        static void Main(string[] args){
            Console.WriteLine("Hello World");
        }

        static void PrintCounters(Counter[] counters){
            int index = 0;
            foreach(Counter c in counters){
                Console.WriteLine($"{index} is {c.Value}");
                index++;
            }
        }
    }
}
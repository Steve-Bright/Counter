using System;

namespace CounterProgram{
    class Program {
        static void Main(string[] args){
            Counter[] myCounters = new Counter[3];

            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = new Counter(myCounters[0].Name);

            for(int i = 0; i <=4; i++){
                myCounters[0].Increment();
            }

            for(int i = 0; i <= 9; i++){
                myCounters[1].Increment();
            }

            PrintCounters(myCounters);

            myCounters[2].Reset();

            PrintCounters(myCounters);
            

            // Counter counterOne = new Counter("Number 1");
            // Counter counterTwo = new Counter("Number 2");
            // Counter[] counters = [counterOne, counterTwo];
            // PrintCounters(counters);
            // Console.WriteLine("Hello World");
        }

        static void PrintCounters(Counter[] counters){
            int index = 0;
            foreach(Counter c in counters){
                Console.WriteLine("{0} is {1}", c.Name, c.Value);
                index++;
            }
        }
    }
}
using System;

namespace TopicosEspeciais {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = new TimeSpan(1, 30, 0);

            TimeSpan mult = t1.Multiply(2.0);

            Console.WriteLine(mult);

        }
    }
}

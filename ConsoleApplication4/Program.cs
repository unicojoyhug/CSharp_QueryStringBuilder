using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4 {
    class Program {
        static void Main(string[] args) {
            QueryStringBuilder qsb = new QueryStringBuilder("http//fkj.dk");
            qsb.Add("x", 5);
            qsb.Add("y", "23 23");
            qsb.Add("z", 9);


            Console.WriteLine((qsb.ToString())); 
        }
    }
}

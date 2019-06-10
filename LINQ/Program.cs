using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Print all numbers from 10 to 50 separated by commas
            // Console.WriteLine(String.Join("," , Enumerable.Range(10 , 41)));

            //2. Print only that numbers from 10 to 50 that can be divided by 3
            // Console.WriteLine(String.Join(",", Enumerable.Range(10, 41).Where(f => f % 3 == 0 )));

            //3 Output word "Linq" 10 times
            // Console.WriteLine(string.Join(",", Enumerable.Repeat("Linq", 10)));

            //4 Output all words with letter 'a' in string "aaa;abb;ccc;dap"
            // Console.WriteLine(String.Join(",", "aaa;abb;ccc;dap".Split(';').Where(f => f.Contains("a"))));

            //5. Output number of letters 'a' in the words with this letter in string "aaa;abb;ccc;dap" separated by comma
            //Console.WriteLine(String.Join(",", "aaa;abb;ccc;dap".Split(';').Where(f => f == "a").Count())); ?????????
            //Console.WriteLine(String.Join(",", "aaa;abb;ccc;dap".Split(';').Count(f => f.Contains("a"))));  ?????????

            //6. Output true if word "abb" exists in line  "aaa;xabbx;abb;ccc;dap", otherwise false
            //Console.WriteLine(String.Join(",", "aaa;xabbx;abb;ccc;dap").Split(';').Contains("abb"));

            //7. Get the longest word in string "aaa;xabbx;abb;ccc;dap"
            //Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').Max(f => f.Length)); ????
            //Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').Where(k => k.Length == "aaa;xabbx;abb;ccc;dap".Split(';').Max(f => f.Length))); ????
            Console.ReadKey();
        }
    }
}

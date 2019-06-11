using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Actor
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
    }

    abstract class ArtObject
    {

        public string Author { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
    class Film : ArtObject
    {

        public int Length { get; set; }
        public IEnumerable<Actor> Actors { get; set; }
    }
    class Book : ArtObject
    {

        public int Pages { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {


            /*  Level 1  */

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

            //8. Calculate average length of word in string "aaa;xabbx;abb;ccc;dap"



            /*  Level 2  */
            var data = new List<object>() {
                        "Hello",
                        new Book() { Author = "Terry Pratchett", Name = "Guards! Guards!", Pages = 810 },
                        new List<int>() {4, 6, 8, 2},
                        new string[] {"Hello inside array"},
                        new Film() { Author = "Martin Scorsese", Name= "The Departed", Actors = new List<Actor>() {
                            new Actor() { Name = "Jack Nickolson", Birthdate = new DateTime(1937, 4, 22)},
                            new Actor() { Name = "Leonardo DiCaprio", Birthdate = new DateTime(1974, 11, 11)},
                            new Actor() { Name = "Matt Damon", Birthdate = new DateTime(1970, 8, 10)}
                        }},
                        new Film() { Author = "Gus Van Sant", Name = "Good Will Hunting", Actors = new List<Actor>() {
                            new Actor() { Name = "Matt Damon", Birthdate = new DateTime(1970, 8, 10)},
                            new Actor() { Name = "Robin Williams", Birthdate = new DateTime(1951, 8, 11)},
                        }},
                        new Book() { Author = "Stephen King", Name="Finders Keepers", Pages = 200},
                        new Book() { Author = "Stephen King", Name="Showshank Redemption", Pages = 540},
                        "Leonardo DiCaprio"
                    };


            //1. Output all elements excepting ArtObjects
            //var element = data.OfType<Book>().GroupBy(f => f.Author).ToDictionary(f => f.Key , f => f.ToList());
            //foreach (var item in element)
            //        Console.WriteLine(item);


            //2. Output all actors names
            //var element = data.OfType<Book>().GroupBy(f => f.Author);
            //foreach (var name in element)
            //    Console.WriteLine(name.Key);
            //2. Output all actors names


            Console.WriteLine(String.Join(",", data.OfType<Actor>())); 

            Console.ReadKey();
        }

    }
}

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
            //Console.WriteLine(String.Join(",", "aaa;abb;ccc;dap".Split(';').Select(f => f.Count(x => x == 'a'))));  

            //6. Output true if word "abb" exists in line  "aaa;xabbx;abb;ccc;dap", otherwise false
            //Console.WriteLine(String.Join(",", "aaa;xabbx;abb;ccc;dap").Split(';').Contains("abb"));

            //7. Get the longest word in string "aaa;xabbx;abb;ccc;dap"
            //Console.WriteLine("aaa;xabbx;abb;ccc;dSADap".Split(';').First(item => item.Length == "aaa;xabbx;abb;ccc;dSADap".Split(';').Max(f => f.Length)));

            //8. Calculate average length of word in string "aaa;xabbx;abb;ccc;dap"
            //Console.WriteLine(String.Join(",", "aaa;xabbx;abb;SDb;ccc;dap").Split(';').Average(f => f.Length));

            //9. Print the shortest word reversed in string "aaa;xabbx;abb;ccc;dap;zh"
            //Console.WriteLine("baaa;aabb;xabbx;abb;ccc;dap;zh".Split(';').First(item => item.Length == "baaa;aabb;xabbx;abb;ccc;dap;zh".Split(';').Min(f => f.Length)));

            //10. Print true if in the first word that starts from "aa" all letters are 'a' otherwise false "baaa;aabb;xabbx;abb;ccc;dap;zh"
            // Console.WriteLine(String.Join(",", "baaa;aabb;xabbx;abb;ccc;dap;zh".Split(';').FirstOrDefault(x => x.IndexOf("aa") == 0).Select(f => f)));


            //11. Print last word in sequence that excepting first two elements that ends with "bb"



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

            //  Console.WriteLine(string.Join(Environment.NewLine,

            //1. Output all elements excepting ArtObjects
            //Console.WriteLine(string.Join(Environment.NewLine, data.Except(data.OfType<ArtObject>())));

            //2. Output all actors names
            //Console.WriteLine(string.Join(Environment.NewLine,data.OfType<Film>().SelectMany(f => f.Actors).Select(f => f.Name)));

            //3. Output number of actors born in august
            //Console.WriteLine(string.Join(Environment.NewLine, data.OfType<Film>().SelectMany(f => f.Actors).Where(f => f.Birthdate.Month == 8).Count()));

            //4. Output two oldest actors names
            //Console.WriteLine(string.Join(Environment.NewLine, data.OfType<Film>().SelectMany(f => f.Actors).OrderBy(f => f.Birthdate).Select(f => f.Name).Take(2)));

            //5. Output number of books per authors
            //Console.WriteLine(string.Join(Environment.NewLine, data.OfType<Book>().GroupBy(f => f.Author).Select(f => f.Key + " : " + f.Count())));

            //6. Output number of books per authors and films per director
            //Console.WriteLine(string.Join(Environment.NewLine, data.OfType<ArtObject>().GroupBy(f => f.Author).Select(f => f.Key + " : " + f.Count())));

            //7. Output how many different letters used in all actors names
            //Console.WriteLine(string.Join(Environment.NewLine, data.OfType<Film>().SelectMany(f => f.Actors).Select(f => f.Name).Distinct().Select(f => f.Distinct().Count())));

            //8. Output names of all books ordered by names of their authors and number of pages
            //Console.WriteLine(string.Join(Environment.NewLine, data.OfType<Book>().OrderBy(f => f.Author).OrderBy(f => f.Pages).Select(f => f.Name)));

            //9. Output actor name and all films with this actor
            /////////////// 

            //10. Output sum of total number of pages in all books and all int values inside all sequences in data
            //Console.WriteLine(string.Join(Environment.NewLine, data.OfType<Book>().Select(f => f.Pages).Sum() + " " + data.OfType<IEnumerable<int>>().SelectMany(f => f.OfType<int>()).Sum()));

            //11. Get the dictionary with the key - book author, value - list of author's books
            ////////////////////////////   

            //12. Output all films of "Matt Damon" excluding films with actors whose name are presented in data as strings

            Console.ReadKey();
        }

    }
}

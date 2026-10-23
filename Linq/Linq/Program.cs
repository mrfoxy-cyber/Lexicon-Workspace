using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LinqOvningar
{
    public class Student
    {
        public int Id { get; set; }
        public string Namn { get; set; } = "";
    public int Alder { get; set; }
        public string Klass { get; set; } = "";
    public int Poang { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Exempeldata
            List<Student> studenter = new List<Student>
                 {
                 new Student { Id = 1, Namn = "Anna", Alder = 19, Klass = "A", Poang = 85 },
                 new Student { Id = 2, Namn = "Bertil", Alder = 22, Klass = "B", Poang = 72 },
                 new Student { Id = 3, Namn = "Cecilia", Alder = 20, Klass = "A", Poang = 91 },
                 new Student { Id = 4, Namn = "David", Alder = 24, Klass = "C", Poang = 64 },
                 new Student { Id = 5, Namn = "Eva", Alder = 19, Klass = "B", Poang = 85 },
                 new Student { Id = 6, Namn = "Felix", Alder = 21, Klass = "A", Poang = 77 },
                 new Student { Id = 7, Namn = "Gustav", Alder = 23, Klass = "C", Poang = 58 },
                 new Student { Id = 8, Namn = "Hanna", Alder = 20, Klass = "B", Poang = 95 }
                 };
            Console.WriteLine("LINQ-ÖVNINGAR MED STUDENTER\n");

            //Where
            //• Hämta alla studenter som är äldre än 20.
            //• Hämta alla studenter som har mer än 80 poäng.

            var twentyPlus = studenter.Where(x => x.Alder > 20);


            var eightyPlusPoints = studenter.Where(x => x.Poang > 80);

            //Select
            //• Visa bara namnen på alla studenter.
            //• Visa namn och poäng i en ny anonym typ.

            var namn = studenter.Select(x => x.Namn);
            var namnPoint = studenter.Select(x => new { x.Namn, x.Poang });

            //OrderBy
            //• Sortera studenter efter ålder.
            //• Sortera studenter efter poäng, högst först.

            var sortbyAge = studenter.OrderBy(x => x.Alder);
            var sortbyPoints = studenter.OrderByDescending(x => x.Poang);


            //Count
            //• Räkna hur många studenter som finns.
            //• Räkna hur många som går i klass A

            var countStudents = studenter.Count();
            var countSudentsClassA = studenter.Count(x => x.Klass.Equals( "A",StringComparison.OrdinalIgnoreCase));

            //Take
            //• Ta ut de tre första studenterna.
            //• Ta ut de två bästa poängen efter sortering.

            var ThreeFirst = studenter.Take(3);
            var ThreeBest = sortbyPoints.Take(2);

            //Distinct
            //• Visa alla unika klassnamn.
            //• Visa alla unika åldrar.

            var ClassNames = studenter.Select(x=> x.Klass).Distinct();
            var uniqueAge = studenter.Select(x => x.Alder).Distinct();

            //Any / All
            //• Finns det någon student med 100 poäng ?
            //• Har alla studenter minst 50 poäng?

            var TopScorer = studenter.Any(x => x.Poang == 100);
            var ClassSuccess = studenter.All(x => x.Poang >= 50);

            //FirstOrDefault / Last / Single
            //• Hämta första studenten i klass B.
            //• Hämta sista studenten i listan.
            //• Hämta studenten med ett visst Id.

            var FirstClassB = studenter.Where(x => x.Klass.Equals("B", StringComparison.OrdinalIgnoreCase))
                                        .First();

            var Last = studenter.Last();

            var chosenId = 3;

            var Single = studenter.Single(x => x.Id == chosenId);

            //GroupBy
            //• Gruppera studenter per klass.
            //• Skriv ut varje klass och namnen i gruppen.

            var GroupByClass = studenter.GroupBy( x => x.Klass);

            foreach(var group in GroupByClass)
            {
                Console.WriteLine($"Class {group.Key}");

                foreach (var student in group)
                {
                    Console.WriteLine($"student: {student.Namn}");
                }
            }



            //Sum / Average / Min / Max
            //• Summera alla poäng.
            //• Räkna ut medelpoäng.
            //• Hitta lägsta och högsta poäng.

            var sum = studenter.Select(x => x.Poang).Sum();

            var medel = sum / countStudents;

            var topOchLow = (
                                 Min: studenter.Min(x => x.Poang),
                                 Max: studenter.Max(x => x.Poang)
                             );


        }
    }
}
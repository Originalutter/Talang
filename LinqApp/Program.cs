using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
	        {
		        new Person() { FirstName = "Jet", LastName = "Li", Age = 30 },
		        new Person() { FirstName = "Chuck", LastName = "Norris", Age = 35 },
		        new Person() { FirstName = "Bruce", LastName = "Willis", Age = 40 },
		        new Person() { FirstName = "Tom", LastName = "Cruise", Age = 45 },
		        new Person() { FirstName = "Kurt", LastName = "Russel", Age = 50 },
		        new Person() { FirstName = "Steven", LastName = "Seagal", Age = 50 },
		        new Person() { FirstName = "Dolph", LastName = "Lundgren", Age = 50 },
		        new Person() { FirstName = "Jean-Claude", LastName = "Van Damme", Age = 55 },
		        new Person() { FirstName = "Sylvester", LastName = "Stallone", Age = 55 },
		        new Person() { FirstName = "Arnold", LastName = "Schwarzenegger", Age = 60 }
	        };
            var sb = new StringBuilder();
            //LAMBDA EXPRESSIONS
            var result1 = persons.FirstOrDefault(p => p.Age == 50);
            var result2 = persons.Single(p => p.IsChuckNorris);
            var result3 = persons.Where(p=>p.Age>50);
            sb.Append(string.Join(Environment.NewLine, result3));
            var result4 = from p in persons where p.Age > 50 orderby p.Age descending select p;
            sb.Append(string.Join(Environment.NewLine, result4));
            var result5 = from p in persons where p.ToString().ToLower().Contains("s") select p;
            sb.Append(string.Join(Environment.NewLine, result5));
            var sresult11 = sb.ToString();
            //LINQ SYNTAX
            sb = new StringBuilder();
            var result12 = (from p in persons where p.Age == 50 select p).FirstOrDefault();
            var result22 = (from p in persons where p.IsChuckNorris select p).Single();
            var result32 = from p in persons where p.Age > 50 select p;
            sb.Append(string.Join(Environment.NewLine, result32));
            var result42 = from p in persons where p.Age > 50 orderby p.Age descending select p;
            sb.Append(string.Join(Environment.NewLine, result42));
            var result52 = from p in persons where p.ToString().ToLower().Contains("s") select p;
            sb.Append(string.Join(Environment.NewLine, result52));
            var sresult12 = sb.ToString();
            //GROUP LAMBDA
            sb = new StringBuilder();
            var result6 = persons.GroupBy(p => p.Age).Select(pa => pa.Key + " = " + pa.Count());
            sb.Append(string.Join(Environment.NewLine, result6));
            var sresult21 = sb.ToString();
            //GROUB LINQ
            sb = new StringBuilder();
            var result62 = from pa in (from p in persons group p.Age by p.Age) where true select pa.Key + " = " + pa.Count();
            sb.Append(string.Join(Environment.NewLine, result62));
            var sresult22 = sb.ToString();

            var lista = new List<Object> {1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1};
            int count = 0;
            foreach (var n in lista)
            {
                count++;
            }

        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsChuckNorris { get { return FirstName + LastName == "ChuckNorris"; } }

        public override string ToString()
        {
            return string.Concat(FirstName, " ", LastName).PadRight(24, '.') + Age;
        }
    }
}

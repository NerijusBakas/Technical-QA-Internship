using System;
using System.Xml.Linq;

namespace Technical_QA_Internship_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            string[] Adjective = { "Stunning", "Delightful", "Wild",
                "Useless", "Great", "Drunken",
                "Crazy", "Quiet", "Bright", "Scrumptious" };

            string[] Noun = { "Compass", "Banana", "Geek",
            "Sausage", "Fairy", "Melons", "Buffalo",
                "Programmers", "Mustangs", "Joysticks"};

            string[] RandomName = { "Bodrum Salvador", "Hilary Ouse", "Indigo Violet", "Hans Down",
            "Shequondolisa Bivouac", "Ingredia Nutrisha", "Fig Nelson", "Benjamin Evalent",
            "Gustav Purpleson", "Elon Gated"};

            string[] BandMember = { "Vocalist", "Bass guitarist", "Drummer", "Electric guitarist" };

            string[] NewAdjective = { "Wonderful" };

            Random m = new Random();

            var totalCount = 0;
            var totalCount1 = 0;
            var totalCount2 = 0;


            //     Console.WriteLine(Adjective[r.Next(0, Adjective.Length)]);
            //   Console.WriteLine(Noun[r.Next(0, Noun.Length)]);
            // Console.WriteLine(RandomName[r.Next(0, RandomName.Length)]);


            Console.WriteLine("Random adjective + nouns and random name");
            Console.WriteLine((Adjective[r.Next(0, Adjective.Length)]) + " + " + (Noun[r.Next(0, Noun.Length)]) + ", " + RandomName[r.Next(0, RandomName.Length)]);

            Console.WriteLine();

            Console.WriteLine("Band member (Random):");
            Console.WriteLine("1. " + (RandomName[r.Next(0, RandomName.Length)]) + " - " + (BandMember[r.Next(0, BandMember.Length)]));
            Console.WriteLine("2. " + (RandomName[r.Next(0, RandomName.Length)]) + " - " + (BandMember[r.Next(0, BandMember.Length)]));
            Console.WriteLine("3. " + (RandomName[r.Next(0, RandomName.Length)]) + " - " + (BandMember[r.Next(0, BandMember.Length)]));
            Console.WriteLine("4. " + (RandomName[r.Next(0, RandomName.Length)]) + " - " + (BandMember[r.Next(0, BandMember.Length)]));

            Console.WriteLine();

            Console.WriteLine("Write Adjective:");
            string name = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Random adjective symbol: " +(name[r.Next(0, name.Length)]));
            Console.WriteLine();

            totalCount = Adjective.Count();
            totalCount1 = Noun.Count();
            totalCount2 = (NewAdjective.Count() + 1);

            Console.WriteLine("Count of adjectives: " + totalCount);
            Console.WriteLine("Count of noun: " + totalCount1);

            Console.WriteLine();
            Console.WriteLine("Band - name and setup (person names / roles: ");
            Console.WriteLine(((Adjective[r.Next(0, Adjective.Length)]) + " + " + (Noun[r.Next(0, Noun.Length)]) + ", " + RandomName[r.Next(0, RandomName.Length)]) + ", " + (BandMember[r.Next(0, BandMember.Length)]));

            Console.WriteLine();
            Console.WriteLine("Bonus. Added new adjective");
            Console.WriteLine(NewAdjective[r.Next(0, NewAdjective.Length)]);

            //Clear array
            Array.Clear(Adjective, 0, Adjective.Length);
            Array.Clear(Noun, 0, Noun.Length);

        }

    }
}
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            var studList = new StudCont();
            studList.Add(new Student("Luhoviy Oleksander Evgeniyovich", new DateTime(2002, 4, 2), new DateTime(2019, 9, 1), "B", 119, "CIT", "Videogames", 95));
            studList.Add(new Student("Orlova Vlada Stanislavovna", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "B", 119, "CIT", "Videogames", 94));
            studList.Add(new Student("Myhlin Andrew Aleksandrovich", new DateTime(2002, 3, 31), new DateTime(2019, 9, 1), "B", 119, "CIT", "Videogames", 67));

            Console.WriteLine(StudContHelper.ToTable(studList));

            studList.Reset();
            studList.Sort(StudCont.SortType.Performance);

            studList.Reset();
            Console.WriteLine(StudContHelper.ToTable(studList));
        }
    }
}

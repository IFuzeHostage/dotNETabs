using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var studList = new StudCont();
            var studHelper = new StudContHelper();
            var studCalc = new StudContCalculator();
            studList.Add(new Student("Luhoviy Oleksander Evgeniyovich", new DateTime(2002, 4, 2), new DateTime(2019, 9, 1), "B", 119, "CIT", "Videogames", 95));
            studList.Add(new Student("Orlova Vlada Stanislavovna", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "B", 119, "CIT", "Videogames", 94));
            studList.Add(new Student("Myhlin Andrew Aleksandrovich", new DateTime(2002, 3, 31), new DateTime(2019, 9, 1), "B", 119, "CIT", "Videogames", 67));

            studCalc.Container = studList;
            Console.WriteLine();
            Console.WriteLine(studHelper.ToTable(studList, Student.CompareSpecialty, "Videogames"));
            studList.Reset();
            Console.WriteLine("Средний возраст группы КИТ-119Б: " + studCalc.AverageAge(Student.CompareGroup, "CIT-119B"));

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(studList, options);

            Console.WriteLine(jsonString);

            StudCont studList2 = new StudCont(JsonSerializer.Deserialize<List<Student>>(jsonString));
            foreach (Student stud in studList2)
            {
                Console.WriteLine(stud.ToText());
            }
        }
    }
}

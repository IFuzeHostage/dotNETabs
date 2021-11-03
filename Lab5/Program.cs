using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var studList = new StudCont();
            var studHelper = new StudContHelper();
            var studCalc = new StudContCalculator();
            studList.Add(new Student("Луговой Александр Евгениевич", new DateTime(2002, 4, 2), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерные игры", 95));
            studList.Add(new Student("Орлова Влада Станиславовна", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерные игры", 94));
            studList.Add(new Student("Мыглин Андрей Александрович", new DateTime(2002, 3, 31), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерные игры", 67));
            studList.Add(new Student("Хаврюта Андрей Юрьевич", new DateTime(2002, 3, 10), new DateTime(2019, 9, 1), "В", 419, "КИТ", "АТМ", 75));
            studList.Add(new Student("Васильев Даниил Анатолиевич", new DateTime(2002, 12, 24), new DateTime(2019, 9, 1), "В", 419, "КИТ", "АТМ", 71));

            studCalc.Container = studList;
            Console.WriteLine();
            //Console.WriteLine(studHelper.ToTable(studList, Student.CompareSpecialty, "Компьютерные игры"));
            Console.WriteLine(studList.GetStudent(0).ToText());
            Console.WriteLine("Средний возраст группы КИТ-119Б: " + studCalc.AverageAge(Student.CompareGroup, "КИТ-119Б"));
        }
    }
}

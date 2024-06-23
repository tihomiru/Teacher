namespace TeachersProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //записваме учители тук
            TeacherOperations teacherOps = new TeacherOperations();
            //създаване на учител1
            Teacher mathTeacher = new TeachersInformation();
            //информация за учител1
            mathTeacher.TeacherInfo("Кирил Петров", "ПГ. Софроний Врачански", new List<string> { "11д", "11а", "9е", "10б", "8в", "9г" }, "" +
                "Математика", "безсрочен");
            //създаване на учител2
            Teacher historiTeacher = new TeachersInformation();
            //информация за учител2
            historiTeacher.TeacherInfo("Маргарита Иванова", "НЧ. Христо Смирненски", new List<string> { "7в", "5б", "6г", "7а", "5в", "4б" }, "" +
                "История и цевилизация", "срочен");
            //добавяне на предмета към учител
            teacherOps.AddTeachers(mathTeacher);
            teacherOps.AddTeachers(historiTeacher);

            //изкарва всички учители
            var allTeachers = teacherOps.GetTeachers();
            Console.WriteLine("Всички учители");
            allTeachers.ForEach(t => Console.WriteLine(t.GetInfo()));

            //изкарване на учители по предмети
            var mathTeachers = teacherOps.GetTeacherBySubject("Математика");
            Console.WriteLine("\nМатематика");
            mathTeachers.ForEach(t => Console.WriteLine(t.GetInfo()));

            var historiTeachers = teacherOps.GetTeacherBySubject("История и цевилизация");
            Console.WriteLine("\nИстория и цевилизация");
            historiTeachers.ForEach(t => Console.WriteLine(t.GetInfo()));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersProject
{
    public class TeacherOperations : ITeacherOperations
    {
        //имплементираме интерфейса и предоставя финкциите да извличаме и добавяме учители
        private List<Teacher> teachers = new List<Teacher>();
        public void AddTeachers(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public List<Teacher> GetTeachers()
        {
            return teachers;
        }
        public List<Teacher> GetTeacherBySubject(string subject)
        {
            return teachers.Where(t => t.GetSubject() == subject).ToList();
        }
    }
}

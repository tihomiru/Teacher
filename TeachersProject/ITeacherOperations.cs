using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersProject
{
    public interface ITeacherOperations
    {
        //дефенираме методи за учители
        void AddTeachers(Teacher teacher);
        List<Teacher> GetTeachers();
        List<Teacher> GetTeacherBySubject(string subject);
    }
}

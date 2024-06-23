using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersProject
{
    public abstract class Teacher
    {
        //тук задаваме данни на учителя
        public string name { get; set; }
        public string school { get; set; }
        public List<string> classes { get; set; }
        public string subject { get; set; }
        public string contractType { get; set; }

        //извлича данни за учителя и за предмета
        public abstract void TeacherInfo(string name, string school, List<string> classes,
            string subject, string contractType);
        public abstract string GetInfo();
        public abstract string GetSubject();
    }
}

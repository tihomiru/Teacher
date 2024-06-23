using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersProject
{
    public class TeachersInformation : Teacher
    {
        //имплиментираме методите на абстрактиния клас
        public override void TeacherInfo(string name, string school, List<string> classes,
            string subject, string contractType)
        {
            this.name = name;
            this.school = school;
            this.classes = classes;
            this.subject = subject;
            this.contractType = contractType;
        }
        public override string GetInfo()
        {
            return $"\nИмената на учителтеля са {name}, работи в {school} училище, " +
                $"\nпреподава на {string.Join(", ", classes)} " +
                $"\nкласове, този учител е по {subject}, учителя е с {contractType} договор!";
        }
        public override string GetSubject()
        {
            return subject;
        }
    }
}

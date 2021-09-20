using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicControl.Entities
{
    public class Student
    {

        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public string POB { get; set; }
 
        public EGender Gender { get; set; }
 
        public string HomeTown { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName} {FirstName}";
            }
        }
        public static List<Student> GetList()
        {
            var ls = new List<Student>();
            ls.Add(new Student()
            {
                LastName = "Nguyễn",
                Id = "1",
                FirstName = "Hùng",  
                DOB = new DateTime(2000, 9, 5),
                POB = "Phú Vang",
                HomeTown = "Thừa Thiên Huế",
                Gender = EGender.Nam
            });

            ls.Add(new Student()
            {
                LastName = "Nguyễn",
                Id = "2",
                FirstName = "Thị Thơm",
                DOB = new DateTime(2000, 5, 5),
                POB = "Phú Lộc",
                HomeTown = "Đà Nẵng",
                Gender = EGender.Nu
            });

            return ls;
        }

        public static Student Get(string id)
        {
            var dbStudent = GetList();
            var student = dbStudent.Where(s=>s.Id == id).FirstOrDefault();
            return student;

        }
    }
    public enum EGender
    {
        Nam, Nu, Khac
    }
}

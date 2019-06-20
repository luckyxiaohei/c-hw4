using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class StudentRepository : InterfaceStudentRepository
    {
        private List<Student> students = new List<Student>();
        private int _nextId = 1;
        public StudentRepository()
        {
            Add(new Student { Name = "漩涡鸣人", ClassName = 1, Gender = "男" });
            Add(new Student { Name = "漩涡向日葵", ClassName = 2, Gender = "女" });
            Add(new Student { Name = "漩涡博人", ClassName = 3, Gender = "男"});
        }




        public IEnumerable<Student> GetAll()
        {
            return students;
        }

        public Student Add(Student item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            students.Add(item);
            return item;
        }


    }
}
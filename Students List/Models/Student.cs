using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students_List.Models
{
    public class Student
    {

        public int id { set; get; }
        public string name { set; get; }
    }

    public class StudentRepository
    {
        public static List<Student> students_tbl = new List<Student>();

        public List<Student> select()
        {
            return students_tbl;
        }
        public void insert(Student student)
        {
            students_tbl.Add(student);
        }

        public void delete(Student student)
        {

            var stu = students_tbl.Find(x => x.id == student.id);
            students_tbl.Remove(stu);
            //int index = -1;
            //foreach (var x in students_tbl)
            //{
            //    ++index;
            //    if (x.id == student.id)
            //        break;
            //}
            //students_tbl.RemoveAt(index);
        }

        public void update(Student student)
        {

            var stu = students_tbl.Find(x => x.id == student.id);
            stu.name = student.name;

        }
    }
}

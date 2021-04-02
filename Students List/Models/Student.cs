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
        public int idd=0;

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
            int index = -1;
            foreach (var x in students_tbl)
            {
                ++index;
                if (x.id == student.id)
                    break;
            }
            students_tbl.RemoveAt(index);
        }

        public void setIdd(int iddd)
        {
            idd = iddd;
        }
        public void update(Student student)
        {
            int index = -1;
            foreach (var x in students_tbl)
            {
                ++index;
                if (x.id == idd)
                {
                    x.id = student.id;
                    x.name = student.name;
                }
            }
            
        }

        
    }
}

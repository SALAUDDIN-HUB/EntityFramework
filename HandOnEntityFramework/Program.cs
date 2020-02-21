using System;
using System.Collections.Generic;
using System.Linq;
using HandOnEntityFramework.context;
using HandOnEntityFramework.Models;
namespace HandOnEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        { 
            using(MyContext db=new MyContext())
            {
                  student s = new student() { Sname = "Rohan", Age = 20, Std = "IT" };
                //db.students.Add(s);
               // db.SaveChanges();
                // student s = db.students.Find(1);
                //Console.WriteLine("Welcome {0}", s.Sname);
                //student s1 = db.students.SingleOrDefault(i => i.Sname == "Rohan");
                //List<student> list = db.students.Where(i => i.Age == 10).ToList();
                //List<student> list1 = db.students.Where(i => i.Age == 10 && i.Std=="IT").ToList();
                //update record
               student s2 = db.students.Find(3);
               s2.Age = 11;
               db.students.Update(s2);
                db.SaveChanges();
              //  //delete record
               // student s3 = db.students.SingleOrDefault(i => i.Sname == "karan");
              //  db.students.Remove(s3);
             //   db.SaveChanges();
            }
            
        }
    }
}

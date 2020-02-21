using System;
using EFDAL;
using EFDAL.Context;
using EFDAL.Models;

namespace EMC_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using(MyContext db=new MyContext())
            {
                Project4 p = new Project4() { ProjectName = "BFS" };
                db.Add(p);
                db.SaveChanges();
            }
        }
    }
}

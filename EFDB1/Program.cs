using System;
using EFCODEDBFIRST;
using EFCODEDBFIRST.Models;
namespace EFDB1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (masterContext db = new masterContext())
            {
                Item i = new Item() { ItemName = "afhhbcd", Itemprice = 100 };
                db.Add(i);
                db.SaveChanges();
            }
        }
    }
}

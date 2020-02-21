using System;
using EFCODEDBFIRST;
using EFCODEDBFIRST.Models;


namespace EFDB
{
    public class Class1
    {
        static void Main(string[] args)
        {
            using (masterContext db = new masterContext())
            {
                Item i = new Item() { ItemName = "qwerr", Itemprice = 500000 };
                db.Add(i);
                db.SaveChanges();
            }
        }
    }
}
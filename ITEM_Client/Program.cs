using System;
using ASSIGNMENTENTITY;
using ASSIGNMENTENTITY.Models;
using ASSIGNMENTENTITY.Context;
namespace ITEM_Client
{
    class Program
    {
        static void Main(string[] args)
        {

              using (MyContext db = new MyContext())
                {
                    Item i = new Item() {ItemName="abcd",Itemprice=100};
                    db.Add(i);
                    db.SaveChanges();
                }
            }
        }
    }


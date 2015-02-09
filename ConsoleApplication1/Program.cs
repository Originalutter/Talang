using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MyDatabaseDataContext())
            {
                var result = from c in db.Customers select c;
                foreach (var c in result)
                {
                    c.Address = "Linq2Sql";
                    c.Updated = DateTime.Now;
                }
                db.SubmitChanges();
            }

            using (var db2 = new MyDBEntities())
            {
                var result = from c in db2.Customers select c;
                foreach (var c in result)
                {
                    c.Address = "Entity";
                    c.Updated = DateTime.Now;
                }
                db2.SaveChanges();
            }
        }
    }
}

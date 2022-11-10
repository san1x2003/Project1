using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (ApplicationContext db = new ApplicationContext())
            {
                var Zakazs = db.Zakaz.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Zakaz u in Zakazs)
                {
                    Console.WriteLine(u.id_klient + " " + u.id_post + " " + u.id_sklada + " " + u.id_sotrydnik + " " + u.id_product + " " + u.id_zakaza + " " + u.number_contract + " " + u.date_of_execution + " " + u.adress);
                }
            }
            
            using (ApplicationContext db = new ApplicationContext())
            {
                Zakaz test = new Zakaz { id klient = 1, id_post = 1, id_sklada = 1, id_sotrydnik = 1, id_product = 1, id_zakaza = 1, number_contract = 1, date_of_execution = 2022 - 11 - 04, adress = biryzova, 2 };
                db.Zakaz.Add(test);
                db.SaveChanges();
                var Zakazs = db.Zakaz.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Zakaz u in Zakazs)
                {
                    Console.WriteLine(u.id_klient + " " + u.id_post + " " + u.id_sklada + " " + u.id_sotrydnik + " " + u.id_product + " " + u.id_zakaza + " " + u.number_contract + " " + u.date_of_execution + " " + u.adress);
                }

            }

            using (ApplicationContext db = new ApplicationContext())
            {
                Zakaz upduser = (from Zakaz in db.Zakaz where Zakaz.IDOrder == 6 select Zakaz).First();
                if (upduser != null)
                {
                    upduser.Zakaz_cost = upduser.Zakaz_cost * 2;
                    db.SaveChanges();
                }
                var Zakazs = db.Zakaz.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Zakaz u in Zakazs)
                {
                    Console.WriteLine(u.id_klient + " " + u.id_post + " " + u.id_sklada + " " + u.id_sotrydnik + " " + u.id_product + " " + u.id_zakaza + " " + u.number_contract + " " + u.date_of_execution + " " + u.adress);
                }

            }

            using (ApplicationContext db = new ApplicationContext())
            {
                Zakaz deluser = (from Zakaz in db.Zakaz where Zakaz.IDOrder == 6 select Zakaz).First();
                if (deluser != null)
                {
                    db.Order.Remove(deluser);
                    db.SaveChanges();
                }
                var orders = db.Order.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Zakaz u in Zakaz)
                {
                    Console.WriteLine(u.id_klient + " " + u.id_post + " " + u.id_sklada + " " + u.id_sotrydnik + " " + u.id_product + " " + u.id_zakaza + " " + u.number_contract + " " + u.date_of_execution + " " + u.adress);
                }

            }
        }

    }
}

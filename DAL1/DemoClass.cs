using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1
{

    public class DemoClass
    {
        testEntities1 db = new testEntities1();
        public List<DemoTable> GetAll()
        {
            try
            {
                List<DemoTable> list = new List<DemoTable>();
                list = db.DemoTables.ToList();
                return list;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DemoTable GetById(int Id = 0)
        {
            try
            {

                var data = db.DemoTables.FirstOrDefault(x => x.id == Id);
                return data;


            }
            catch (Exception)
            {

                return null;
            }
        }
        public void Add(DemoTable fdata)
        {
            try
            {

                DemoTable data = new DemoTable();
                data.Name = fdata.Name;
                data.Address = fdata.Address;
                db.DemoTables.Add(data);
                db.SaveChanges();
            }
            catch (Exception)
            {
            }
        }
        public void Update(DemoTable fdata)
        {
            DemoTable data = new DemoTable();
            data = db.DemoTables.FirstOrDefault(x => x.id == fdata.id);
            data.Name = fdata.Name;
            data.Address = fdata.Address;
            db.SaveChanges();


        }
        public void Delete(int Id = 0)
        {
            try
            {
                DemoTable data = new DemoTable();
                data = db.DemoTables.FirstOrDefault(x => x.id == Id);
                db.DemoTables.Remove(data);
                db.SaveChanges();

            }
            catch (Exception)
            {


            }


        }

    }
}

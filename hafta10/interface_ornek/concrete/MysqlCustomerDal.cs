using interface_ornek.abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_ornek.concrete
{
    public class MysqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql added");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Mysql updated");
        }
    }
}


using interface_ornek.abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_ornek.concrete
{
    public class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Server added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Server deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Server updated");
        }
    }
}

using interface_ornek.abstraction;
using interface_ornek.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlServerCustomerDal sqlServerCustomerDal = new SqlServerCustomerDal();
            MysqlCustomerDal mySqlCustomerDal = new MysqlCustomerDal();
            OracleCustomerDal oracleCustomerDal = new OracleCustomerDal();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(oracleCustomerDal);

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MysqlCustomerDal()
            };

           

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


            Console.ReadLine();
        }
    }
}

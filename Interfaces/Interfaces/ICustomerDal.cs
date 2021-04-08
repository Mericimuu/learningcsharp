using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    //data access layer
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated!");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated!");
        }
    }

    class CustomerManager
    {
        /*burayı oracle ya da sql'e göre verirsek, günün birinde proje ilerlediği zaman bağımlı hale gelmiş oluruz.
        Proje sadece sql ile ya da oracle ile çalışıyor dememek için interface tanımına ihtiyaç duyarız. */

        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }


}

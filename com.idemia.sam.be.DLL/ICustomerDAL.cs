using com.idemia.sam.be.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.idemia.sam.be.DAL
{
    public interface ICustomerDAL
    {
        CustomerDTO UpdateCustomerinDB(CustomerDTO customerDTO);

        CustomerDTO GetCustomerByIDFromDB(int id);
       
        bool DeleteCustomerFromDB(int id);

        CustomerDTO AddCustomerToDB(CustomerDTO cutomerDTO);

        ICollection<CustomerDTO> GetCustomersFromDB();
    }
}

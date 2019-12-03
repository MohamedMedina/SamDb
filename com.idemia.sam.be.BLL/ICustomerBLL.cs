using com.idemia.sam.be.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.idemia.sam.be.BLL
{
    public interface ICustomerBLL
    {
        ICollection<CustomerDTO> GetAllCustomers();

        CustomerDTO GetCustomerbyID(int id);

        CustomerDTO AddCustomer(CustomerDTO customerDTO);

        bool DeleteCustomer(int id);

        CustomerDTO UpdateCustomer(CustomerDTO customerDTO);

    }
}

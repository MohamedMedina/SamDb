using com.idemia.sam.be.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.idemia.sam.be.DAL;
using com.idemia.sam.be.Contracts;

namespace com.idemia.sam.be.BLL
{
    public class CustomerBLL : ICustomerBLL
    {


        ICustomerDAL _ICustomerDAL;

        public CustomerBLL()
        {
            _ICustomerDAL = new CustomerDAL();

        }

        public CustomerDTO UpdateCustomer(CustomerDTO customerDTO)
        {
            try
            {
                return _ICustomerDAL.UpdateCustomerinDB(customerDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }
       
        public bool DeleteCustomer(int id)
        {
            try
            {
                return _ICustomerDAL.DeleteCustomerFromDB(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public CustomerDTO AddCustomer(CustomerDTO cutomerDTO)
        {
            try
            {
                return _ICustomerDAL.AddCustomerToDB(cutomerDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<CustomerDTO> GetAllCustomers()
        {
            try
            {
                return _ICustomerDAL.GetCustomersFromDB();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public CustomerDTO GetCustomerbyID(int id)
        {
            try
            {
                return _ICustomerDAL.GetCustomerByIDFromDB(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    }


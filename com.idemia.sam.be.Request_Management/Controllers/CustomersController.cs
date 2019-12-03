using com.idemia.sam.be.BLL;
using com.idemia.sam.be.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace com.idemia.sam.be.Request_Management.Controllers
{
    public class CustomersController : ApiController
    {
        private CustomerBLL _ICustomerBLL;

        public CustomersController()
        {
            _ICustomerBLL = new CustomerBLL();
        }

        public HttpResponseMessage GetCustomers()
        {
            try
            {
                List<CustomerDTO> _Output = _ICustomerBLL.GetAllCustomers().ToList();
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        public HttpResponseMessage GetCustomer(int id)
        {
            try
            {
                CustomerDTO _Output = _ICustomerBLL.GetCustomerbyID(id);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage AddCustomer(CustomerDTO cutomerDTO)
        {
            try
            {
                if (cutomerDTO == null)
                    throw new ArgumentNullException("cutomerDTO");

                CustomerDTO _Output = _ICustomerBLL.AddCustomer(cutomerDTO);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        public HttpResponseMessage DeleteCustomer(int id)
        {
            try
            {
                if (_ICustomerBLL.DeleteCustomer(id))
                    return Request.CreateResponse(HttpStatusCode.OK);
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Operation Not Completed");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public HttpResponseMessage UpdateCustomer(CustomerDTO customerDTO)
        {
            try
            {
                if (customerDTO == null)
                    throw new ArgumentNullException("customerDTO");

                CustomerDTO _Output = _ICustomerBLL.UpdateCustomer(customerDTO);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}

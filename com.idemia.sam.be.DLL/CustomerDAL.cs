using ApplicationBlocks.Layers;
using Business;
using com.idemia.sam.be.Contracts;
using com.idemia.sam.be.Helpers;
using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.idemia.sam.be.DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        ICollection<CustomerDTO> outputList = default(ICollection<CustomerDTO>);

        //public ICollection<CustomerDTO> GetAllCustomersfromDB()
        //{
        //    ICollection<CustomerDTO> outputList = default(ICollection<CustomerDTO>);

        //    try
        //    {
        //        // 1- Select All Customers From DB
        //        CustomerBusiness _CustomerBusiness = new CustomerBusiness();
        //        CustomerList _CustomerList = _CustomerBusiness.SelectRows(null, null, null, null, null);

        //        if (_CustomerList != null && _CustomerList.Count > 0)
        //        //outputList = Mapper.MapCustimerAsOutput();
        //        {
        //            // 2- Prepare Mapping Objects (Fill Values from DB)
        //            Mapper._CustomerList = fillCustomerList(); //default(List<Customer>);

        //            //Mapper._UserList = _UserList;
        //            //Mapper._UserGroupList = new List<UserGroup>(); //default(List<UserGroup>);
        //           // Mapper._GroupFunctionList = fillGroupFunctionList(); //default(List<GroupFunction>);

        //            //UserGroupBusiness _UserGroupBusiness = new UserGroupBusiness();
        //            //UserGroupList _UserGroupList = default(UserGroupList);

        //           foreach (Customer customer in _CustomerList)
        //            {





        //                }       



        //            // 3- Perform Mapping to Output
        //            outputList = Mapper.MapCustomersAsOutput();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log Exception Here
        //        throw; //new Exception(ex.Message);
        //    }

        //    return outputList;
        //}

        public CustomerDTO AddCustomerToDB(CustomerDTO cutomerDTO)
        {
            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Perform Mapping to  Input (for Saving in DB)
                    if (Mapper.MapCustomerAsInput(cutomerDTO))
                    {
                        ////User user = Mapper._User;
                        ////List<UserGroup> userGroups = Mapper._UserGroupListInput;
                        //Mapper._User.createDate = DateTime.Now;

                        // 2- Insert Customer in DB
                        CustomerBusiness customerBusiness = new CustomerBusiness();
                        if (customerBusiness.InsertRow(dbTransaction, Mapper._Customer) > 0)
                        {
                            dbTransaction.Commit();
                            cutomerDTO.Id = Mapper._Customer.Id;
                        }

                        else
                        {
                            dbTransaction.Rollback();
                            throw new DataException("DataBase Operation Failure");
                        }
                    }
                    else
                        throw new ArgumentNullException("customerDTO");
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    throw;
                }
            }

            return cutomerDTO;
        }

        public bool DeleteCustomerFromDB(int id)
        {
            bool result = default(bool);

            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Select Customer From DB by ID
                    CustomerBusiness customerBusiness = new CustomerBusiness();
                    CustomerList customerList = customerBusiness.SelectRows(id, null, null, null, null);

                    if (customerList != null && customerList.Count > 0)
                    {
                        foreach (Customer customer in customerList)
                        {
                            customerBusiness = new CustomerBusiness();
                            customerBusiness.DeleteRow(dbTransaction, customer);
                        }

                        dbTransaction.Commit();
                        result = true;
                    }

                    else
                    {
                        dbTransaction.Rollback();
                        throw new Exception("Customer Id Not Found in DB");
                    }
                }
                catch (Exception)
                {
                    dbTransaction.Rollback();
                    throw new Exception("DataBase Operation Failure");
                }
            }

            return result;
        }

        public ICollection<CustomerDTO> GetCustomersFromDB()
        {
            ICollection<CustomerDTO> outputList = default(ICollection<CustomerDTO>);

            try
            {
                // 1- Select All Customers From DB
                CustomerBusiness _CustomerBusiness = new CustomerBusiness();
                CustomerList _CustomerList = _CustomerBusiness.SelectRows(null, null, null, null, null);

                if (_CustomerList != null && _CustomerList.Count > 0)
                //outputList = Mapper.MapUserAsOutput();
                {
                    // 2- Prepare Mapping Objects (Fill Values from DB)
                    Mapper._CustomerList = fillCustomerList(); //default(List<Customer>);
                    Mapper._WorkFieldList = fillWorkFieldList();

                    // 3- Perform Mapping to Output
                    outputList = Mapper.MapCustomerAsOutput();
                }
            }
            catch (Exception ex)
            {
                // Log Exception Here
                throw; //new Exception(ex.Message);
            }

            return outputList;
        }

        public CustomerDTO GetCustomerByIDFromDB(int id)
        {
            {
                ICollection<CustomerDTO> outputList = default(ICollection<CustomerDTO>);
                CustomerDTO output = new CustomerDTO();

                try
                {
                    CustomerBusiness _CustomerBusiness = new CustomerBusiness();
                    CustomerList _CustomerList = _CustomerBusiness.SelectRows(id, null, null, null, null);

                    if (_CustomerList != null && _CustomerList.Count > 0)
                    //outputList = Mapper.MapUserAsOutput();
                    {
                        // 2- Prepare Mapping Objects (Fill Values from DB)
                        Mapper._CustomerList = _CustomerList; //fillCustomerList(); //default(List<Customers>);
                        Mapper._WorkFieldList = fillWorkFieldList();

                        // 3- Perform Mapping to Output
                        outputList = Mapper.MapCustomerAsOutput();

                        if (outputList != null && outputList.Count > 0)
                            output = outputList.First();
                    }
                }
                catch (Exception ex)
                {
                    // Log Exception Here
                    throw; //new Exception(ex.Message);
                }

                return output;
            }
        }

        public CustomerDTO UpdateCustomerinDB(CustomerDTO customerDTO)
        {
            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                
                {
                    // 1- Perform Mapping to  Input (for Saving in DB)
                    if (Mapper.MapCustomerAsInput(customerDTO))
                    {
                        // 2- Select Customer to be updated
                        CustomerBusiness customerBusiness = new CustomerBusiness();
                        CustomerList customerList = customerBusiness.SelectRows(Mapper._Customer.Id, null,null,null,null);

                        if (customerList != null && customerList.Count > 0)
                        {
                            customerList[0].code = Mapper._Customer.code;
                            customerList[0].name = Mapper._Customer.name;
                            customerList[0].nameAr = Mapper._Customer.nameAr;
                            customerList[0].address = Mapper._Customer.address;
                            customerList[0].phone = Mapper._Customer.phone;
                            customerList[0].email = Mapper._Customer.email;
                            customerList[0].workFieldId = Mapper._Customer.workFieldId;

                            // 3- Update Customer Data by Input Values
                            customerBusiness = new CustomerBusiness();
                            if (customerBusiness.UpdateRow(dbTransaction, customerList[0]) > 0)
                                dbTransaction.Commit();

                            else
                            {
                                dbTransaction.Rollback();
                                throw new Exception("DataBase Operation Failure");
                            }
                        }
                        else
                        {
                            dbTransaction.Rollback();
                            throw new Exception("Customer Id Not Found in DB");
                        }
                    }
                    else
                        throw new ArgumentNullException("customerDTO");
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    throw;
                }
            }

            return customerDTO;
        }

        #region Helpers

        private List<Customer> fillCustomerList()
        {
            CustomerBusiness _CustomerBusiness = new CustomerBusiness();
            CustomerList _CustomerList = _CustomerBusiness.SelectRows(null, null, null, null, null);

            return _CustomerList;
        }

        private List<WorkField> fillWorkFieldList()
        {
            WorkFieldBusiness _WorkFieldBusiness = new WorkFieldBusiness();
            WorkFieldList _WorkFieldList = _WorkFieldBusiness.SelectRows(null, null, null);

            return _WorkFieldList;
        }

        #endregion
    }
}
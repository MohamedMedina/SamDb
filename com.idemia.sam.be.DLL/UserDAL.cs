using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.idemia.sam.be.Contracts;
using Business;
using Common;
using DataAccess;
using ApplicationBlocks.Layers;
using com.idemia.sam.be.Helpers;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace com.idemia.sam.be.DAL
{
    public class UserDAL : IUserDAL
    {
        //public string ConnString;

        //public UserDAL(string ConnString)
        //{
        //    this.ConnString = ConnString;
        //}

        //public ICollection<UserDTO> GetAllUsersfromDB()
        //{
        //    ICollection<UserDTO> outputList = default(ICollection<UserDTO>);
        //    //IDbConnection con = new SqlConnection();

        //    //try
        //    //{
        //    //    con.ConnectionString = ConnString;
        //    //    con.Open();

        //    //    if (con.State == ConnectionState.Open)
        //    //    {
        //    //        // Open DB Connection
        //    //        UserBusiness _UserBusiness = new UserBusiness();
        //    //        UserList _UserList = _UserBusiness.SelectRows(null, null, null, null);

        //    //        con.Close();

        //    //        if (_UserList != null && _UserList.Count > 0)
        //    //            outputList = Mapper.MapOutside(_UserList);
        //    //    }
        //    //}
        //    //catch (Exception)
        //    //{
        //    //    // Log Error Here
        //    //}

        //    try
        //    {
        //        UserBusiness _UserBusiness = new UserBusiness();
        //        UserList _UserList = _UserBusiness.SelectRows(null, null, null, null);

        //        if (_UserList != null && _UserList.Count > 0)
        //            outputList = Mapper.MapOutside(_UserList);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log Exception Here
        //    }



        //    return outputList;
        //}

        public ICollection<UserDTO> GetAllUsersfromDB()
        {
            ICollection<UserDTO> outputList = default(ICollection<UserDTO>);

            try
            {
                // 1- Select All Users From DB
                UserBusiness _UserBusiness = new UserBusiness();
                UserList _UserList = _UserBusiness.SelectRows(null, null, null, null);

                if (_UserList != null && _UserList.Count > 0)
                //outputList = Mapper.MapUserAsOutput();
                {
                    // 2- Prepare Mapping Obects (Fill Values from DB)
                    Mapper._GroupList = fillGroupList(); //default(List<Group>);
                    Mapper._FunctionList = fillFunctionList(); //default(List<Function>);
                    Mapper._UserList = _UserList;
                    Mapper._UserGroupList = new List<UserGroup>(); //default(List<UserGroup>);
                    Mapper._GroupFunctionList = fillGroupFunctionList(); //default(List<GroupFunction>);

                    UserGroupBusiness _UserGroupBusiness = new UserGroupBusiness();
                    UserGroupList _UserGroupList = default(UserGroupList);

                    foreach (User _User in _UserList)
                    {
                        _UserGroupList = _UserGroupBusiness.SelectRows(null, _User.Id, null);

                        if (_UserGroupList != null && _UserGroupList.Count > 0)
                            foreach (UserGroup _UserGroup in _UserGroupList)
                                Mapper._UserGroupList.Add(Copier.copyUserGroup(_UserGroup));
                    }

                    // 3- Perform Mapping to Output
                    outputList = Mapper.MapUserAsOutput();
                }
            }
            catch (Exception ex)
            {
                // Log Exception Here
                throw; //new Exception(ex.Message);
            }

            return outputList;
        }

        public UserDTO GetUserByIDfromDB(int id)
        {
            ICollection<UserDTO> outputList = default(ICollection<UserDTO>);
            UserDTO output = new UserDTO();

            try
            {
                // 1- Select User From DB by ID
                UserBusiness _UserBusiness = new UserBusiness();
                UserList _UserList = _UserBusiness.SelectRows(id, null, null, null);

                if (_UserList != null && _UserList.Count > 0)
                //outputList = Mapper.MapUserAsOutput();
                {
                    // 2- Prepare Mapping Obects (Fill Values from DB)
                    Mapper._GroupList = fillGroupList(); //default(List<Group>);
                    Mapper._FunctionList = fillFunctionList(); //default(List<Function>);
                    Mapper._UserList = _UserList;
                    Mapper._UserGroupList = new List<UserGroup>(); //default(List<UserGroup>);
                    Mapper._GroupFunctionList = fillGroupFunctionList(); //default(List<GroupFunction>);

                    UserGroupBusiness _UserGroupBusiness = new UserGroupBusiness();
                    UserGroupList _UserGroupList = default(UserGroupList);

                    foreach (User _User in _UserList)
                    {
                        _UserGroupList = _UserGroupBusiness.SelectRows(null, _User.Id, null);

                        if (_UserGroupList != null && _UserGroupList.Count > 0)
                            foreach (UserGroup _UserGroup in _UserGroupList)
                                Mapper._UserGroupList.Add(Copier.copyUserGroup(_UserGroup));
                    }

                    // 3- Perform Mapping to Output
                    outputList = Mapper.MapUserAsOutput();

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

        public UserDTO AddUsertoDB(UserDTO userDTO)
        {
            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Perform Mapping to  Input (for Saving in DB)
                    if (Mapper.MapUserAsInput(userDTO))
                    {
                        //User user = Mapper._User;
                        //List<UserGroup> userGroups = Mapper._UserGroupListInput;
                        Mapper._User.createDate = DateTime.Now;

                        // 2- Insert User in DB
                        UserBusiness userBusiness = new UserBusiness();
                        if (userBusiness.InsertRow(dbTransaction, Mapper._User) > 0)
                        {
                            userDTO.Id = Mapper._User.Id;

                            if (Mapper._UserGroupListInput != null && Mapper._UserGroupListInput.Count > 0)
                            {
                                UserGroupBusiness userGroupBusiness = new UserGroupBusiness();

                                // 3- Insert User Groups in DB
                                foreach (UserGroup userGroup in Mapper._UserGroupListInput)
                                {
                                    userGroup.userId = Mapper._User.Id;

                                    userGroupBusiness = new UserGroupBusiness();
                                    userGroupBusiness.InsertRow(dbTransaction, userGroup);
                                }

                                dbTransaction.Commit();
                            }
                            else
                            {
                                dbTransaction.Rollback();
                                throw new Exception("DataBase Operation Failure");
                            }
                        }
                        else
                            throw new Exception("DataBase Operation Failure");
                    }
                    else
                        throw new ArgumentNullException("userDTO");
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    throw new Exception("DataBase Operation Failure");
                }
            }

            return userDTO;
        }

        public bool DeleteUserfromDB(int id)
        {
            bool result = default(bool);

            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Select User From DB by ID
                    UserBusiness userBusiness = new UserBusiness();
                    UserList userList = userBusiness.SelectRows(id, null, null, null);

                    if (userList != null && userList.Count > 0)
                    {
                        // 2- Select User Groups From DB by User ID
                        UserGroupBusiness userGroupBusiness = new UserGroupBusiness();
                        UserGroupList userGroupList = userGroupBusiness.SelectRows(null, id, null);

                        if (userGroupList != null && userGroupList.Count > 0)
                        {
                            // 3- Delete User Groups first (we must remove children first because of DB relation)
                            foreach (UserGroup userGroup in userGroupList)
                            {
                                userGroupBusiness = new UserGroupBusiness();
                                userGroupBusiness.DeleteRow(dbTransaction, userGroup);
                            }
                        }

                        // 4- Then Delete The User itself
                        userBusiness = new UserBusiness();
                        if (userBusiness.DeleteRow(dbTransaction, userList[0]) > 0)
                        {
                            dbTransaction.Commit();
                            result = true;
                        }
                        else
                        {
                            dbTransaction.Rollback();
                            throw new Exception("DataBase Operation Failure");
                        }
                    }
                    else
                    {
                        dbTransaction.Rollback();
                        throw new Exception("User Id Not Found in DB");
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

        public UserDTO UpdateUserinDB(UserDTO userDTO)
        {
            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Perform Mapping to  Input (for Saving in DB)
                    if (Mapper.MapUserAsInput(userDTO))
                    {
                        ////User user = Mapper._User;
                        ////List<UserGroup> userGroups = Mapper._UserGroupListInput;

                        //UserBusiness userBusiness = new UserBusiness();
                        //if (userBusiness.InsertRow(dbTransaction, Mapper._User) > 0)
                        //{
                        //    UserGroupBusiness userGroupBusiness = new UserGroupBusiness();

                        //    if (Mapper._UserGroupListInput != null && Mapper._UserGroupListInput.Count > 0)
                        //    {
                        //        foreach (UserGroup userGroup in Mapper._UserGroupListInput)
                        //        {
                        //            userGroup.userId = Mapper._User.Id;

                        //            userGroupBusiness = new UserGroupBusiness();
                        //            userGroupBusiness.InsertRow(dbTransaction, userGroup);
                        //        }

                        //        dbTransaction.Commit();
                        //    }
                        //    else
                        //        dbTransaction.Rollback();
                        //}
                        //else
                        //    throw new DataException("DataBase Operation Failure");

                        // 2- Select User to be updated
                        UserBusiness userBusiness = new UserBusiness();
                        UserList userList = userBusiness.SelectRows(Mapper._User.Id, null, null, null);

                        if (userList != null && userList.Count > 0)
                        {
                            userList[0].userName = Mapper._User.userName;
                            userList[0].fullName = Mapper._User.fullName;
                            userList[0].Password = Mapper._User.Password;
                            userList[0].status = Mapper._User.status;

                            // 3- Update User Data by Input Values
                            userBusiness = new UserBusiness();
                            if (userBusiness.UpdateRow(dbTransaction, userList[0]) > 0)
                            {
                                // 4- Remove User Groups Already Saved for that User in DB
                                UserGroupBusiness userGroupBusiness = new UserGroupBusiness();
                                UserGroupList userGroupList = userGroupBusiness.SelectRows(null, Mapper._User.Id, null);

                                if (userGroupList != null && userGroupList.Count > 0)
                                {
                                    //foreach (UserGroup userGroup in Mapper._UserGroupList)
                                    //{
                                    //    userGroupBusiness = new UserGroupBusiness();
                                    //    userGroupBusiness.DeleteRow(dbTransaction, userGroup);
                                    //}

                                    foreach (UserGroup userGroup in userGroupList)
                                    {
                                        userGroupBusiness = new UserGroupBusiness();
                                        userGroupBusiness.DeleteRow(dbTransaction, userGroup);
                                    }
                                }

                                // 5- Add New User Groups from Input
                                if (Mapper._UserGroupListInput != null && Mapper._UserGroupListInput.Count > 0)
                                {
                                    foreach (UserGroup userGroup in Mapper._UserGroupListInput)
                                    {
                                        userGroupBusiness = new UserGroupBusiness();
                                        userGroupBusiness.InsertRow(dbTransaction, userGroup);
                                    }

                                    dbTransaction.Commit();
                                }
                            }
                            else
                            {
                                dbTransaction.Rollback();
                                throw new Exception("DataBase Operation Failure");
                            }
                        }
                        else
                            throw new Exception("User Id Not Found in DB");
                    }
                    else
                        throw new ArgumentNullException("userDTO");
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    throw new Exception("DataBase Operation Failure");
                }
            }

            return userDTO;
        }

        private List<GroupFunction> fillGroupFunctionList()
        {
            GroupFunctionBusiness _GroupBusiness = new GroupFunctionBusiness();
            GroupFunctionList _GroupFunctionList = _GroupBusiness.SelectRows(null, null, null);

            return _GroupFunctionList;
        }

        private List<Group> fillGroupList()
        {
            GroupBusiness _GroupBusiness = new GroupBusiness();
            GroupList _GroupList = _GroupBusiness.SelectRows(null, null);

            return _GroupList;
        }

        private List<Function> fillFunctionList()
        {
            FunctionBusiness _FunctionBusiness = new FunctionBusiness();
            FunctionList _FunctionList = _FunctionBusiness.SelectRows(null, null, null);

            return _FunctionList;
        }

    }
}

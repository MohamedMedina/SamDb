using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using ApplicationBlocks.Layers;
using Business;
using com.idemia.sam.be.Contracts;
using com.idemia.sam.be.DAL;
using com.idemia.sam.be.Helpers;
using Common;

namespace com.idemia.sam.be.DAL
{
    public class GroupDAL : IGroupDAL
    {
        public GroupDTO AddGrouptoDB(GroupDTO groupDTO)
        {
            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Perform Mapping to  Input (for Saving in DB)
                    if (Mapper.MapGroupAsInput(groupDTO))
                    {
                        ////User user = Mapper._User;
                        ////List<UserGroup> userGroups = Mapper._UserGroupListInput;
                        //Mapper._User.createDate = DateTime.Now;

                        // 2- Insert Group in DB
                        GroupBusiness groupBusiness = new GroupBusiness();
                        if (groupBusiness.InsertRow(dbTransaction, Mapper._Group) > 0)
                        {
                            groupDTO.Id = Mapper._Group.Id;

                            if (Mapper._GroupFunctionListInput != null && Mapper._GroupFunctionListInput.Count > 0)
                            {
                                GroupFunctionBusiness groupFunctionBusiness = new GroupFunctionBusiness();

                                // 3- Insert Group Functions in DB
                                foreach (GroupFunction groupFunction in Mapper._GroupFunctionListInput)
                                {
                                    groupFunction.groupId = Mapper._Group.Id;

                                    groupFunctionBusiness = new GroupFunctionBusiness();
                                    groupFunctionBusiness.InsertRow(dbTransaction, groupFunction);
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
                            throw new Exception("Group Id Not Found in DB");
                    }
                    else
                        throw new ArgumentNullException("groupDTO");
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    throw new Exception("DataBase Operation Failure");
                }
            }

            return groupDTO;
        }

        public bool DeleteGroupfromDB(int id)
        {
            bool result = default(bool);

            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Select User From DB by ID
                    GroupBusiness groupBusiness = new GroupBusiness();
                    GroupList groupList = groupBusiness.SelectRows(id, null);

                    if (groupList != null && groupList.Count > 0)
                    {
                        // 2- Select Group Functions From DB by Group ID
                        GroupFunctionBusiness _GroupFunctionBusiness  = new GroupFunctionBusiness();
                        GroupFunctionList groupFunctionList = _GroupFunctionBusiness.SelectRows(null, null, id);

                        if (groupFunctionList != null && groupFunctionList.Count > 0)
                        {
                            // 3- Delete Group Functions first (we must remove children first because of DB relation)
                            foreach (GroupFunction groupFunction in groupFunctionList)
                            {
                                _GroupFunctionBusiness = new GroupFunctionBusiness();
                                _GroupFunctionBusiness.DeleteRow(dbTransaction, groupFunction);
                            }
                        }

                        // 4- Then Delete The Group itself
                        groupBusiness = new GroupBusiness();
                        if (groupBusiness.DeleteRow(dbTransaction, groupList[0]) > 0)
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
                        throw new Exception("Group Id Not Found in DB");
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

        public ICollection<GroupDTO> GetAllGroupsfromDB()
        {
            ICollection<GroupDTO> outputList = default(ICollection<GroupDTO>);

            try
            {
                // 1- Select All Groups From DB
                GroupBusiness _GroupBusiness = new GroupBusiness();
                GroupList _GroupList = _GroupBusiness.SelectRows(null, null);

                if (_GroupList != null && _GroupList.Count > 0)
                //outputList = Mapper.MapUserAsOutput();
                {
                    // 2- Prepare Mapping Obects (Fill Values from DB)
                    Mapper._GroupList = _GroupList; //default(List<Group>);
                    Mapper._FunctionList = fillFunctionList(); //default(List<Function>);
                    //Mapper._UserList = _UserList;
                    //Mapper._UserGroupList = new List<UserGroup>(); //default(List<UserGroup>);
                    Mapper._GroupFunctionList = fillGroupFunctionList(); //default(List<GroupFunction>);

                    //UserGroupBusiness _UserGroupBusiness = new UserGroupBusiness();
                    //UserGroupList _UserGroupList = default(UserGroupList);

                    //foreach (User _User in _UserList)
                    //{
                    //    _UserGroupList = _UserGroupBusiness.SelectRows(null, _User.Id, null);

                    //    if (_UserGroupList != null && _UserGroupList.Count > 0)
                    //        foreach (UserGroup _UserGroup in _UserGroupList)
                    //            Mapper._UserGroupList.Add(Copier.copyUserGroup(_UserGroup));
                    //}


                    // 3- Perform Mapping to Output
                    outputList = Mapper.MapGroupAsOutput();
                }
            }
            catch (Exception ex)
            {
                // Log Exception Here
                throw; //new Exception(ex.Message);
            }

            return outputList;
        }

        public GroupDTO GetGroupByIDfromDB(int id)
        {
            ICollection<GroupDTO> outputList = default(ICollection<GroupDTO>);
            GroupDTO output = new GroupDTO();

            try
            {
                GroupBusiness _GroupBusiness = new GroupBusiness();
                GroupList _GroupList = _GroupBusiness.SelectRows(id, null);

                if (_GroupList != null && _GroupList.Count > 0)
                //outputList = Mapper.MapUserAsOutput();
                {
                    // 2- Prepare Mapping Obects (Fill Values from DB)
                    Mapper._GroupList = fillGroupList(); //default(List<Group>);
                    Mapper._FunctionList = fillFunctionList(); //default(List<Function>);
                    //Mapper._UserList = _UserList;
                    //Mapper._UserGroupList = new List<UserGroup>(); //default(List<UserGroup>);
                    Mapper._GroupFunctionList = fillGroupFunctionList(); //default(List<GroupFunction>);

                    //UserGroupBusiness _UserGroupBusiness = new UserGroupBusiness();
                    //UserGroupList _UserGroupList = default(UserGroupList);

                    //foreach (User _User in _UserList)
                    //{
                    //    _UserGroupList = _UserGroupBusiness.SelectRows(null, _User.Id, null);

                    //    if (_UserGroupList != null && _UserGroupList.Count > 0)
                    //        foreach (UserGroup _UserGroup in _UserGroupList)
                    //            Mapper._UserGroupList.Add(Copier.copyUserGroup(_UserGroup));
                    //}

                    // 3- Perform Mapping to Output
                    outputList = Mapper.MapGroupAsOutput();

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

        public GroupDTO UpdateGroupinDB(GroupDTO groupDTO)
        {
            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Perform Mapping to  Input (for Saving in DB)
                    if (Mapper.MapGroupAsInput(groupDTO))
                    {
                        // 2- Select Group to be updated
                        GroupBusiness groupBusiness = new GroupBusiness();
                        GroupList groupList = groupBusiness.SelectRows(Mapper._Group.Id, null);

                        if (groupList != null && groupList.Count > 0)
                        {
                            groupList[0].name = Mapper._Group.name;
                            groupList[0].status = Mapper._Group.status;

                            // 3- Update Group Data by Input Values
                            groupBusiness = new GroupBusiness();
                            if (groupBusiness.UpdateRow(dbTransaction, groupList[0]) > 0)
                            {
                                // 4- Remove Group Functions Already Saved for that Group in DB
                                GroupFunctionBusiness groupFunctionBusiness = new GroupFunctionBusiness();
                                GroupFunctionList groupFunctionList = groupFunctionBusiness.SelectRows(null, null, Mapper._Group.Id);

                                if (groupFunctionList != null && groupFunctionList.Count > 0)
                                {
                                    foreach (GroupFunction groupFunction in groupFunctionList)
                                    {
                                        groupFunctionBusiness = new GroupFunctionBusiness();
                                        groupFunctionBusiness.DeleteRow(dbTransaction, groupFunction);
                                    }
                                }

                                // 5- Add New Group Functions from Input
                                if (Mapper._GroupFunctionListInput != null && Mapper._GroupFunctionListInput.Count > 0)
                                {
                                    foreach (GroupFunction groupFunction in Mapper._GroupFunctionListInput)
                                    {
                                        groupFunctionBusiness = new GroupFunctionBusiness();
                                        groupFunctionBusiness.InsertRow(dbTransaction, groupFunction);
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
                            throw new Exception("Group Id Not Found in DB");
                    }
                    else
                        throw new ArgumentNullException("groupDTO");
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    throw new Exception("DataBase Operation Failure");
                }
            }

            return groupDTO;
        }

        #region Helpers

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

        #endregion
    }
}
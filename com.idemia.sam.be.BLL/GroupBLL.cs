using System;
using System.Collections.Generic;
using com.idemia.sam.be.BLL;
using com.idemia.sam.be.Contracts;
using com.idemia.sam.be.DAL;

namespace com.idemia.sam.be.User_Management.Controllers
{
    public class GroupBLL : IGroupBLL
    {
        IGroupDAL _IGroupDAL;

        public GroupBLL()
        {
            _IGroupDAL = new GroupDAL();
        }

        public GroupDTO AddGroup(GroupDTO groupDTO)
        {
            try
            {
                return _IGroupDAL.AddGrouptoDB(groupDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteGroup(int id)
        {
            try
            {
                return _IGroupDAL.DeleteGroupfromDB(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<GroupDTO> GetAllGroups()
        {
            try
            {
                return _IGroupDAL.GetAllGroupsfromDB();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public GroupDTO GetGroupbyID(int id)
        {
            try
            {
                return _IGroupDAL.GetGroupByIDfromDB(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public GroupDTO UpdateGroup(GroupDTO groupDTO)
        {
            try
            {
                return _IGroupDAL.UpdateGroupinDB(groupDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
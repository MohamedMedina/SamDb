using System.Collections.Generic;
using com.idemia.sam.be.Contracts;
using com.idemia.sam.be.Helpers;

namespace com.idemia.sam.be.DAL
{
    public interface IGroupDAL
    {
        GroupDTO AddGrouptoDB(GroupDTO groupDTO);

        bool DeleteGroupfromDB(int id);

        ICollection<GroupDTO> GetAllGroupsfromDB();

        GroupDTO GetGroupByIDfromDB(int id);

        GroupDTO UpdateGroupinDB(GroupDTO groupDTO);
    }
}
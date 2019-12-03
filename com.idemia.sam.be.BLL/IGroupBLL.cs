using com.idemia.sam.be.Contracts;
using System.Collections.Generic;

namespace com.idemia.sam.be.BLL
{
    public interface IGroupBLL
    {
        ICollection<GroupDTO> GetAllGroups();

        GroupDTO GetGroupbyID(int id);

        GroupDTO AddGroup(GroupDTO groupDTO);

        bool DeleteGroup(int id);

        GroupDTO UpdateGroup(GroupDTO groupDTO);
    }
}
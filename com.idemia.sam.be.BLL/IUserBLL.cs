using com.idemia.sam.be.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.idemia.sam.be.BLL
{
    public interface IUserBLL
    {
        ICollection<UserDTO> GetAllUsers();

        UserDTO GetUserbyID(int id);

        UserDTO AddUser(UserDTO userDTO);

        bool DeleteUser(int id);

        UserDTO UpdateUser(UserDTO userDTO);
    }
}

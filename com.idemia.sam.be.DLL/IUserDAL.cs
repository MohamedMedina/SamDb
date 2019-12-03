using com.idemia.sam.be.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.idemia.sam.be.DAL
{
    public interface IUserDAL
    {
        ICollection<UserDTO> GetAllUsersfromDB();

        UserDTO GetUserByIDfromDB(int id);

        UserDTO AddUsertoDB(UserDTO userDTO);

        bool DeleteUserfromDB(int id);

        UserDTO UpdateUserinDB(UserDTO userDTO);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.idemia.sam.be.Contracts;
using com.idemia.sam.be.DAL;

namespace com.idemia.sam.be.BLL
{
    public class UserBLL : IUserBLL
    {
        IUserDAL _IUserDAL;

        public UserBLL()
        {
            _IUserDAL = new UserDAL();
        }

        public UserDTO AddUser(UserDTO userDTO)
        {
            try
            {
                return _IUserDAL.AddUsertoDB(userDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<UserDTO> GetAllUsers()
        {
            try
            {
                return _IUserDAL.GetAllUsersfromDB();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public UserDTO GetUserbyID(int id)
        {
            try
            {
                return _IUserDAL.GetUserByIDfromDB(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                return _IUserDAL.DeleteUserfromDB(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public UserDTO UpdateUser(UserDTO userDTO)
        {
            try
            {
                return _IUserDAL.UpdateUserinDB(userDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

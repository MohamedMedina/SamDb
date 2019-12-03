using com.idemia.sam.be.BLL;
using com.idemia.sam.be.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace com.idemia.sam.be.User_Management.Controllers
{
    public class UsersController : ApiController
    {
        IUserBLL _IUserBLL;

        public UsersController()
        {
            _IUserBLL = new UserBLL();
        }

        public HttpResponseMessage GetUsers()
        {
            try
            {
                List<UserDTO> _Output = _IUserBLL.GetAllUsers().ToList();
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        public HttpResponseMessage GetUser(int id)
        {
            try
            {
                UserDTO _Output = _IUserBLL.GetUserbyID(id);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage AddUser(UserDTO userDTO)
        {
            try
            {
                if (userDTO == null)
                    throw new ArgumentNullException("userDTO");

                UserDTO _Output = _IUserBLL.AddUser(userDTO);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        public HttpResponseMessage DeleteUser(int id)
        {
            try
            {
                if (_IUserBLL.DeleteUser(id))
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
        public HttpResponseMessage UpdateUser(UserDTO userDTO)
        {
            try
            {
                if (userDTO == null)
                    throw new ArgumentNullException("userDTO");

                UserDTO _Output = _IUserBLL.UpdateUser(userDTO);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}

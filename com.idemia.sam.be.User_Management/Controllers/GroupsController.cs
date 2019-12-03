using com.idemia.sam.be.BLL;
using com.idemia.sam.be.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace com.idemia.sam.be.User_Management.Controllers
{
    public class GroupsController : ApiController
    {
        //IUserBLL _IUserBLL;
        IGroupBLL _IGroupBLL;

        public GroupsController()
        {
            _IGroupBLL = new GroupBLL();
        }

        public HttpResponseMessage GetGroups()
        {
            try
            {
                List<GroupDTO> _Output = _IGroupBLL.GetAllGroups().ToList();
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        public HttpResponseMessage GetGroup(int id)
        {
            try
            {
                GroupDTO _Output = _IGroupBLL.GetGroupbyID(id);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage AddGroup(GroupDTO groupDTO)
        {
            try
            {
                if (groupDTO == null)
                    throw new ArgumentNullException("groupDTO");

                GroupDTO _Output = _IGroupBLL.AddGroup(groupDTO);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        public HttpResponseMessage DeleteGroup(int id)
        {
            try
            {
                if (_IGroupBLL.DeleteGroup(id))
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
        public HttpResponseMessage UpdateGroup(GroupDTO groupDTO)
        {
            try
            {
                if (groupDTO == null)
                    throw new ArgumentNullException("groupDTO");

                GroupDTO _Output = _IGroupBLL.UpdateGroup(groupDTO);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}

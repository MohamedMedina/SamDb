using com.idemia.sam.be.BLL;
using com.idemia.sam.be.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace com.idemia.sam.be.Request_Management.Controllers
{
    public class WorkFieldController : ApiController

    {
        private WorkFieldBLL _IWorkFieldBLL;


        public WorkFieldController()
        {
            _IWorkFieldBLL = new WorkFieldBLL();
        }

        public HttpResponseMessage GetWorkField()
        {
            try
            {
                List<WorkFieldDTO> _Output = _IWorkFieldBLL.GetAllWorkField().ToList();
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        public HttpResponseMessage GetWorkFieldByIdentity(int id)
        {
            try
            {

                WorkFieldDTO _Output = _IWorkFieldBLL.GetWorkFieldByID(id);

                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage AddWorkField(WorkFieldDTO workFieldDTO)
        {
            try
            {
                if (workFieldDTO == null)
                    throw new ArgumentNullException("workFieldDTO");

                WorkFieldDTO _Output = _IWorkFieldBLL.AddWorkField(workFieldDTO);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpDelete]
        public HttpResponseMessage DeleteWorkField(int id)
        {
            try
            {
                if (_IWorkFieldBLL.DeleteWorkField(id))
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
        public HttpResponseMessage UpdateWorkField(WorkFieldDTO workFieldDTO)
        {
            try
            {
                if (workFieldDTO == null)
                    throw new ArgumentNullException("workFieldDTO");

                WorkFieldDTO _Output = _IWorkFieldBLL.UpdateWorkField(workFieldDTO);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




    }
}
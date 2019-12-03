using com.idemia.sam.be.BLL;
using com.idemia.sam.be.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using com.idemia.sam.be.Helpers;

namespace com.idemia.sam.be.Request_Management.Controllers
{
    public class RequestsController : ApiController
    {
        IRequestBLL _IRequestBLL;

        public RequestsController()
        {
            _IRequestBLL = new RequestBLL();
        }

        public HttpResponseMessage GetRequests()
        {
            try
            {
                List<RequestDTO> _Output = _IRequestBLL.GetAllRequests().ToList();
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        public HttpResponseMessage GetRequest(int id)
        {
            try
            {
                RequestDTO _Output = _IRequestBLL.GetRequestbyID(id);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Route("api/requests/created")]
        public HttpResponseMessage GetRequestsbyStatus()
        {
            try
            {
                List<RequestDTO> _Output = _IRequestBLL.GetAllRequestsbyStatus((int)(RequestStatusEnum.Created)).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage AddRequest(RequestDTO requestDTO)
        {
            try
            {
                if (requestDTO == null)
                    throw new ArgumentNullException("requestDTO");

                RequestDTO _Output = _IRequestBLL.AddRequest(requestDTO);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/requests/search")]
        public HttpResponseMessage SearchRequest(RequestSearchDTO requestSearchDTO)
        {
            try
            {
                if (requestSearchDTO == null)
                    throw new ArgumentNullException("requestSearchDTO");

                List<RequestDTO> _Output = _IRequestBLL.SearchRequest(requestSearchDTO);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public HttpResponseMessage UpdateRequest(RequestDTO requestDTO)
        {
            try
            {
                if (requestDTO == null)
                    throw new ArgumentNullException("requestDTO");

                RequestDTO _Output = _IRequestBLL.UpdateRequest(requestDTO);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}

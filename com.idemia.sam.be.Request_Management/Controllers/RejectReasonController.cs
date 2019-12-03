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
    public class RejectReasonController : ApiController
    {
        private RejectReasonBLL  _IRejectReasonBLL;

        public RejectReasonController()
        {
            _IRejectReasonBLL = new RejectReasonBLL();

        }

        public HttpResponseMessage GetRejectReason()
        {
            try
            {
                List<RejectReasonDTO> _Output = _IRejectReasonBLL.GetRejectReason().ToList();
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        public HttpResponseMessage GetRejectReasonByIdentity(int id)
        {
            try
            {

                RejectReasonDTO _Output = _IRejectReasonBLL.GetRejectReasonByID(id);

                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage AddRejectReason(RejectReasonDTO rejectReasonDTO)
        {
            try
            {
                if (rejectReasonDTO == null)
                    throw new ArgumentNullException("rejectReasonDTO");

                RejectReasonDTO _Output = _IRejectReasonBLL.AddRejectReason(rejectReasonDTO);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public HttpResponseMessage UpdateRejectReason(RejectReasonDTO rejectReasonDTO)
        {
            try
            {
                if (rejectReasonDTO == null)
                    throw new ArgumentNullException("rejectReasonDTO");

                RejectReasonDTO _Output = _IRejectReasonBLL.UpdateRejectReason(rejectReasonDTO);
                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpDelete]
        public HttpResponseMessage DeleteRejectReason(int id)
        {
            try
            {
                if (_IRejectReasonBLL.DeleteRejectReason(id))
                    return Request.CreateResponse(HttpStatusCode.OK);
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Operation Not Completed");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}

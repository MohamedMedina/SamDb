using System;
using System.Collections.Generic;
using com.idemia.sam.be.BLL;
using com.idemia.sam.be.Contracts;
using com.idemia.sam.be.DAL;

namespace com.idemia.sam.be.BLL
{
    public class RequestBLL : IRequestBLL
    {
        IRequestDAL _IRequestDAL;

        public RequestBLL()
        {
            _IRequestDAL = new RequestDAL();
        }

        public RequestDTO AddRequest(RequestDTO requestDTO)
        {
            try
            {
                return _IRequestDAL.AddRequesttoDB(requestDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<RequestDTO> GetAllRequests()
        {
            try
            {
                return _IRequestDAL.GetAllRequestsfromDB();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<RequestDTO> GetAllRequestsbyStatus(int status)
        {
            try
            {
                return _IRequestDAL.GetAllRequestsByStatusfromDB(status);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RequestDTO GetRequestbyID(int id)
        {
            try
            {
                return _IRequestDAL.GetRequestByIDfromDB(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<RequestDTO> SearchRequest(RequestSearchDTO requestSearchDTO)
        {
            try
            {
                return _IRequestDAL.SearchRequestinDB(requestSearchDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RequestDTO UpdateRequest(RequestDTO requestDTO)
        {
            try
            {
                return _IRequestDAL.UpdateRequestinDB(requestDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
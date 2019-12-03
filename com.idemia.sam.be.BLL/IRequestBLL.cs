using com.idemia.sam.be.Contracts;
using System.Collections.Generic;

namespace com.idemia.sam.be.BLL
{
    public interface IRequestBLL
    {
        RequestDTO AddRequest(RequestDTO requestDTO);
        ICollection<RequestDTO> GetAllRequests();
        RequestDTO GetRequestbyID(int id);
        ICollection<RequestDTO> GetAllRequestsbyStatus(int Status);
        RequestDTO UpdateRequest(RequestDTO requestDTO);
        List<RequestDTO> SearchRequest(RequestSearchDTO requestSearchDTO);
    }
}
using System.Collections.Generic;
using com.idemia.sam.be.Contracts;

namespace com.idemia.sam.be.DAL
{
    public interface IRequestDAL
    {
        RequestDTO AddRequesttoDB(RequestDTO requestDTO);
        ICollection<RequestDTO> GetAllRequestsfromDB();
        RequestDTO GetRequestByIDfromDB(int id);
        ICollection<RequestDTO> GetAllRequestsByStatusfromDB(int status);
        RequestDTO UpdateRequestinDB(RequestDTO requestDTO);
        List<RequestDTO> SearchRequestinDB(RequestSearchDTO requestSearchDTO);
    }
}
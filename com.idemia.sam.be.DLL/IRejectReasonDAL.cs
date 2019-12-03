using com.idemia.sam.be.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.idemia.sam.be.DAL

{
    public interface IRejectReasonDAL
    {
        ICollection<RejectReasonDTO> GetAllRejectReasonFromDB();
        RejectReasonDTO AddRejectReasonToDB(RejectReasonDTO rejectReasonDTO);
        RejectReasonDTO UpdateRejectReasonInDB(RejectReasonDTO rejectReasonDTO);
        bool DeleteRejectReasonFromDB(int id);


    }
}

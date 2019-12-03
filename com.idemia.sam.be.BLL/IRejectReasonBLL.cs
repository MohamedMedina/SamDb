using com.idemia.sam.be.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.idemia.sam.be.BLL
{
    public interface IRejectReasonBLL
    {

        ICollection<RejectReasonDTO> GetRejectReason();
        RejectReasonDTO GetRejectReasonByID(int id);
        RejectReasonDTO AddRejectReason(RejectReasonDTO rejectReasonDTO);
        RejectReasonDTO UpdateRejectReason(RejectReasonDTO rejectReasonDTO);
        bool DeleteRejectReason(int id);
    }
}

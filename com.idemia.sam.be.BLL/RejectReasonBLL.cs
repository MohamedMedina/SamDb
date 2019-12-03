using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.idemia.sam.be.Contracts;
using com.idemia.sam.be.DAL;

namespace com.idemia.sam.be.BLL
{
    public class RejectReasonBLL : IRejectReasonBLL

    {
        RejectReasonDAL _IRejectReasonDAL;
        public RejectReasonBLL()
        {
            _IRejectReasonDAL = new RejectReasonDAL();

        }

        public RejectReasonDTO AddRejectReason(RejectReasonDTO rejectReasonDTO)
        {

            try
            {
                return _IRejectReasonDAL.AddRejectReasonToDB(rejectReasonDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ICollection<RejectReasonDTO> GetRejectReason()
        {

            try
            {
                return _IRejectReasonDAL.GetAllRejectReasonFromDB();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RejectReasonDTO GetRejectReasonByID(int id)
        {
            try
            {
                return _IRejectReasonDAL.GetRejectReasonByIDFromDB(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RejectReasonDTO UpdateRejectReason(RejectReasonDTO rejectReasonDTO)
        {
            try
            {
                return _IRejectReasonDAL.UpdateRejectReasonInDB(rejectReasonDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool DeleteRejectReason(int id)
        {
            try
            {
                return _IRejectReasonDAL.DeleteRejectReasonFromDB(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

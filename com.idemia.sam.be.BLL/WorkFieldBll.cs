using com.idemia.sam.be.Contracts;
using com.idemia.sam.be.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.idemia.sam.be.BLL
{
   public class WorkFieldBLL :IWorkFieldBLL
    {

        IWorkFieldDAL _IWorkFieldDAL;
        public WorkFieldBLL()
        {
            _IWorkFieldDAL = new WorkFieldDAL();

        }

      
        
        // here is the method to return a collection of work feild
        public ICollection<WorkFieldDTO> GetAllWorkField()
        {

            try
            {
                return _IWorkFieldDAL.GetAllWorkFieldFromDB();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public WorkFieldDTO GetWorkFieldByID(int id)
        {
            try
            {
                return _IWorkFieldDAL.GetWorkFieldFromDB(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public WorkFieldDTO AddWorkField(WorkFieldDTO workFieldDTO)
        {
            try
            {
                return _IWorkFieldDAL.AddWorkFieldToDB(workFieldDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteWorkField(int id)
        {
            try
            {
                return _IWorkFieldDAL.DeleteWorkFieldFromDB(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public WorkFieldDTO UpdateWorkField(WorkFieldDTO workFieldDTO)
        {
            try
            {
                return _IWorkFieldDAL.UpdateWorkFieldInDB(workFieldDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}

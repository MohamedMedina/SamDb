using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.idemia.sam.be.Contracts;

namespace com.idemia.sam.be.DAL
{
    public interface IWorkFieldDAL
    {
        ICollection<WorkFieldDTO> GetAllWorkFieldFromDB();
        WorkFieldDTO GetWorkFieldFromDB(int id);
        WorkFieldDTO AddWorkFieldToDB(WorkFieldDTO workFieldDTO);
        bool DeleteWorkFieldFromDB(int id);
        WorkFieldDTO UpdateWorkFieldInDB(WorkFieldDTO workFieldDTO);
    }
}

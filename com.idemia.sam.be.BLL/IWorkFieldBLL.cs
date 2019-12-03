using com.idemia.sam.be.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.idemia.sam.be.BLL
{
     public interface IWorkFieldBLL

    {

        ICollection<WorkFieldDTO> GetAllWorkField();
        WorkFieldDTO GetWorkFieldByID(int id);

        WorkFieldDTO AddWorkField(WorkFieldDTO workFieldDTO);
        bool DeleteWorkField(int id);
        WorkFieldDTO UpdateWorkField(WorkFieldDTO workFieldDTO);
    }
}

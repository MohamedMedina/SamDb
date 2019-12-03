using System;
using System.Collections.Generic;

namespace com.idemia.sam.be.Contracts
{
    public class GroupDTO
    {
        public int Id { get; set; }
        public string name { get; set; }
        public Nullable<bool> status { get; set; }
        public ICollection<FunctionDTO> GroupFunctions { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace com.idemia.sam.be.Contracts
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string fullName { get; set; }
        public string Password { get; set; }
        public Nullable<bool> status { get; set; }
        public string createDate { get; set; }
        public ICollection<GroupDTO> UserGroups { get; set; }
    }
}

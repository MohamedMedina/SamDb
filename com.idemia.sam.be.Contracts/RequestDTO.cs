using System.Collections.Generic;

namespace com.idemia.sam.be.Contracts
{
    public class RequestDTO
    {
        public int Id { get; set; }
        public string requestNumber { get; set; }
        public int totalQuantity { get; set; }
        public string PDD { get; set; }
        public CustomerDTO customerID { get; set; }
        public string creationDate { get; set; }
        public UserDTO creationUserID { get; set; }
        public string approvalDate { get; set; }
        public UserDTO approvalUserID { get; set; }
        public string receiveDate { get; set; }
        public UserDTO receiveUserID { get; set; }
        public string rejectionDate { get; set; }
        public UserDTO rejectionUserID { get; set; }
        public RejectReasonDTO rejectionReasonID { get; set; }
        public RequestTypeDTO requestTypeID { get; set; }
        public RequestStatusDTO requestStatusID { get; set; }
        public RequestClassDTO requestCalssID { get; set; }
        public RequestPriorityDTO requestPriorityID { get; set; }
        public ICollection<RequestDetailDTO> RequestDetailList { get; set; }
    }
}

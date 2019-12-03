using System;

namespace com.idemia.sam.be.Contracts
{
    public class RequestSearchDTO
    {
        public int Id { get; set; }
        public string requestNumber { get; set; }
        public int totalQuantity { get; set; }
        public DateTime?  PDDFrom { get; set; }
        public DateTime? PDDTo { get; set; }
        public string PDDFromString { get; set; }
        public string PDDToString { get; set; }
        public CustomerDTO customerID { get; set; }
        public DateTime? creationDateFrom { get; set; }
        public DateTime? creationDateTo { get; set; }
        public string creationDateFromString { get; set; }
        public string creationDateToString { get; set; }
        public UserDTO creationUserID { get; set; }
        public DateTime? approvalDateFrom { get; set; }
        public DateTime? approvalDateTo { get; set; }
        public string approvalDateFromString { get; set; }
        public string approvalDateToString { get; set; }
        public UserDTO approvalUserID { get; set; }
        public DateTime? receiveDateFrom { get; set; }
        public DateTime? receiveDateTo { get; set; }
        public string receiveDateFromString { get; set; }
        public string receiveDateToString { get; set; }
        public UserDTO receiveUserID { get; set; }
        public DateTime? rejectionDateFrom { get; set; }
        public DateTime? rejectionDateTo { get; set; }
        public string rejectionDateFromString { get; set; }
        public string rejectionDateToString { get; set; }
        public UserDTO rejectionUserID { get; set; }
        public RejectReasonDTO rejectionReasonID { get; set; }
        public RequestTypeDTO requestTypeID { get; set; }
        public RequestStatusDTO requestStatusID { get; set; }
        public RequestClassDTO requestCalssID { get; set; }
        public RequestPriorityDTO requestPriorityID { get; set; }
        public CardTypeDTO cardTypeDTO { get; set; }
    }
}
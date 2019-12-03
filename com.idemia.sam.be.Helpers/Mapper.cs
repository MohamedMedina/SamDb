using com.idemia.sam.be.Contracts;
using Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.idemia.sam.be.Helpers
{
    public class Mapper
    {
        /// <summary>
        /// Input Items to be Mapped as Output DTO (User or Group) as One Unit
        /// </summary>
        public static List<Group> _GroupList; // Lookups
        public static List<Function> _FunctionList; // Lookups
        public static List<User> _UserList;
        public static List<UserGroup> _UserGroupList;
        public static List<GroupFunction> _GroupFunctionList;


        /// <summary>
        /// User Items to be Mapped as Input Classes for DB Saving
        /// </summary>
        public static User _User;
        public static List<UserGroup> _UserGroupListInput;

        /// <summary>
        /// Group Items to be Mapped as Input Classes for DB Saving
        /// </summary>
        public static Group _Group;
        public static List<GroupFunction> _GroupFunctionListInput;

        /// <summary>
        /// Input Items to be Mapped as Output DTO (Request or Customer) as One Unit
        /// </summary>
        public static List<RequestType> _RequestTypeList; // Lookups
        public static List<RequestClass> _RequestClassList; // Lookups
        public static List<RequestStatus> _RequestStatusList; // Lookups
        public static List<RequestPriority> _RequestPriorityList; // Lookups
        public static List<RejectReason> _RejectReasonList; // Lookups
        public static List<CardType> _CardTypeList; // Lookups
        public static List<CardValidity> _CardValidityList; // Lookups
        public static List<WorkField> _WorkFieldList; // Lookups
        public static List<Request> _RequestList;
        public static List<RequestDetail> _RequestDetailList;
        public static List<Customer> _CustomerList;

        /// <summary>
        /// Request Items to be Mapped as Input Classes for DB Saving
        /// </summary>
        public static Request _Request;
        public static List<RequestDetail> _RequestDetailListInput;

        /// <summary>
        /// RequestSearch Class to be Mapped as Input Classes for DB Saving
        /// </summary>
        public static RequestSearch _RequestSearch;

        /// <summary>
        /// Request Items to be Mapped as Input Classes for DB Saving
        /// </summary>
        public static Customer _Customer;
        public static WorkField _WorkField;
        public static RejectReason _RejectReason;

        public static ICollection<UserDTO> MapUserAsOutput()//(List<User> InputList)
        {
            List<UserDTO> _UserDTOList = new List<UserDTO>();
            UserDTO _UserDTO = default(UserDTO);

            if (_UserList != null && _UserList.Count > 0)
            {
                foreach (User _User in _UserList)
                {
                    _UserDTO = mapUser(_User);
                    _UserDTOList.Add(_UserDTO);
                }
            }


            return _UserDTOList;
        }

        public static bool MapUserAsInput(UserDTO userDTO)
        {
            bool result = default(bool);

            _User = new User();
            _UserGroupListInput = new List<UserGroup>();
            UserGroup _UserGroupTemp = default(UserGroup);

            if (userDTO != null)
            {
                // User Data Part
                _User.Id = userDTO.Id;
                _User.Password = userDTO.Password;
                _User.status = userDTO.status;
                _User.userName = userDTO.userName;
                _User.fullName = userDTO.fullName;
                //_User.createDate = DateTime.Now;

                // Group Data Part
                if (userDTO.UserGroups != null && userDTO.UserGroups.Count > 0)
                {
                    foreach (GroupDTO _GroupDTO in userDTO.UserGroups)
                    {
                        _UserGroupTemp = new UserGroup();
                        _UserGroupTemp.groupId = _GroupDTO.Id;
                        _UserGroupListInput.Add(_UserGroupTemp);
                    }

                    result = true;
                }
            }

            return result;
        }

        public static ICollection<GroupDTO> MapGroupAsOutput()
        {
            List<GroupDTO> _GroupDTOList = new List<GroupDTO>();
            GroupDTO _GroupDTO = default(GroupDTO);

            if (_GroupList != null && _GroupList.Count > 0)
            {
                foreach (Group _Group in _GroupList)
                {
                    _GroupDTO = mapGroup(_Group);
                    _GroupDTOList.Add(_GroupDTO);
                }
            }

            return _GroupDTOList;
        }

        public static bool MapGroupAsInput(GroupDTO groupDTO)
        {
            bool result = default(bool);

            _Group = new Group();
            _GroupFunctionListInput = new List<GroupFunction>();
            GroupFunction _GroupFunctionTemp = default(GroupFunction);

            if (groupDTO != null)
            {
                // Group Data Part
                _Group.Id = groupDTO.Id;
                _Group.name = groupDTO.name;
                _Group.status = groupDTO.status;

                // Functions Data Part
                if (groupDTO.GroupFunctions != null && groupDTO.GroupFunctions.Count > 0)
                {
                    foreach (FunctionDTO _FunctionDTO in groupDTO.GroupFunctions)
                    {
                        _GroupFunctionTemp = new GroupFunction();
                        _GroupFunctionTemp.groupId = _FunctionDTO.Id;
                        _GroupFunctionListInput.Add(_GroupFunctionTemp);
                    }

                    result = true;
                }
            }

            return result;
        }

        public static ICollection<RequestDTO> MapRequestAsOutput()
        {
            List<RequestDTO> _RequestDTOList = new List<RequestDTO>();
            RequestDTO _RequestDTO = default(RequestDTO);

            if (_RequestList != null && _RequestList.Count > 0)
            {
                foreach (Request _Request in _RequestList)
                {
                    _RequestDTO = mapRequest(_Request);
                    _RequestDTOList.Add(_RequestDTO);
                }
            }

            return _RequestDTOList;
        }

        public static bool MapRequestAsInput(RequestDTO requestDTO)
        {
            bool result = default(bool);

            _Request = new Request();
            _RequestDetailListInput = new List<RequestDetail>();
            RequestDetail _RequestDetailTemp = default(RequestDetail);

            try
            {
                if (requestDTO != null)
                {
                    // Request Data Part
                    _Request.Id = requestDTO.Id;
                    _Request.requestNumber = requestDTO.requestNumber;
                    _Request.totalQuantity = requestDTO.totalQuantity;

                    _Request.PDD = Formatter.formatStringtoDate(requestDTO.PDD); // DateTime.ParseExact(requestDTO.PDD, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    if (requestDTO.customerID != null)
                        _Request.customerID = requestDTO.customerID.Id;

                    _Request.creationDate = Formatter.formatStringtoDate(requestDTO.creationDate); // DateTime.ParseExact(requestDTO.creationDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    if (requestDTO.creationUserID != null)
                        _Request.creationUserID = requestDTO.creationUserID.Id;

                    _Request.approvalDate = Formatter.formatStringtoDate(requestDTO.approvalDate); //DateTime.ParseExact(requestDTO.approvalDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    if (requestDTO.approvalUserID != null)
                        _Request.approvalUserID = requestDTO.approvalUserID.Id;

                    _Request.receiveDate = Formatter.formatStringtoDate(requestDTO.receiveDate); //DateTime.ParseExact(requestDTO.receiveDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    if (requestDTO.receiveUserID != null)
                        _Request.receiveUserID = requestDTO.receiveUserID.Id;

                    _Request.rejectionDate = Formatter.formatStringtoDate(requestDTO.rejectionDate); //DateTime.ParseExact(requestDTO.rejectionDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    if (requestDTO.rejectionUserID != null)
                        _Request.rejectionUserID = requestDTO.rejectionUserID.Id;

                    if (requestDTO.rejectionReasonID != null)
                        _Request.rejectionReasonID = requestDTO.rejectionReasonID.Id;

                    if (requestDTO.requestTypeID != null)
                        _Request.requestTypeID = requestDTO.requestTypeID.Id;

                    if (requestDTO.requestStatusID != null)
                        _Request.requestStatusID = requestDTO.requestStatusID.Id;

                    if (requestDTO.requestCalssID != null)
                        _Request.requestCalssID = requestDTO.requestCalssID.Id;

                    if (requestDTO.requestPriorityID != null)
                        _Request.requestPriorityID = requestDTO.requestPriorityID.Id;

                    // Request Details Data Part
                    if (requestDTO.RequestDetailList != null && requestDTO.RequestDetailList.Count > 0)
                    {
                        foreach (RequestDetailDTO _RequestDetailDTO in requestDTO.RequestDetailList)
                        {
                            _RequestDetailTemp = new RequestDetail();
                            _RequestDetailTemp.Id = _RequestDetailDTO.Id;
                            _RequestDetailTemp.quantity = _RequestDetailDTO.quantity;
                            _RequestDetailTemp.requestID = requestDTO.Id;

                            if (_RequestDetailDTO.cardTypeDTO != null)
                                _RequestDetailTemp.cardTypeID = _RequestDetailDTO.cardTypeDTO.Id;

                            _RequestDetailListInput.Add(_RequestDetailTemp);
                        }
                    }

                    result = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public static bool MapRequestSearchAsInput(RequestSearchDTO requestSearchDTO)
        {
            bool result = default(bool);

            _RequestSearch = new RequestSearch();

            try
            {
                if (requestSearchDTO != null)
                {
                    _RequestSearch.Id = requestSearchDTO.Id;
                    _RequestSearch.requestNumber = requestSearchDTO.requestNumber;

                    if (requestSearchDTO.totalQuantity != 0)
                        _RequestSearch.totalQuantity = requestSearchDTO.totalQuantity;

                    if (requestSearchDTO.customerID != null  && requestSearchDTO.customerID.Id != 0)
                        _RequestSearch.customerID = requestSearchDTO.customerID.Id;

                    if (requestSearchDTO.creationUserID != null && requestSearchDTO.creationUserID.Id != 0)
                        _RequestSearch.creationUserID = requestSearchDTO.creationUserID.Id;

                    if (requestSearchDTO.approvalUserID != null && requestSearchDTO.approvalUserID.Id != 0)
                        _RequestSearch.approvalUserID = requestSearchDTO.approvalUserID.Id;

                    if (requestSearchDTO.receiveUserID != null && requestSearchDTO.receiveUserID.Id != 0)
                        _RequestSearch.receiveUserID = requestSearchDTO.receiveUserID.Id;

                    if (requestSearchDTO.rejectionUserID != null && requestSearchDTO.rejectionUserID.Id != 0)
                        _RequestSearch.rejectionUserID = requestSearchDTO.rejectionUserID.Id;

                    if (requestSearchDTO.rejectionReasonID != null && requestSearchDTO.rejectionReasonID.Id != 0)
                        _RequestSearch.rejectionReasonID = requestSearchDTO.rejectionReasonID.Id;

                    if (requestSearchDTO.requestTypeID != null && requestSearchDTO.requestTypeID.Id != 0)
                        _RequestSearch.requestTypeID = requestSearchDTO.requestTypeID.Id;

                    if (requestSearchDTO.requestStatusID != null && requestSearchDTO.requestStatusID.Id != 0)
                        _RequestSearch.requestStatusID = requestSearchDTO.requestStatusID.Id;

                    if (requestSearchDTO.requestCalssID != null && requestSearchDTO.requestCalssID.Id != 0)
                        _RequestSearch.requestCalssID = requestSearchDTO.requestCalssID.Id;

                    if (requestSearchDTO.requestPriorityID != null && requestSearchDTO.requestPriorityID.Id != 0)
                        _RequestSearch.requestPriorityID = requestSearchDTO.requestPriorityID.Id;


                    if (!string.IsNullOrWhiteSpace(requestSearchDTO.PDDFromString))
                        _RequestSearch.PDDFrom = Formatter.formatStringtoDate(requestSearchDTO.PDDFromString);

                    if (!string.IsNullOrWhiteSpace(requestSearchDTO.PDDToString))
                        _RequestSearch.PDDTo = Formatter.formatStringtoDate(requestSearchDTO.PDDToString);

                    if (!string.IsNullOrWhiteSpace(requestSearchDTO.creationDateFromString))
                        _RequestSearch.creationDateFrom = Formatter.formatStringtoDate(requestSearchDTO.creationDateFromString);

                    if (!string.IsNullOrWhiteSpace(requestSearchDTO.creationDateToString))
                        _RequestSearch.creationDateTo = Formatter.formatStringtoDate(requestSearchDTO.creationDateToString);

                    if (!string.IsNullOrWhiteSpace(requestSearchDTO.approvalDateFromString))
                        _RequestSearch.approvalDateFrom = Formatter.formatStringtoDate(requestSearchDTO.approvalDateFromString);

                    if (!string.IsNullOrWhiteSpace(requestSearchDTO.approvalDateToString))
                        _RequestSearch.approvalDateTo = Formatter.formatStringtoDate(requestSearchDTO.approvalDateToString);

                    if (!string.IsNullOrWhiteSpace(requestSearchDTO.receiveDateFromString))
                        _RequestSearch.receiveDateFrom = Formatter.formatStringtoDate(requestSearchDTO.receiveDateFromString);

                    if (!string.IsNullOrWhiteSpace(requestSearchDTO.receiveDateToString))
                        _RequestSearch.receiveDateTo = Formatter.formatStringtoDate(requestSearchDTO.receiveDateToString);

                    if (!string.IsNullOrWhiteSpace(requestSearchDTO.rejectionDateFromString))
                        _RequestSearch.rejectionDateFrom = Formatter.formatStringtoDate(requestSearchDTO.rejectionDateFromString);

                    if (!string.IsNullOrWhiteSpace(requestSearchDTO.rejectionDateToString))
                        _RequestSearch.rejectionDateTo = Formatter.formatStringtoDate(requestSearchDTO.rejectionDateToString);

                    if (requestSearchDTO.cardTypeDTO != null)
                        _RequestSearch.cardTypeID = requestSearchDTO.cardTypeDTO.Id;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public static ICollection<CustomerDTO> MapCustomerAsOutput()
        {
            List<CustomerDTO> _CustomerDTOList = new List<CustomerDTO>();
            CustomerDTO _CustomerDTO = default(CustomerDTO);

            if (_CustomerList != null && _CustomerList.Count > 0)
            {
                foreach (Customer _Customer in _CustomerList)
                {
                    _CustomerDTO = mapCustomer(_Customer);
                    _CustomerDTOList.Add(_CustomerDTO);
                }
            }

            return _CustomerDTOList;
        }

        public static bool MapCustomerAsInput(CustomerDTO customerDTO)
        {
            bool result = default(bool);

            _Customer = new Customer();

            if (customerDTO != null)
            {
                // Customer Data Part
                _Customer.Id = customerDTO.Id;
                _Customer.code = customerDTO.code;
                _Customer.name = customerDTO.name; 
                _Customer.nameAr = customerDTO.nameAr;
                _Customer.address = customerDTO.address;
                _Customer.phone = customerDTO.phone;
                _Customer.email = customerDTO.email;

                // Workfield Data Part
                if (customerDTO.workFieldDTO != null)
                {
                    _Customer.workFieldId = customerDTO.workFieldDTO.Id;
                }

                result = true;
            }

            return result;
        }

        public static ICollection<WorkFieldDTO> MapWorkFieldAsOutput()
        {
            {
                List<WorkFieldDTO> _WorkFieldDTOList = new List<WorkFieldDTO>();
                WorkFieldDTO _WorkFieldDTO = default(WorkFieldDTO);

                if (_WorkFieldList != null && _WorkFieldList.Count > 0)
                {
                    foreach (WorkField __WorkField in _WorkFieldList)
                    {
                        _WorkFieldDTO = mapWorkField(__WorkField);
                        _WorkFieldDTOList.Add(_WorkFieldDTO);
                    }
                }

                return _WorkFieldDTOList;
            }

        }

        public static bool MapWorkFieldAsInput(WorkFieldDTO workFieldDTO)
        {

            bool result = default(bool);

            _WorkField = new WorkField();


            if (workFieldDTO != null)
            {
                // WorkField Data part

                _WorkField.Id = workFieldDTO.Id;
                _WorkField.name = workFieldDTO.name;
                _WorkField.nameAr = workFieldDTO.nameAr;



                result = true;
            }

            return result;
        }

        public static ICollection<RejectReasonDTO> MapRejectReasonAsOutput()
        {
            {
                List<RejectReasonDTO> _RejectReasonDTOList = new List<RejectReasonDTO>();
                RejectReasonDTO _RejectReasonDTO = default(RejectReasonDTO);

                if (_RejectReasonList != null && _RejectReasonList.Count > 0)
                {
                    foreach (RejectReason _RejectReason in _RejectReasonList)
                    {
                        _RejectReasonDTO = mapRejectReason(_RejectReason);
                        _RejectReasonDTOList.Add(_RejectReasonDTO);
                    }
                }

                return _RejectReasonDTOList;
            }
        }
        public static bool MapRejectReasonAsInput(RejectReasonDTO rejectReasonDTO)
        {
            bool result = default(bool);

            _RejectReason = new RejectReason();


            if (rejectReasonDTO != null)
            {
                // RejectReason Data part

                _RejectReason.Id = rejectReasonDTO.Id;
                _RejectReason.name = rejectReasonDTO.name;
                _RejectReason.nameAr = rejectReasonDTO.nameAr;



                result = true;
            }

            return result;
        }
            private static RejectReasonDTO mapRejectReason(RejectReason rejectReason)
        {
            RejectReasonDTO _RejectReasonMap = new RejectReasonDTO();

            _RejectReasonMap = fillRejectReasonDTObyRejectReasonID(rejectReason.Id);
         


            return _RejectReasonMap;
        }

        private static RejectReasonDTO fillRejectReasonDTObyRejectReasonID(int? RejectReasonID)
        {
            RejectReasonDTO _RejectReasonDTO = default(RejectReasonDTO);
            RejectReason _RejectReason = _RejectReasonList.FirstOrDefault(i => i.Id == RejectReasonID.Value);
            
            if (_RejectReason != default(RejectReason))
            {
                _RejectReasonDTO = new RejectReasonDTO();
                _RejectReasonDTO.Id = _RejectReason.Id;
                _RejectReasonDTO.name = _RejectReason.name;
                _RejectReasonDTO.nameAr = _RejectReason.nameAr;

            }

            return _RejectReasonDTO;        }

        private static WorkFieldDTO mapWorkField(WorkField workField)
        {
            WorkFieldDTO _WorkFieldMap = new WorkFieldDTO();

            _WorkFieldMap = fillWorkFieldDTObyWorkFieldID(workField.Id);
            //  _WorkFieldMap.WorkFieldDTO = fillWorkfieldDTObyCustomerID(workField.Id);

            return _WorkFieldMap; ;
        }

        private static WorkFieldDTO fillWorkFieldDTObyWorkFieldID(int? WorkFieldID)
        {
            {
                WorkFieldDTO _WorkFieldDTO = default(WorkFieldDTO);
                WorkField _WorkField = _WorkFieldList.FirstOrDefault(i => i.Id == WorkFieldID.Value);

                if (_WorkField != default(WorkField))
                {
                    _WorkFieldDTO = new WorkFieldDTO();
                    _WorkFieldDTO.Id = _WorkField.Id;
                    _WorkFieldDTO.name = _WorkField.name;
                    _WorkFieldDTO.nameAr = _WorkField.nameAr;

                }

                return _WorkFieldDTO;
            }

        }
    



        #region User/Groups Helpers

        private static GroupDTO mapGroup(Group group)
        {
            GroupDTO _GroupMap = new GroupDTO();

            _GroupMap.Id = group.Id;
            _GroupMap.name = group.name;
            _GroupMap.status = group.status;

            _GroupMap.GroupFunctions = fillGroupFunctionsDTObyGroupID(group.Id);

            return _GroupMap;
        }

        private static UserDTO mapUser(User user)
        {
            UserDTO _UserMap = new UserDTO();

            _UserMap.Id = user.Id;
            _UserMap.userName = user.userName;
            _UserMap.fullName = user.fullName;
            _UserMap.Password = user.Password;
            _UserMap.status = user.status;
            _UserMap.createDate = ""; // Format Date as required by FE

            _UserMap.UserGroups = fillUserGroupsbyUserID(user.Id);

            return _UserMap;
        }

        private static ICollection<GroupDTO> fillUserGroupsbyUserID(int id)
        {
            List<GroupDTO> _GroupDTOList = new List<GroupDTO>();
            GroupDTO _GroupDTO = default(GroupDTO);

            if (_UserGroupList != null && _UserGroupList.Count > 0)
            {
                foreach (UserGroup _UserGroup in _UserGroupList)
                {
                    if (_UserGroup.userId == id)
                    {
                        _GroupDTO = fillGroupDTObyGroupID(_UserGroup.groupId);
                        _GroupDTOList.Add(_GroupDTO);
                    }
                }
            }

            return _GroupDTOList;
        }

        private static GroupDTO fillGroupDTObyGroupID(int groupId)
        {
            GroupDTO _GroupDTO = new GroupDTO();

            if (_GroupList != null && _GroupList.Count > 0)
            {
                foreach (Group _Group in _GroupList)
                    if (_Group.Id == groupId)
                    {
                        _GroupDTO.Id = _Group.Id;
                        _GroupDTO.name = _Group.name;
                        _GroupDTO.status = _Group.status;
                        _GroupDTO.GroupFunctions = fillGroupFunctionsDTObyGroupID(_Group.Id);
                    }
            }

            return _GroupDTO;
        }

        private static ICollection<FunctionDTO> fillGroupFunctionsDTObyGroupID(int id)
        {
            List<FunctionDTO> _FunctionDTOList = new List<FunctionDTO>();
            FunctionDTO _FunctionDTO = default(FunctionDTO);

            if (_GroupFunctionList != null && _GroupFunctionList.Count > 0)
            {
                foreach (GroupFunction _GroupFunction in _GroupFunctionList)
                {
                    if (_GroupFunction.groupId == id)
                    {
                        _FunctionDTO = fillFunctionDTObyFunctionID(_GroupFunction.functionId);
                        _FunctionDTOList.Add(_FunctionDTO);
                    }
                }
            }

            return _FunctionDTOList;
        }

        private static FunctionDTO fillFunctionDTObyFunctionID(int? functionId)
        {
            FunctionDTO _FunctionDTO = new FunctionDTO();

            if (_FunctionList != null && _FunctionList.Count > 0)
            {
                foreach (Function _Function in _FunctionList)
                    if (_Function.Id == functionId)
                    {
                        _FunctionDTO.Id = _Function.Id;
                        _FunctionDTO.name = _Function.name;
                        _FunctionDTO.status = _Function.status;
                        _FunctionDTO.nameAr = _Function.nameAr;
                        _FunctionDTO.route = _Function.route;
                    }
            }

            return _FunctionDTO;
        }

        #endregion

        #region Request/Customer Helpers

        private static RequestDTO mapRequest(Request request)
        {
            RequestDTO _RequestMap = new RequestDTO();

            _RequestMap.Id = request.Id;
            _RequestMap.requestNumber = request.requestNumber;

            if (request.totalQuantity != null)
                _RequestMap.totalQuantity = request.totalQuantity.Value;

            if (request.PDD != null)
                _RequestMap.PDD = Formatter.formatDatetoString(request.PDD.Value);

            _RequestMap.customerID = fillCustomerDTObyCustomerID(request.customerID);

            if(request.creationDate != null)
                _RequestMap.creationDate = Formatter.formatDatetoString(request.creationDate.Value); // Format Date as required by FE

            _RequestMap.creationUserID = fillUserDTObyUserID(request.creationUserID);

            if (request.approvalDate != null)
                _RequestMap.approvalDate = Formatter.formatDatetoString(request.approvalDate.Value);

            _RequestMap.approvalUserID = fillUserDTObyUserID(request.approvalUserID);

            if (request.receiveDate != null)
                _RequestMap.receiveDate = Formatter.formatDatetoString(request.receiveDate.Value);

            _RequestMap.receiveUserID = fillUserDTObyUserID(request.receiveUserID);

            if (request.rejectionDate != null)
                _RequestMap.rejectionDate = Formatter.formatDatetoString(request.rejectionDate.Value);

            if (request.rejectionUserID != null)
                _RequestMap.rejectionUserID = fillUserDTObyUserID(request.rejectionUserID);

            if (request.rejectionReasonID != null)
                _RequestMap.rejectionReasonID = fillRejectionReasonDTObyReasonID(request.rejectionReasonID);

            if (request.requestTypeID != null)
                _RequestMap.requestTypeID = fillRequestTypeDTObyRequestTypeID(request.requestTypeID);

            if (request.requestStatusID != null)
                _RequestMap.requestStatusID = fillRequestStatusDTObyRequestStatusID(request.requestStatusID);

            if (request.requestCalssID != null)
                _RequestMap.requestCalssID = fillRequestClassDTObyRequestClassID(request.requestCalssID);

            if (request.requestPriorityID != null)
                _RequestMap.requestPriorityID = fillRequestPriorityDTObyRequestPriorityID(request.requestPriorityID);

            _RequestMap.RequestDetailList = fillRequestDetailDto(request.Id);

            return _RequestMap;
        }

        private static CustomerDTO mapCustomer(Customer customer)
        {
            CustomerDTO _CustomerMap = new CustomerDTO();

            _CustomerMap = fillCustomerDTObyCustomerID(customer.Id);
            _CustomerMap.workFieldDTO = fillWorkfieldDTObyCustomerID(customer.Id);

            return _CustomerMap;
        }

        private static WorkFieldDTO fillWorkfieldDTObyCustomerID(int id)
        {
            WorkFieldDTO workFieldDTO = default(WorkFieldDTO); //new WorkFieldDTO();
            WorkField _WorkField = _WorkFieldList.FirstOrDefault(i => i.Id == id);

            if (_WorkField != default(WorkField))
            {
                workFieldDTO = new WorkFieldDTO();
                workFieldDTO.Id = _WorkField.Id;
                workFieldDTO.name = _WorkField.name;
                workFieldDTO.nameAr = _WorkField.nameAr;
            }

            return workFieldDTO;
        }

        private static ICollection<RequestDetailDTO> fillRequestDetailDto(int requestId)
        {
            List<RequestDetailDTO> _RequestDetailDTOList = new List<RequestDetailDTO>();
            RequestDetailDTO _RequestDetailDTO = default(RequestDetailDTO);

            if (_RequestDetailList != null && _RequestDetailList.Count > 0)
            {
                foreach (RequestDetail _RequestDetail in _RequestDetailList)
                {
                    if (_RequestDetail.requestID == requestId)
                    {
                        //_GroupDTO = fillGroupDTObyGroupID(_UserGroup.groupId);
                        //_GroupDTOList.Add(_GroupDTO);

                        _RequestDetailDTO = new RequestDetailDTO();
                        _RequestDetailDTO.Id = _RequestDetail.Id;

                        if(_RequestDetail.quantity != null)
                            _RequestDetailDTO.quantity = _RequestDetail.quantity.Value;

                        if (_RequestDetail.cardTypeID != null)
                            _RequestDetailDTO.cardTypeDTO = fillCardTypeDTObyCardTypeID(_RequestDetail.cardTypeID);

                        _RequestDetailDTOList.Add(_RequestDetailDTO);
                    }
                }
            }

            //_RequestDetailList.Find(i => i.requestID == requestId);

            return _RequestDetailDTOList;
        }

        private static RequestPriorityDTO fillRequestPriorityDTObyRequestPriorityID(int? requestPriorityID)
        {
            RequestPriorityDTO _RequestPriorityDTO = default(RequestPriorityDTO);
            RequestPriority _RequestPriority = _RequestPriorityList.FirstOrDefault(i => i.Id == requestPriorityID.Value);

            if (_RequestPriority != default(RequestPriority))
            {
                _RequestPriorityDTO = new RequestPriorityDTO();

                _RequestPriorityDTO.Id = _RequestPriority.Id;
                _RequestPriorityDTO.name = _RequestPriority.name;
                _RequestPriorityDTO.nameAr = _RequestPriority.nameAr;
            }

            return _RequestPriorityDTO;
        }

        private static RequestClassDTO fillRequestClassDTObyRequestClassID(int? requestCalssID)
        {
            RequestClassDTO _RequestClassDTO = default(RequestClassDTO);
            RequestClass _RequestClass = _RequestClassList.FirstOrDefault(i => i.Id == requestCalssID.Value);

            if (_RequestClass != default(RequestClass))
            {
                _RequestClassDTO = new RequestClassDTO();

                _RequestClassDTO.Id = _RequestClass.Id;
                _RequestClassDTO.name = _RequestClass.name;
                _RequestClassDTO.nameAr = _RequestClass.nameAr;
            }

            return _RequestClassDTO;
        }

        private static RequestStatusDTO fillRequestStatusDTObyRequestStatusID(int? requestStatusID)
        {
            RequestStatusDTO _RequestStatusDTO = default(RequestStatusDTO);
            RequestStatus _RequestStatus = _RequestStatusList.FirstOrDefault(i => i.Id == requestStatusID.Value);

            if (_RequestStatus != default(RequestStatus))
            {
                _RequestStatusDTO = new RequestStatusDTO();

                _RequestStatusDTO.Id = _RequestStatus.Id;
                _RequestStatusDTO.name = _RequestStatus.name;
                _RequestStatusDTO.nameAr = _RequestStatus.nameAr;
            }

            return _RequestStatusDTO;
        }

        private static RequestTypeDTO fillRequestTypeDTObyRequestTypeID(int? requestTypeID)
        {
            RequestTypeDTO _RequestTypeDTO = default(RequestTypeDTO);
            RequestType _RequestType = _RequestTypeList.FirstOrDefault(i => i.Id == requestTypeID.Value);

            if (_RequestType != default(RequestType))
            {
                _RequestTypeDTO = new RequestTypeDTO();

                _RequestTypeDTO.Id = _RequestType.Id;
                _RequestTypeDTO.name = _RequestType.name;
                _RequestTypeDTO.nameAr = _RequestType.nameAr;
            }

            return _RequestTypeDTO;
        }

        private static RejectReasonDTO fillRejectionReasonDTObyReasonID(int? rejectionReasonID)
        {
            RejectReasonDTO _RejectReasonDTO = default(RejectReasonDTO);
            RejectReason _RejectReason = _RejectReasonList.FirstOrDefault(i => i.Id == rejectionReasonID.Value);

            if (_RejectReason != default(RejectReason))
            {
                _RejectReasonDTO = new RejectReasonDTO();

                _RejectReasonDTO.Id = _RejectReason.Id;
                _RejectReasonDTO.name = _RejectReason.name;
                _RejectReasonDTO.nameAr = _RejectReason.nameAr;
            }

            return _RejectReasonDTO;
        }

        private static UserDTO fillUserDTObyUserID(int? creationUserID)
        {
            UserDTO _UserDTO = default(UserDTO);
            User _User = _UserList.FirstOrDefault(i => i.Id == creationUserID.Value);

            if (_User != default(User))
            {
                _UserDTO = new UserDTO();

                _UserDTO.Id = _User.Id;
                _UserDTO.userName = _User.userName;
                _UserDTO.fullName = _User.fullName;
                _UserDTO.Password = _User.Password;
                _UserDTO.status = _User.status;
                if(_User.createDate != null)
                    _UserDTO.createDate = Formatter.formatDatetoString(_User.createDate.Value);
            }

            return _UserDTO;
        }

        private static CustomerDTO fillCustomerDTObyCustomerID(int? customerID)
        {
            CustomerDTO _CustomerDTO = default(CustomerDTO);
            Customer _Customer = _CustomerList.FirstOrDefault(i => i.Id == customerID.Value);

            if (_Customer != default(Customer))
            {
                _CustomerDTO = new CustomerDTO();
                _CustomerDTO.Id = _Customer.Id;
                _CustomerDTO.address = _Customer.address;
                _CustomerDTO.code = _Customer.code;
                _CustomerDTO.email = _Customer.email;
                _CustomerDTO.name = _Customer.name;
                _CustomerDTO.nameAr = _Customer.nameAr;
                _CustomerDTO.phone = _Customer.phone;
            }

            return _CustomerDTO;
        }

        private static CardTypeDTO fillCardTypeDTObyCardTypeID(int? cardTypeID)
        {
            CardTypeDTO _CardTypeDTO = default(CardTypeDTO);
            CardType _CardType = _CardTypeList.FirstOrDefault(i => i.Id == cardTypeID.Value);

            if (_CardType != default(CardType))
            {
                _CardTypeDTO = new CardTypeDTO();

                _CardTypeDTO.Id = _CardType.Id;
                _CardTypeDTO.name = _CardType.name;
                _CardTypeDTO.nameAr = _CardType.nameAr;
            }

            return _CardTypeDTO;
        }

        #endregion

    }
}

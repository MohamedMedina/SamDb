using System;
using com.idemia.sam.be.Contracts;
using com.idemia.sam.be.DAL;
using ApplicationBlocks.Layers;
using System.Data.Common;
using com.idemia.sam.be.Helpers;
using System.Collections.Generic;
using Business;
using Common;
using ApplicationBlocks.Layers;
using System.Linq;

namespace com.idemia.sam.be.DAL
{
    public class RequestDAL : IRequestDAL
    {
        public RequestDTO AddRequesttoDB(RequestDTO requestDTO)
        {
            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Perform Mapping to  Input (for Saving in DB)
                    if (Mapper.MapRequestAsInput(requestDTO))
                    {
                        ////User user = Mapper._User;
                        ////List<UserGroup> userGroups = Mapper._UserGroupListInput;
                        //Mapper._User.createDate = DateTime.Now;

                        Mapper._Request.creationDate = DateTime.Now;

                        // 2- Insert Request in DB
                        RequestBusiness requestBusiness = new RequestBusiness();
                        if (requestBusiness.InsertRow(dbTransaction, Mapper._Request) > 0)
                        {
                            requestDTO.Id = Mapper._Request.Id;

                            if (Mapper._RequestDetailListInput != null && Mapper._RequestDetailListInput.Count > 0)
                            {
                                RequestDetailBusiness requestDetailBusiness = new RequestDetailBusiness();

                                // 3- Insert Group Functions in DB
                                foreach (RequestDetail requestDetail in Mapper._RequestDetailListInput)
                                {
                                    requestDetail.requestID = Mapper._Request.Id;

                                    requestDetailBusiness = new RequestDetailBusiness();
                                    requestDetailBusiness.InsertRow(dbTransaction, requestDetail);
                                }

                                dbTransaction.Commit();
                            }
                            else
                                dbTransaction.Rollback();
                        }
                        else
                            throw new Exception("DataBase Operation Failure");
                    }
                    else
                        throw new ArgumentNullException("requestDTO");
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    throw;
                }
            }

            return requestDTO;
        }

        public ICollection<RequestDTO> GetAllRequestsfromDB()
        {
            ICollection<RequestDTO> outputList = default(ICollection<RequestDTO>);

            try
            {
                // 1- Select All Groups From DB
                RequestBusiness _RequestBusiness = new RequestBusiness();
                RequestList _RequestList = _RequestBusiness.SelectRows(null, null, null, null, null, null, null, null, 
                    null, null, null, null, null, null, null, null);

                if (_RequestList != null && _RequestList.Count > 0)
                //outputList = Mapper.MapUserAsOutput();
                {
                    // 2- Prepare Mapping Obects (Fill Values from DB)

                    //if(Mapper._RequestTypeList == default(List<RequestType>)) ==> In case we try to save DB hits (we apply that check for all lists)
                    //Mapper._RequestTypeList = fillRequestTypeList();

                    Mapper._RequestList = _RequestList;
                    Mapper._RequestDetailList = fillRequestDetailList();
                    Mapper._RequestTypeList = fillRequestTypeList();
                    Mapper._RequestStatusList = fillRequestStatusList();
                    Mapper._RequestClassList = fillRequestClassList();
                    Mapper._RequestPriorityList = fillRequestPriorityList();
                    Mapper._RejectReasonList = fillRejectReasonList();
                    Mapper._CardTypeList = fillCardTypeList();
                    Mapper._CardValidityList = fillCardValidityList();
                    Mapper._WorkFieldList = fillWorkFieldList();
                    Mapper._CustomerList = fillCustomerList();
                    Mapper._UserList = fillUserList();

                    //UserGroupBusiness _UserGroupBusiness = new UserGroupBusiness();
                    //UserGroupList _UserGroupList = default(UserGroupList);

                    //foreach (User _User in _UserList)
                    //{
                    //    _UserGroupList = _UserGroupBusiness.SelectRows(null, _User.Id, null);

                    //    if (_UserGroupList != null && _UserGroupList.Count > 0)
                    //        foreach (UserGroup _UserGroup in _UserGroupList)
                    //            Mapper._UserGroupList.Add(Copier.copyUserGroup(_UserGroup));
                    //}


                    // 3- Perform Mapping to Output
                    outputList = Mapper.MapRequestAsOutput();
                }
            }
            catch (Exception ex)
            {
                // Log Exception Here
                throw; //new Exception(ex.Message);
            }

            return outputList;
        }

        public RequestDTO GetRequestByIDfromDB(int id)
        {
            ICollection<RequestDTO> outputList = default(ICollection<RequestDTO>);
            RequestDTO output = new RequestDTO();

            try
            {
                // 1- Select All Groups From DB
                RequestBusiness _RequestBusiness = new RequestBusiness();
                //RequestList _RequestList = _RequestBusiness.SelectRows(null, null, null, null, null, null, null, null,
                //    null, null, null, null, null, null, null, null);

                RequestList _RequestList = _RequestBusiness.SelectRows(id, null, null, null, null, null, null, null,
                      null, null, null, null, null, null, null, null);

                if (_RequestList != null && _RequestList.Count > 0)
                //outputList = Mapper.MapUserAsOutput();
                {
                    // 2- Prepare Mapping Obects (Fill Values from DB)

                    //if(Mapper._RequestTypeList == default(List<RequestType>)) ==> In case we try to save DB hits (we apply that check for all lists)
                    //Mapper._RequestTypeList = fillRequestTypeList();

                    Mapper._RequestList = _RequestList;
                    Mapper._RequestDetailList = fillRequestDetailListbyRequestID(id);
                    Mapper._RequestTypeList = fillRequestTypeList();
                    Mapper._RequestStatusList = fillRequestStatusList();
                    Mapper._RequestClassList = fillRequestClassList();
                    Mapper._RequestPriorityList = fillRequestPriorityList();
                    Mapper._RejectReasonList = fillRejectReasonList();
                    Mapper._CardTypeList = fillCardTypeList();
                    Mapper._CardValidityList = fillCardValidityList();
                    Mapper._WorkFieldList = fillWorkFieldList();
                    Mapper._CustomerList = fillCustomerList();
                    Mapper._UserList = fillUserList();

                    //UserGroupBusiness _UserGroupBusiness = new UserGroupBusiness();
                    //UserGroupList _UserGroupList = default(UserGroupList);

                    //foreach (User _User in _UserList)
                    //{
                    //    _UserGroupList = _UserGroupBusiness.SelectRows(null, _User.Id, null);

                    //    if (_UserGroupList != null && _UserGroupList.Count > 0)
                    //        foreach (UserGroup _UserGroup in _UserGroupList)
                    //            Mapper._UserGroupList.Add(Copier.copyUserGroup(_UserGroup));
                    //}


                    // 3- Perform Mapping to Output
                    outputList = Mapper.MapRequestAsOutput();

                    if (outputList != null && outputList.Count > 0)
                        output = outputList.First();
                }
            }
            catch (Exception ex)
            {
                // Log Exception Here
                throw; //new Exception(ex.Message);
            }

            return output;
        }

        public ICollection<RequestDTO> GetAllRequestsByStatusfromDB(int status)
        {
            ICollection<RequestDTO> outputList = default(ICollection<RequestDTO>);

            try
            {
                // 1- Select All Groups From DB
                RequestBusiness _RequestBusiness = new RequestBusiness();
                //RequestList _RequestList = _RequestBusiness.SelectRows(null, null, null, null, null, null, null, null,
                //    null, null, null, null, null, null, null, null);

                RequestList _RequestList = _RequestBusiness.SelectRows(null, null, null, null, null, null, null, null, null, 
                    null, null, null, null, status, null, null);

                if (_RequestList != null && _RequestList.Count > 0)
                //outputList = Mapper.MapUserAsOutput();
                {
                    // 2- Prepare Mapping Obects (Fill Values from DB)

                    //if(Mapper._RequestTypeList == default(List<RequestType>)) ==> In case we try to save DB hits (we apply that check for all lists)
                    //Mapper._RequestTypeList = fillRequestTypeList();

                    Mapper._RequestList = _RequestList;
                    Mapper._RequestDetailList = fillRequestDetailListbyRequestStatus(Mapper._RequestList);
                    Mapper._RequestTypeList = fillRequestTypeList();
                    Mapper._RequestStatusList = fillRequestStatusList();
                    Mapper._RequestClassList = fillRequestClassList();
                    Mapper._RequestPriorityList = fillRequestPriorityList();
                    Mapper._RejectReasonList = fillRejectReasonList();
                    Mapper._CardTypeList = fillCardTypeList();
                    Mapper._CardValidityList = fillCardValidityList();
                    Mapper._WorkFieldList = fillWorkFieldList();
                    Mapper._CustomerList = fillCustomerList();
                    Mapper._UserList = fillUserList();

                    //UserGroupBusiness _UserGroupBusiness = new UserGroupBusiness();
                    //UserGroupList _UserGroupList = default(UserGroupList);

                    //foreach (User _User in _UserList)
                    //{
                    //    _UserGroupList = _UserGroupBusiness.SelectRows(null, _User.Id, null);

                    //    if (_UserGroupList != null && _UserGroupList.Count > 0)
                    //        foreach (UserGroup _UserGroup in _UserGroupList)
                    //            Mapper._UserGroupList.Add(Copier.copyUserGroup(_UserGroup));
                    //}


                    // 3- Perform Mapping to Output
                    outputList = Mapper.MapRequestAsOutput();
                }
            }
            catch (Exception ex)
            {
                // Log Exception Here
                throw; //new Exception(ex.Message);
            }

            return outputList;
        }

        public RequestDTO UpdateRequestinDB(RequestDTO requestDTO)
        {
            BaseDataAccess _db = new BaseDataAccess();
            using (DbTransaction dbTransaction = _db.CreateTransaction())
            {
                try
                {
                    // 1- Perform Mapping to  Input (for Saving in DB)
                    if (Mapper.MapRequestAsInput(requestDTO))
                    {
                        // 2- Select Request to be updated
                        RequestBusiness requestBusiness = new RequestBusiness();
                        RequestList requestList = requestBusiness.SelectRows(Mapper._Request.Id, null, null, null, null, null, null, null, null,
                            null, null, null, null, null, null,null);

                        if (requestList != null && requestList.Count > 0)
                        {
                            requestList[0].requestNumber = Mapper._Request.requestNumber;
                            requestList[0].totalQuantity = Mapper._Request.totalQuantity;
                            requestList[0].PDD = Mapper._Request.PDD;
                            requestList[0].customerID = Mapper._Request.customerID;
                            requestList[0].creationDate = Mapper._Request.creationDate;
                            requestList[0].creationUserID = Mapper._Request.creationUserID;
                            requestList[0].approvalDate = Mapper._Request.approvalDate;
                            requestList[0].approvalUserID = Mapper._Request.approvalUserID;
                            requestList[0].receiveDate = Mapper._Request.receiveDate;
                            requestList[0].receiveUserID = Mapper._Request.receiveUserID;
                            requestList[0].rejectionDate = Mapper._Request.rejectionDate;
                            requestList[0].rejectionUserID = Mapper._Request.rejectionUserID;
                            requestList[0].rejectionReasonID = Mapper._Request.rejectionReasonID;
                            requestList[0].requestTypeID = Mapper._Request.requestTypeID;
                            requestList[0].requestStatusID = Mapper._Request.requestStatusID;
                            requestList[0].requestCalssID = Mapper._Request.requestCalssID;
                            requestList[0].requestPriorityID = Mapper._Request.requestPriorityID;

                            // 3- Update Request Data by Input Values
                            requestBusiness = new RequestBusiness();
                            if (requestBusiness.UpdateRow(dbTransaction, requestList[0]) > 0)
                            {
                                // 4- Remove Request Details Already Saved for that Request in DB
                                RequestDetailBusiness requestDetailBusiness = new RequestDetailBusiness();
                                RequestDetailList requestDetailList = requestDetailBusiness.SelectRows(null, null, Mapper._Request.Id);

                                if (requestDetailList != null && requestDetailList.Count > 0)
                                {
                                    foreach (RequestDetail requestDetail in requestDetailList)
                                    {
                                        requestDetailBusiness = new RequestDetailBusiness();
                                        requestDetailBusiness.DeleteRow(dbTransaction, requestDetail);
                                    }
                                }

                                // 5- Add New Request Details from Input
                                if (Mapper._RequestDetailListInput != null && Mapper._RequestDetailListInput.Count > 0)
                                {
                                    foreach (RequestDetail requestDetail in Mapper._RequestDetailListInput)
                                    {
                                        requestDetailBusiness = new RequestDetailBusiness();
                                        requestDetailBusiness.InsertRow(dbTransaction, requestDetail);
                                    }

                                    dbTransaction.Commit();
                                }
                            }
                            else
                            {
                                dbTransaction.Rollback();
                                throw new Exception("DataBase Operation Failure");
                            }
                        }
                        else
                            throw new Exception("Request Id Not Found in DB");
                    }
                    else
                        throw new ArgumentNullException("requestDTO");
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    throw new Exception("DataBase Operation Failure");
                }
            }

            return requestDTO;
        }

        public List<RequestDTO> SearchRequestinDB(RequestSearchDTO requestSearchDTO)
        {
            ICollection<RequestDTO> outputList = default(ICollection<RequestDTO>);

            try
            {
                // 1- Perform Mapping to  Input (for Saving in DB)
                if(Mapper.MapRequestSearchAsInput(requestSearchDTO))
                {
                    RequestBusiness requestBusiness = new RequestBusiness();
                    RequestList _RequestList = requestBusiness.SelectRequestDynamicSearch(Mapper._RequestSearch);


                    if (_RequestList != null && _RequestList.Count > 0)
                    //outputList = Mapper.MapUserAsOutput();
                    {
                        // 2- Prepare Mapping Objects (Fill Values from DB)
                        Mapper._RequestList = _RequestList;
                        Mapper._RequestDetailList = fillRequestDetailList();
                        Mapper._RequestTypeList = fillRequestTypeList();
                        Mapper._RequestStatusList = fillRequestStatusList();
                        Mapper._RequestClassList = fillRequestClassList();
                        Mapper._RequestPriorityList = fillRequestPriorityList();
                        Mapper._RejectReasonList = fillRejectReasonList();
                        Mapper._CardTypeList = fillCardTypeList();
                        Mapper._CardValidityList = fillCardValidityList();
                        Mapper._WorkFieldList = fillWorkFieldList();
                        Mapper._CustomerList = fillCustomerList();
                        Mapper._UserList = fillUserList();

                        // 3- Perform Mapping to Output
                        outputList = Mapper.MapRequestAsOutput();
                    }
                }
                else
                    throw new ArgumentNullException("requestSearchDTO");

            }
            catch (Exception)
            {
                throw;
            }

            return outputList.ToList();
        }

        #region Helpers

        private List<RequestDetail> fillRequestDetailListbyRequestID(int id)
        {
            RequestDetailBusiness _RequestDetailBusiness = new RequestDetailBusiness();
            RequestDetailList _RequestDetailList = _RequestDetailBusiness.SelectRows(null, null, id);

            return _RequestDetailList;
        }

        private List<RequestDetail> fillRequestDetailList()
        {
            RequestDetailBusiness _RequestDetailBusiness = new RequestDetailBusiness();
            RequestDetailList _RequestDetailList = _RequestDetailBusiness.SelectRows(null, null, null, null);

            return _RequestDetailList;
        }

        private List<RequestDetail> fillRequestDetailListbyRequestStatus(List<Request> requestList)
        {
            List<RequestDetail> requestDetailsList = new List<RequestDetail>();

            RequestDetailBusiness _RequestDetailBusiness = default(RequestDetailBusiness);
            RequestDetailList _RequestDetailList = default(RequestDetailList);

            foreach (Request request in requestList)
            {
                _RequestDetailBusiness = new RequestDetailBusiness();
                _RequestDetailList = _RequestDetailBusiness.SelectRows(null, null, request.Id);

                if(_RequestDetailList != null && _RequestDetailList.Count > 0)
                {
                    foreach (RequestDetail requestDetail in _RequestDetailList)
                        requestDetailsList.Add(Copier.copyRequestDetail(requestDetail));
                }
            }

            return requestDetailsList;
        }

        private List<RequestType> fillRequestTypeList()
        {
            RequestTypeBusiness _RequestTypeBusiness = new RequestTypeBusiness();
            RequestTypeList _RequestTypeList = _RequestTypeBusiness.SelectRows(null, null, null);

            return _RequestTypeList;
        }

        private List<RequestStatus> fillRequestStatusList()
        {
            RequestStatusBusiness _RequestStatusBusiness = new RequestStatusBusiness();
            RequestStatusList _RequestStatusList = _RequestStatusBusiness.SelectRows(null, null, null);

            return _RequestStatusList;
        }

        private List<RequestClass> fillRequestClassList()
        {
            RequestClassBusiness _RequestClassBusiness = new RequestClassBusiness();
            RequestClassList _RequestClassList = _RequestClassBusiness.SelectRows(null, null, null);

            return _RequestClassList;
        }

        private List<RequestPriority> fillRequestPriorityList()
        {
            RequestPriorityBusiness _RequestPriorityBusiness = new RequestPriorityBusiness();
            RequestPriorityList _RequestPriorityList = _RequestPriorityBusiness.SelectRows(null, null, null);

            return _RequestPriorityList;
        }

        private List<RejectReason> fillRejectReasonList()
        {
            RejectReasonBusiness _RejectReasonBusiness = new RejectReasonBusiness();
            RejectReasonList _RejectReasonList = _RejectReasonBusiness.SelectRows(null, null, null);

            return _RejectReasonList;
        }

        private List<CardType> fillCardTypeList()
        {
            CardTypeBusiness _CardTypeBusiness = new CardTypeBusiness();
            CardTypeList _CardTypeList = _CardTypeBusiness.SelectRows(null, null, null);

            return _CardTypeList;
        }

        private List<CardValidity> fillCardValidityList()
        {
            CardValidityBusiness _CardValidityBusiness = new CardValidityBusiness();
            CardValidityList _CardValidityList = _CardValidityBusiness.SelectRows(null, null, null);

            return _CardValidityList;
        }

        private List<WorkField> fillWorkFieldList()
        {
            WorkFieldBusiness _WorkFieldBusiness = new WorkFieldBusiness();
            WorkFieldList _WorkFieldList = _WorkFieldBusiness.SelectRows(null, null, null);

            return _WorkFieldList;
        }

        private List<Customer> fillCustomerList()
        {
            CustomerBusiness _CustomerBusiness = new CustomerBusiness();
            CustomerList _CustomerList = _CustomerBusiness.SelectRows(null, null, null, null, null);

            return _CustomerList;
        }

        private List<User> fillUserList()
        {
            UserBusiness _UserBusiness = new UserBusiness();
            UserList _UserList = _UserBusiness.SelectRows(null, null, null, null, null);

            return _UserList;
        }

        #endregion
    }
}
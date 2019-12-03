using System.Text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using ApplicationBlocks.Layers;
using ApplicationBlocks.Utilities;
using ApplicationBlocks.ExceptionManagement;
using ApplicationBlocks.DatabaseServices;
using Common;

namespace DataAccess
{
	// Summary:
	// The RequestData Class.
	public partial class RequestData
	{
        #region SelectRequestDynamicSearch

        public RequestList SelectRequestDynamicSearch(RequestSearch requestSearch)
        {
            DbTransaction Tran = null;
            return SelectRequestDynamicSearch(Tran, requestSearch);
        }

        public RequestList SelectRequestDynamicSearch(DbTransaction pTran, RequestSearch requestSearch)
        {
            RequestList RequestList = new RequestList();
            Exception exception = null;

            //DbParameter[] Parameters = new DbParameter[16];
            //Parameters[0] = _getIdParameter(requestSearch.Id, ParameterDirection.Input);
            //Parameters[1] = _getrequestNumberParameter(requestSearch.requestNumber, ParameterDirection.Input);
            //Parameters[2] = _getcustomerIDParameter(requestSearch.customerID, ParameterDirection.Input);
            //Parameters[3] = _getcreationDateFromParameter(requestSearch.creationDateFrom, ParameterDirection.Input);
            //Parameters[3] = _getcreationDateToParameter(requestSearch.creationDateTo, ParameterDirection.Input);
            //Parameters[4] = _getcreationUserIDParameter(requestSearch.creationUserID, ParameterDirection.Input);
            //Parameters[5] = _getapprovalDateFromParameter(requestSearch.approvalDateFrom, ParameterDirection.Input);
            //Parameters[5] = _getapprovalDateToParameter(requestSearch.approvalDateTo, ParameterDirection.Input);
            //Parameters[6] = _getapprovalUserIDParameter(requestSearch.approvalUserID, ParameterDirection.Input);
            //Parameters[7] = _getreceiveDateFromParameter(requestSearch.receiveDateFrom, ParameterDirection.Input);
            //Parameters[7] = _getreceiveDateToParameter(requestSearch.receiveDateTo, ParameterDirection.Input);
            //Parameters[8] = _getreceiveUserIDParameter(requestSearch.receiveUserID, ParameterDirection.Input);
            //Parameters[9] = _getrejectionDateFromParameter(requestSearch.rejectionDateFrom, ParameterDirection.Input);
            //Parameters[9] = _getrejectionDateToParameter(requestSearch.rejectionDateTo, ParameterDirection.Input);
            //Parameters[10] = _getrejectionUserIDParameter(requestSearch.rejectionUserID, ParameterDirection.Input);
            //Parameters[11] = _getrejectionReasonIDParameter(requestSearch.rejectionReasonID, ParameterDirection.Input);
            //Parameters[12] = _getrequestTypeIDParameter(requestSearch.requestTypeID, ParameterDirection.Input);
            //Parameters[13] = _getrequestStatusIDParameter(requestSearch.requestStatusID, ParameterDirection.Input);
            //Parameters[14] = _getrequestCalssIDParameter(requestSearch.requestCalssID, ParameterDirection.Input);
            //Parameters[15] = _getrequestPriorityIDParameter(requestSearch.requestPriorityID, ParameterDirection.Input);

            DbParameter[] Parameters = new DbParameter[19];
            Parameters[0] = _getIdParameter(requestSearch.Id, ParameterDirection.Input);
            Parameters[1] = _getrequestNumberParameter(requestSearch.requestNumber, ParameterDirection.Input);
            Parameters[2] = _gettotalQuantityParameter(requestSearch.totalQuantity, ParameterDirection.Input);
            Parameters[3] = _getPDDParameterFrom(requestSearch.PDDFrom, ParameterDirection.Input);
            Parameters[3] = _getPDDParameterTo(requestSearch.PDDTo, ParameterDirection.Input);
            Parameters[4] = _getcustomerIDParameter(requestSearch.customerID, ParameterDirection.Input);
            Parameters[5] = _getcreationDateParameterFrom(requestSearch.creationDateFrom, ParameterDirection.Input);
            Parameters[5] = _getcreationDateParameterTo(requestSearch.creationDateTo, ParameterDirection.Input);
            Parameters[6] = _getcreationUserIDParameter(requestSearch.creationUserID, ParameterDirection.Input);
            Parameters[7] = _getapprovalDateParameterFrom(requestSearch.approvalDateFrom, ParameterDirection.Input);
            Parameters[7] = _getapprovalDateParameterTo(requestSearch.approvalDateTo, ParameterDirection.Input);
            Parameters[8] = _getapprovalUserIDParameter(requestSearch.approvalUserID, ParameterDirection.Input);
            Parameters[9] = _getreceiveDateParameterFrom(requestSearch.receiveDateFrom, ParameterDirection.Input);
            Parameters[9] = _getreceiveDateParameterTo(requestSearch.receiveDateTo, ParameterDirection.Input);
            Parameters[10] = _getreceiveUserIDParameter(requestSearch.receiveUserID, ParameterDirection.Input);
            Parameters[11] = _getrejectionDateParameterFrom(requestSearch.rejectionDateFrom, ParameterDirection.Input);
            Parameters[11] = _getrejectionDateParameterTo(requestSearch.rejectionDateTo, ParameterDirection.Input);
            Parameters[12] = _getrejectionUserIDParameter(requestSearch.rejectionUserID, ParameterDirection.Input);
            Parameters[13] = _getrejectionReasonIDParameter(requestSearch.rejectionReasonID, ParameterDirection.Input);
            Parameters[14] = _getrequestTypeIDParameter(requestSearch.requestTypeID, ParameterDirection.Input);
            Parameters[15] = _getrequestStatusIDParameter(requestSearch.requestStatusID, ParameterDirection.Input);
            Parameters[16] = _getrequestCalssIDParameter(requestSearch.requestCalssID, ParameterDirection.Input);
            Parameters[17] = _getrequestPriorityIDParameter(requestSearch.requestPriorityID, ParameterDirection.Input);
            Parameters[18] = _getcardTypeIDParameter(requestSearch.cardTypeID, ParameterDirection.Input);

            DbDataReader Dr = ExecuteReader(pTran, "[Transactions].[SelectRequestDynamicSearch]", Parameters);

            try
            {
                if (Dr != null)
                {
                    while (Dr.Read())
                    {
                        Request Request = new Request();
                        if (Dr["Id"] != DBNull.Value) Request.Id = (System.Int32)Dr["Id"];
                        if (Dr["requestNumber"] != DBNull.Value) Request.requestNumber = (System.String)Dr["requestNumber"];
                        if (Dr["totalQuantity"] != DBNull.Value) Request.totalQuantity = (System.Int32?)Dr["totalQuantity"];
                        if (Dr["PDD"] != DBNull.Value) Request.PDD = (System.DateTime?)Dr["PDD"];
                        if (Dr["customerID"] != DBNull.Value) Request.customerID = (System.Int32?)Dr["customerID"];
                        if (Dr["creationDate"] != DBNull.Value) Request.creationDate = (System.DateTime?)Dr["creationDate"];
                        if (Dr["creationUserID"] != DBNull.Value) Request.creationUserID = (System.Int32?)Dr["creationUserID"];
                        if (Dr["approvalDate"] != DBNull.Value) Request.approvalDate = (System.DateTime?)Dr["approvalDate"];
                        if (Dr["approvalUserID"] != DBNull.Value) Request.approvalUserID = (System.Int32?)Dr["approvalUserID"];
                        if (Dr["receiveDate"] != DBNull.Value) Request.receiveDate = (System.DateTime?)Dr["receiveDate"];
                        if (Dr["receiveUserID"] != DBNull.Value) Request.receiveUserID = (System.Int32?)Dr["receiveUserID"];
                        if (Dr["rejectionDate"] != DBNull.Value) Request.rejectionDate = (System.DateTime?)Dr["rejectionDate"];
                        if (Dr["rejectionUserID"] != DBNull.Value) Request.rejectionUserID = (System.Int32?)Dr["rejectionUserID"];
                        if (Dr["rejectionReasonID"] != DBNull.Value) Request.rejectionReasonID = (System.Int32?)Dr["rejectionReasonID"];
                        if (Dr["requestTypeID"] != DBNull.Value) Request.requestTypeID = (System.Int32?)Dr["requestTypeID"];
                        if (Dr["requestStatusID"] != DBNull.Value) Request.requestStatusID = (System.Int32?)Dr["requestStatusID"];
                        if (Dr["requestCalssID"] != DBNull.Value) Request.requestCalssID = (System.Int32?)Dr["requestCalssID"];
                        if (Dr["requestPriorityID"] != DBNull.Value) Request.requestPriorityID = (System.Int32?)Dr["requestPriorityID"];
                        RequestList.FillRow(Request);
                        Request = null;
                    }
                }
            }
            catch (Exception Ex)
            {
                exception = Ex;
            }
            finally
            {
                if (Dr != null)
                {
                    if (Dr.IsClosed == false) Dr.Close();
                    Dr = null;
                }
            }
            return RequestList;
        }

        #endregion

        #region Parameters_Custom

        #region _getPDDParameterFrom
        /// <summary>
        /// Methods _getPDDParameter Represent Parameter PDD in CodeGeneratingInfo Table
        /// <param name="pParameterDirection">Specifies the type of a parameter</param>
        /// </summary>
        private DbParameter _getPDDParameterFrom(System.DateTime? PDDFrom, ParameterDirection pParameterDirection)
        {
            return CreateParameter("PDDFrom", PDDFrom, DbType.DateTime, pParameterDirection, 23, 3);
        }
        #endregion

        #region _getPDDParameterTo
        /// <summary>
        /// Methods _getPDDParameter Represent Parameter PDD in CodeGeneratingInfo Table
        /// <param name="pParameterDirection">Specifies the type of a parameter</param>
        /// </summary>
        private DbParameter _getPDDParameterTo(System.DateTime? PDDTo, ParameterDirection pParameterDirection)
        {
            return CreateParameter("PDDTo", PDDTo, DbType.DateTime, pParameterDirection, 23, 3);
        }
        #endregion

        #region _getcreationDateParameterFrom
        /// <summary>
        /// Methods _getcreationDateParameter Represent Parameter creationDate in CodeGeneratingInfo Table
        /// <param name="pParameterDirection">Specifies the type of a parameter</param>
        /// </summary>
        private DbParameter _getcreationDateParameterFrom(System.DateTime? creationDateFrom, ParameterDirection pParameterDirection)
        {
            return CreateParameter("creationDateFrom", creationDateFrom, DbType.DateTime, pParameterDirection, 23, 3);
        }
        #endregion

        #region _getcreationDateParameterTo
        /// <summary>
        /// Methods _getcreationDateParameter Represent Parameter creationDate in CodeGeneratingInfo Table
        /// <param name="pParameterDirection">Specifies the type of a parameter</param>
        /// </summary>
        private DbParameter _getcreationDateParameterTo(System.DateTime? creationDateTo, ParameterDirection pParameterDirection)
        {
            return CreateParameter("creationDateTo", creationDateTo, DbType.DateTime, pParameterDirection, 23, 3);
        }
        #endregion

        #region _getapprovalDateParameterFrom
        /// <summary>
        /// Methods _getapprovalDateParameter Represent Parameter approvalDate in CodeGeneratingInfo Table
        /// <param name="pParameterDirection">Specifies the type of a parameter</param>
        /// </summary>
        private DbParameter _getapprovalDateParameterFrom(System.DateTime? approvalDateFrom, ParameterDirection pParameterDirection)
        {
            return CreateParameter("approvalDateFrom", approvalDateFrom, DbType.DateTime, pParameterDirection, 23, 3);
        }
        #endregion

        #region _getapprovalDateParameterTo
        /// <summary>
        /// Methods _getapprovalDateParameter Represent Parameter approvalDate in CodeGeneratingInfo Table
        /// <param name="pParameterDirection">Specifies the type of a parameter</param>
        /// </summary>
        private DbParameter _getapprovalDateParameterTo(System.DateTime? approvalDateTo, ParameterDirection pParameterDirection)
        {
            return CreateParameter("approvalDateTo", approvalDateTo, DbType.DateTime, pParameterDirection, 23, 3);
        }
        #endregion

        #region _getreceiveDateParameterFrom
        /// <summary>
        /// Methods _getreceiveDateParameter Represent Parameter receiveDate in CodeGeneratingInfo Table
        /// <param name="pParameterDirection">Specifies the type of a parameter</param>
        /// </summary>
        private DbParameter _getreceiveDateParameterFrom(System.DateTime? receiveDateFrom, ParameterDirection pParameterDirection)
        {
            return CreateParameter("receiveDateFrom", receiveDateFrom, DbType.DateTime, pParameterDirection, 23, 3);
        }
        #endregion

        #region _getreceiveDateParameterTo
        /// <summary>
        /// Methods _getreceiveDateParameter Represent Parameter receiveDate in CodeGeneratingInfo Table
        /// <param name="pParameterDirection">Specifies the type of a parameter</param>
        /// </summary>
        private DbParameter _getreceiveDateParameterTo(System.DateTime? receiveDateTo, ParameterDirection pParameterDirection)
        {
            return CreateParameter("receiveDateTo", receiveDateTo, DbType.DateTime, pParameterDirection, 23, 3);
        }
        #endregion

        #region _getrejectionDateFromParameterFrom
        /// <summary>
        /// Methods _getrejectionDateParameter Represent Parameter rejectionDate in CodeGeneratingInfo Table
        /// <param name="pParameterDirection">Specifies the type of a parameter</param>
        /// </summary>
        private DbParameter _getrejectionDateParameterFrom(System.DateTime? rejectionDateFrom, ParameterDirection pParameterDirection)
        {
            return CreateParameter("rejectionDateFrom", rejectionDateFrom, DbType.DateTime, pParameterDirection, 23, 3);
        }
        #endregion

        #region _getrejectionDateParameterTo
        /// <summary>
        /// Methods _getrejectionDateParameter Represent Parameter rejectionDate in CodeGeneratingInfo Table
        /// <param name="pParameterDirection">Specifies the type of a parameter</param>
        /// </summary>
        private DbParameter _getrejectionDateParameterTo(System.DateTime? rejectionDateTo, ParameterDirection pParameterDirection)
        {
            return CreateParameter("rejectionDateTo", rejectionDateTo, DbType.DateTime, pParameterDirection, 23, 3);
        }
        #endregion

        #region _getcardTypeIDParameter
        /// <summary>
        /// Methods _getreceiveUserIDParameter Represent Parameter receiveUserID in CodeGeneratingInfo Table
        /// <param name="pParameterDirection">Specifies the type of a parameter</param>
        /// </summary>
        private DbParameter _getcardTypeIDParameter(System.Int32? cardTypeID, ParameterDirection pParameterDirection)
        {
            return CreateParameter("cardTypeID", cardTypeID, DbType.Int32, pParameterDirection, 4);
        }
        #endregion

        #endregion
    }
}

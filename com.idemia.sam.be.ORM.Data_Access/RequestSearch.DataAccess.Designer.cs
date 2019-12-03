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
	// The RequestSearchData Class.
	[Serializable]
	public partial class RequestSearchData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(RequestSearch RequestSearch)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RequestSearch);
		}

		public int InsertRow(DbTransaction pTran,RequestSearch RequestSearch)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[24];
			Parameters[0] = _getIdParameter(RequestSearch.Id, ParameterDirection.Output);
			Parameters[1] = _getrequestNumberParameter(RequestSearch.requestNumber, ParameterDirection.Input);
			Parameters[2] = _gettotalQuantityParameter(RequestSearch.totalQuantity, ParameterDirection.Input);
			Parameters[3] = _getPDDFromParameter(RequestSearch.PDDFrom, ParameterDirection.Input);
			Parameters[4] = _getPDDToParameter(RequestSearch.PDDTo, ParameterDirection.Input);
			Parameters[5] = _getcustomerIDParameter(RequestSearch.customerID, ParameterDirection.Input);
			Parameters[6] = _getcreationDateFromParameter(RequestSearch.creationDateFrom, ParameterDirection.Input);
			Parameters[7] = _getcreationDateToParameter(RequestSearch.creationDateTo, ParameterDirection.Input);
			Parameters[8] = _getcreationUserIDParameter(RequestSearch.creationUserID, ParameterDirection.Input);
			Parameters[9] = _getapprovalDateFromParameter(RequestSearch.approvalDateFrom, ParameterDirection.Input);
			Parameters[10] = _getapprovalDateToParameter(RequestSearch.approvalDateTo, ParameterDirection.Input);
			Parameters[11] = _getapprovalUserIDParameter(RequestSearch.approvalUserID, ParameterDirection.Input);
			Parameters[12] = _getreceiveDateFromParameter(RequestSearch.receiveDateFrom, ParameterDirection.Input);
			Parameters[13] = _getreceiveDateToParameter(RequestSearch.receiveDateTo, ParameterDirection.Input);
			Parameters[14] = _getreceiveUserIDParameter(RequestSearch.receiveUserID, ParameterDirection.Input);
			Parameters[15] = _getrejectionDateFromParameter(RequestSearch.rejectionDateFrom, ParameterDirection.Input);
			Parameters[16] = _getrejectionDateToParameter(RequestSearch.rejectionDateTo, ParameterDirection.Input);
			Parameters[17] = _getrejectionUserIDParameter(RequestSearch.rejectionUserID, ParameterDirection.Input);
			Parameters[18] = _getrejectionReasonIDParameter(RequestSearch.rejectionReasonID, ParameterDirection.Input);
			Parameters[19] = _getrequestTypeIDParameter(RequestSearch.requestTypeID, ParameterDirection.Input);
			Parameters[20] = _getrequestStatusIDParameter(RequestSearch.requestStatusID, ParameterDirection.Input);
			Parameters[21] = _getrequestCalssIDParameter(RequestSearch.requestCalssID, ParameterDirection.Input);
			Parameters[22] = _getrequestPriorityIDParameter(RequestSearch.requestPriorityID, ParameterDirection.Input);
			Parameters[23] = _getcardTypeIDParameter(RequestSearch.cardTypeID, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Transactions].[InsertRequestSearch]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				RequestSearch.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(RequestSearch RequestSearch)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RequestSearch);
		}

		public int UpdateRow(DbTransaction pTran,RequestSearch RequestSearch)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[24];
			Parameters[0] = _getIdParameter(RequestSearch.Id, ParameterDirection.Input);
			Parameters[1] = _getrequestNumberParameter(RequestSearch.requestNumber, ParameterDirection.Input);
			Parameters[2] = _gettotalQuantityParameter(RequestSearch.totalQuantity, ParameterDirection.Input);
			Parameters[3] = _getPDDFromParameter(RequestSearch.PDDFrom, ParameterDirection.Input);
			Parameters[4] = _getPDDToParameter(RequestSearch.PDDTo, ParameterDirection.Input);
			Parameters[5] = _getcustomerIDParameter(RequestSearch.customerID, ParameterDirection.Input);
			Parameters[6] = _getcreationDateFromParameter(RequestSearch.creationDateFrom, ParameterDirection.Input);
			Parameters[7] = _getcreationDateToParameter(RequestSearch.creationDateTo, ParameterDirection.Input);
			Parameters[8] = _getcreationUserIDParameter(RequestSearch.creationUserID, ParameterDirection.Input);
			Parameters[9] = _getapprovalDateFromParameter(RequestSearch.approvalDateFrom, ParameterDirection.Input);
			Parameters[10] = _getapprovalDateToParameter(RequestSearch.approvalDateTo, ParameterDirection.Input);
			Parameters[11] = _getapprovalUserIDParameter(RequestSearch.approvalUserID, ParameterDirection.Input);
			Parameters[12] = _getreceiveDateFromParameter(RequestSearch.receiveDateFrom, ParameterDirection.Input);
			Parameters[13] = _getreceiveDateToParameter(RequestSearch.receiveDateTo, ParameterDirection.Input);
			Parameters[14] = _getreceiveUserIDParameter(RequestSearch.receiveUserID, ParameterDirection.Input);
			Parameters[15] = _getrejectionDateFromParameter(RequestSearch.rejectionDateFrom, ParameterDirection.Input);
			Parameters[16] = _getrejectionDateToParameter(RequestSearch.rejectionDateTo, ParameterDirection.Input);
			Parameters[17] = _getrejectionUserIDParameter(RequestSearch.rejectionUserID, ParameterDirection.Input);
			Parameters[18] = _getrejectionReasonIDParameter(RequestSearch.rejectionReasonID, ParameterDirection.Input);
			Parameters[19] = _getrequestTypeIDParameter(RequestSearch.requestTypeID, ParameterDirection.Input);
			Parameters[20] = _getrequestStatusIDParameter(RequestSearch.requestStatusID, ParameterDirection.Input);
			Parameters[21] = _getrequestCalssIDParameter(RequestSearch.requestCalssID, ParameterDirection.Input);
			Parameters[22] = _getrequestPriorityIDParameter(RequestSearch.requestPriorityID, ParameterDirection.Input);
			Parameters[23] = _getcardTypeIDParameter(RequestSearch.cardTypeID, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Transactions].[UpdateRequestSearch]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(RequestSearch RequestSearch)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RequestSearch);
		}

		public int DeleteRow(DbTransaction pTran,RequestSearch RequestSearch)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(RequestSearch.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Transactions].[DeleteRequestSearch]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(RequestSearchList RequestSearchList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestSearchList);
		}

		public int SaveRows(DbTransaction pTran,RequestSearchList RequestSearchList)
		{
			int intRows = 0;

			for (int i = 0; i < RequestSearchList.Count; i++)
			{
				switch (RequestSearchList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, RequestSearchList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, RequestSearchList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, RequestSearchList[i]);
						break;
				}
			}

			return intRows;
		}

		#endregion

		#region SelectRows

		public RequestSearchList SelectRows(System.Int32? Id,System.String requestNumber,System.DateTime? creationDateFrom,System.DateTime? creationDateTo,System.DateTime? approvalDateFrom,System.DateTime? approvalDateTo,System.DateTime? receiveDateFrom,System.DateTime? receiveDateTo,System.DateTime? rejectionDateFrom,System.DateTime? rejectionDateTo)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,requestNumber,creationDateFrom,creationDateTo,approvalDateFrom,approvalDateTo,receiveDateFrom,receiveDateTo,rejectionDateFrom,rejectionDateTo);
		}

		public RequestSearchList SelectRows(DbTransaction pTran,System.Int32? Id,System.String requestNumber,System.DateTime? creationDateFrom,System.DateTime? creationDateTo,System.DateTime? approvalDateFrom,System.DateTime? approvalDateTo,System.DateTime? receiveDateFrom,System.DateTime? receiveDateTo,System.DateTime? rejectionDateFrom,System.DateTime? rejectionDateTo)
		{
			RequestSearchList RequestSearchList = new RequestSearchList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[10];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getrequestNumberParameter(requestNumber, ParameterDirection.Input);
			Parameters[2] = _getcreationDateFromParameter(creationDateFrom, ParameterDirection.Input);
			Parameters[3] = _getcreationDateToParameter(creationDateTo, ParameterDirection.Input);
			Parameters[4] = _getapprovalDateFromParameter(approvalDateFrom, ParameterDirection.Input);
			Parameters[5] = _getapprovalDateToParameter(approvalDateTo, ParameterDirection.Input);
			Parameters[6] = _getreceiveDateFromParameter(receiveDateFrom, ParameterDirection.Input);
			Parameters[7] = _getreceiveDateToParameter(receiveDateTo, ParameterDirection.Input);
			Parameters[8] = _getrejectionDateFromParameter(rejectionDateFrom, ParameterDirection.Input);
			Parameters[9] = _getrejectionDateToParameter(rejectionDateTo, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Transactions].[SelectRequestSearch]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						RequestSearch RequestSearch = new RequestSearch();
						if (Dr["Id"] != DBNull.Value) RequestSearch.Id = (System.Int32)Dr["Id"];
						if (Dr["requestNumber"] != DBNull.Value) RequestSearch.requestNumber = (System.String)Dr["requestNumber"];
						if (Dr["totalQuantity"] != DBNull.Value) RequestSearch.totalQuantity = (System.Int32?)Dr["totalQuantity"];
						if (Dr["PDDFrom"] != DBNull.Value) RequestSearch.PDDFrom = (System.DateTime?)Dr["PDDFrom"];
						if (Dr["PDDTo"] != DBNull.Value) RequestSearch.PDDTo = (System.DateTime?)Dr["PDDTo"];
						if (Dr["customerID"] != DBNull.Value) RequestSearch.customerID = (System.Int32?)Dr["customerID"];
						if (Dr["creationDateFrom"] != DBNull.Value) RequestSearch.creationDateFrom = (System.DateTime?)Dr["creationDateFrom"];
						if (Dr["creationDateTo"] != DBNull.Value) RequestSearch.creationDateTo = (System.DateTime?)Dr["creationDateTo"];
						if (Dr["creationUserID"] != DBNull.Value) RequestSearch.creationUserID = (System.Int32?)Dr["creationUserID"];
						if (Dr["approvalDateFrom"] != DBNull.Value) RequestSearch.approvalDateFrom = (System.DateTime?)Dr["approvalDateFrom"];
						if (Dr["approvalDateTo"] != DBNull.Value) RequestSearch.approvalDateTo = (System.DateTime?)Dr["approvalDateTo"];
						if (Dr["approvalUserID"] != DBNull.Value) RequestSearch.approvalUserID = (System.Int32?)Dr["approvalUserID"];
						if (Dr["receiveDateFrom"] != DBNull.Value) RequestSearch.receiveDateFrom = (System.DateTime?)Dr["receiveDateFrom"];
						if (Dr["receiveDateTo"] != DBNull.Value) RequestSearch.receiveDateTo = (System.DateTime?)Dr["receiveDateTo"];
						if (Dr["receiveUserID"] != DBNull.Value) RequestSearch.receiveUserID = (System.Int32?)Dr["receiveUserID"];
						if (Dr["rejectionDateFrom"] != DBNull.Value) RequestSearch.rejectionDateFrom = (System.DateTime?)Dr["rejectionDateFrom"];
						if (Dr["rejectionDateTo"] != DBNull.Value) RequestSearch.rejectionDateTo = (System.DateTime?)Dr["rejectionDateTo"];
						if (Dr["rejectionUserID"] != DBNull.Value) RequestSearch.rejectionUserID = (System.Int32?)Dr["rejectionUserID"];
						if (Dr["rejectionReasonID"] != DBNull.Value) RequestSearch.rejectionReasonID = (System.Int32?)Dr["rejectionReasonID"];
						if (Dr["requestTypeID"] != DBNull.Value) RequestSearch.requestTypeID = (System.Int32?)Dr["requestTypeID"];
						if (Dr["requestStatusID"] != DBNull.Value) RequestSearch.requestStatusID = (System.Int32?)Dr["requestStatusID"];
						if (Dr["requestCalssID"] != DBNull.Value) RequestSearch.requestCalssID = (System.Int32?)Dr["requestCalssID"];
						if (Dr["requestPriorityID"] != DBNull.Value) RequestSearch.requestPriorityID = (System.Int32?)Dr["requestPriorityID"];
						if (Dr["cardTypeID"] != DBNull.Value) RequestSearch.cardTypeID = (System.Int32?)Dr["cardTypeID"];
						RequestSearchList.FillRow(RequestSearch);
						RequestSearch = null;
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
					if(Dr.IsClosed==false)Dr.Close();
					Dr = null;
				}
			}
			return RequestSearchList;
		}

		#endregion

		#region Parameters
		#region _getIdParameter
		/// <summary>
		/// Methods _getIdParameter Represent Parameter Id in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getIdParameter(System.Int32? Id,ParameterDirection pParameterDirection)
		{
			return CreateParameter("Id",Id,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getrequestNumberParameter
		/// <summary>
		/// Methods _getrequestNumberParameter Represent Parameter requestNumber in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getrequestNumberParameter(System.String requestNumber,ParameterDirection pParameterDirection)
		{
			return CreateParameter("requestNumber",requestNumber,DbType.String,pParameterDirection,20);
		}
		#endregion
	
		#region _gettotalQuantityParameter
		/// <summary>
		/// Methods _gettotalQuantityParameter Represent Parameter totalQuantity in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _gettotalQuantityParameter(System.Int32? totalQuantity,ParameterDirection pParameterDirection)
		{
			return CreateParameter("totalQuantity",totalQuantity,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getPDDFromParameter
		/// <summary>
		/// Methods _getPDDFromParameter Represent Parameter PDDFrom in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getPDDFromParameter(System.DateTime? PDDFrom,ParameterDirection pParameterDirection)
		{
			return CreateParameter("PDDFrom",PDDFrom,DbType.DateTime,pParameterDirection,23,3);
		}
		#endregion
	
		#region _getPDDToParameter
		/// <summary>
		/// Methods _getPDDToParameter Represent Parameter PDDTo in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getPDDToParameter(System.DateTime? PDDTo,ParameterDirection pParameterDirection)
		{
			return CreateParameter("PDDTo",PDDTo,DbType.DateTime,pParameterDirection,23,3);
		}
		#endregion
	
		#region _getcustomerIDParameter
		/// <summary>
		/// Methods _getcustomerIDParameter Represent Parameter customerID in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getcustomerIDParameter(System.Int32? customerID,ParameterDirection pParameterDirection)
		{
			return CreateParameter("customerID",customerID,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getcreationDateFromParameter
		/// <summary>
		/// Methods _getcreationDateFromParameter Represent Parameter creationDateFrom in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getcreationDateFromParameter(System.DateTime? creationDateFrom,ParameterDirection pParameterDirection)
		{
			return CreateParameter("creationDateFrom",creationDateFrom,DbType.DateTime,pParameterDirection,23,3);
		}
		#endregion
	
		#region _getcreationDateToParameter
		/// <summary>
		/// Methods _getcreationDateToParameter Represent Parameter creationDateTo in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getcreationDateToParameter(System.DateTime? creationDateTo,ParameterDirection pParameterDirection)
		{
			return CreateParameter("creationDateTo",creationDateTo,DbType.DateTime,pParameterDirection,23,3);
		}
		#endregion
	
		#region _getcreationUserIDParameter
		/// <summary>
		/// Methods _getcreationUserIDParameter Represent Parameter creationUserID in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getcreationUserIDParameter(System.Int32? creationUserID,ParameterDirection pParameterDirection)
		{
			return CreateParameter("creationUserID",creationUserID,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getapprovalDateFromParameter
		/// <summary>
		/// Methods _getapprovalDateFromParameter Represent Parameter approvalDateFrom in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getapprovalDateFromParameter(System.DateTime? approvalDateFrom,ParameterDirection pParameterDirection)
		{
			return CreateParameter("approvalDateFrom",approvalDateFrom,DbType.DateTime,pParameterDirection,23,3);
		}
		#endregion
	
		#region _getapprovalDateToParameter
		/// <summary>
		/// Methods _getapprovalDateToParameter Represent Parameter approvalDateTo in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getapprovalDateToParameter(System.DateTime? approvalDateTo,ParameterDirection pParameterDirection)
		{
			return CreateParameter("approvalDateTo",approvalDateTo,DbType.DateTime,pParameterDirection,23,3);
		}
		#endregion
	
		#region _getapprovalUserIDParameter
		/// <summary>
		/// Methods _getapprovalUserIDParameter Represent Parameter approvalUserID in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getapprovalUserIDParameter(System.Int32? approvalUserID,ParameterDirection pParameterDirection)
		{
			return CreateParameter("approvalUserID",approvalUserID,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getreceiveDateFromParameter
		/// <summary>
		/// Methods _getreceiveDateFromParameter Represent Parameter receiveDateFrom in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getreceiveDateFromParameter(System.DateTime? receiveDateFrom,ParameterDirection pParameterDirection)
		{
			return CreateParameter("receiveDateFrom",receiveDateFrom,DbType.DateTime,pParameterDirection,23,3);
		}
		#endregion
	
		#region _getreceiveDateToParameter
		/// <summary>
		/// Methods _getreceiveDateToParameter Represent Parameter receiveDateTo in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getreceiveDateToParameter(System.DateTime? receiveDateTo,ParameterDirection pParameterDirection)
		{
			return CreateParameter("receiveDateTo",receiveDateTo,DbType.DateTime,pParameterDirection,23,3);
		}
		#endregion
	
		#region _getreceiveUserIDParameter
		/// <summary>
		/// Methods _getreceiveUserIDParameter Represent Parameter receiveUserID in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getreceiveUserIDParameter(System.Int32? receiveUserID,ParameterDirection pParameterDirection)
		{
			return CreateParameter("receiveUserID",receiveUserID,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getrejectionDateFromParameter
		/// <summary>
		/// Methods _getrejectionDateFromParameter Represent Parameter rejectionDateFrom in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getrejectionDateFromParameter(System.DateTime? rejectionDateFrom,ParameterDirection pParameterDirection)
		{
			return CreateParameter("rejectionDateFrom",rejectionDateFrom,DbType.DateTime,pParameterDirection,23,3);
		}
		#endregion
	
		#region _getrejectionDateToParameter
		/// <summary>
		/// Methods _getrejectionDateToParameter Represent Parameter rejectionDateTo in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getrejectionDateToParameter(System.DateTime? rejectionDateTo,ParameterDirection pParameterDirection)
		{
			return CreateParameter("rejectionDateTo",rejectionDateTo,DbType.DateTime,pParameterDirection,23,3);
		}
		#endregion
	
		#region _getrejectionUserIDParameter
		/// <summary>
		/// Methods _getrejectionUserIDParameter Represent Parameter rejectionUserID in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getrejectionUserIDParameter(System.Int32? rejectionUserID,ParameterDirection pParameterDirection)
		{
			return CreateParameter("rejectionUserID",rejectionUserID,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getrejectionReasonIDParameter
		/// <summary>
		/// Methods _getrejectionReasonIDParameter Represent Parameter rejectionReasonID in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getrejectionReasonIDParameter(System.Int32? rejectionReasonID,ParameterDirection pParameterDirection)
		{
			return CreateParameter("rejectionReasonID",rejectionReasonID,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getrequestTypeIDParameter
		/// <summary>
		/// Methods _getrequestTypeIDParameter Represent Parameter requestTypeID in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getrequestTypeIDParameter(System.Int32? requestTypeID,ParameterDirection pParameterDirection)
		{
			return CreateParameter("requestTypeID",requestTypeID,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getrequestStatusIDParameter
		/// <summary>
		/// Methods _getrequestStatusIDParameter Represent Parameter requestStatusID in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getrequestStatusIDParameter(System.Int32? requestStatusID,ParameterDirection pParameterDirection)
		{
			return CreateParameter("requestStatusID",requestStatusID,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getrequestCalssIDParameter
		/// <summary>
		/// Methods _getrequestCalssIDParameter Represent Parameter requestCalssID in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getrequestCalssIDParameter(System.Int32? requestCalssID,ParameterDirection pParameterDirection)
		{
			return CreateParameter("requestCalssID",requestCalssID,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getrequestPriorityIDParameter
		/// <summary>
		/// Methods _getrequestPriorityIDParameter Represent Parameter requestPriorityID in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getrequestPriorityIDParameter(System.Int32? requestPriorityID,ParameterDirection pParameterDirection)
		{
			return CreateParameter("requestPriorityID",requestPriorityID,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getcardTypeIDParameter
		/// <summary>
		/// Methods _getcardTypeIDParameter Represent Parameter cardTypeID in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getcardTypeIDParameter(System.Int32? cardTypeID,ParameterDirection pParameterDirection)
		{
			return CreateParameter("cardTypeID",cardTypeID,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#endregion

	}
}

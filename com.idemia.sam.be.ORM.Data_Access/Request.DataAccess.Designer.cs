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
	[Serializable]
	public partial class RequestData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(Request Request)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, Request);
		}

		public int InsertRow(DbTransaction pTran,Request Request)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[18];
			Parameters[0] = _getIdParameter(Request.Id, ParameterDirection.Output);
			Parameters[1] = _getrequestNumberParameter(Request.requestNumber, ParameterDirection.Input);
			Parameters[2] = _gettotalQuantityParameter(Request.totalQuantity, ParameterDirection.Input);
			Parameters[3] = _getPDDParameter(Request.PDD, ParameterDirection.Input);
			Parameters[4] = _getcustomerIDParameter(Request.customerID, ParameterDirection.Input);
			Parameters[5] = _getcreationDateParameter(Request.creationDate, ParameterDirection.Input);
			Parameters[6] = _getcreationUserIDParameter(Request.creationUserID, ParameterDirection.Input);
			Parameters[7] = _getapprovalDateParameter(Request.approvalDate, ParameterDirection.Input);
			Parameters[8] = _getapprovalUserIDParameter(Request.approvalUserID, ParameterDirection.Input);
			Parameters[9] = _getreceiveDateParameter(Request.receiveDate, ParameterDirection.Input);
			Parameters[10] = _getreceiveUserIDParameter(Request.receiveUserID, ParameterDirection.Input);
			Parameters[11] = _getrejectionDateParameter(Request.rejectionDate, ParameterDirection.Input);
			Parameters[12] = _getrejectionUserIDParameter(Request.rejectionUserID, ParameterDirection.Input);
			Parameters[13] = _getrejectionReasonIDParameter(Request.rejectionReasonID, ParameterDirection.Input);
			Parameters[14] = _getrequestTypeIDParameter(Request.requestTypeID, ParameterDirection.Input);
			Parameters[15] = _getrequestStatusIDParameter(Request.requestStatusID, ParameterDirection.Input);
			Parameters[16] = _getrequestCalssIDParameter(Request.requestCalssID, ParameterDirection.Input);
			Parameters[17] = _getrequestPriorityIDParameter(Request.requestPriorityID, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Transactions].[InsertRequest]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				Request.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(Request Request)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, Request);
		}

		public int UpdateRow(DbTransaction pTran,Request Request)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[18];
			Parameters[0] = _getIdParameter(Request.Id, ParameterDirection.Input);
			Parameters[1] = _getrequestNumberParameter(Request.requestNumber, ParameterDirection.Input);
			Parameters[2] = _gettotalQuantityParameter(Request.totalQuantity, ParameterDirection.Input);
			Parameters[3] = _getPDDParameter(Request.PDD, ParameterDirection.Input);
			Parameters[4] = _getcustomerIDParameter(Request.customerID, ParameterDirection.Input);
			Parameters[5] = _getcreationDateParameter(Request.creationDate, ParameterDirection.Input);
			Parameters[6] = _getcreationUserIDParameter(Request.creationUserID, ParameterDirection.Input);
			Parameters[7] = _getapprovalDateParameter(Request.approvalDate, ParameterDirection.Input);
			Parameters[8] = _getapprovalUserIDParameter(Request.approvalUserID, ParameterDirection.Input);
			Parameters[9] = _getreceiveDateParameter(Request.receiveDate, ParameterDirection.Input);
			Parameters[10] = _getreceiveUserIDParameter(Request.receiveUserID, ParameterDirection.Input);
			Parameters[11] = _getrejectionDateParameter(Request.rejectionDate, ParameterDirection.Input);
			Parameters[12] = _getrejectionUserIDParameter(Request.rejectionUserID, ParameterDirection.Input);
			Parameters[13] = _getrejectionReasonIDParameter(Request.rejectionReasonID, ParameterDirection.Input);
			Parameters[14] = _getrequestTypeIDParameter(Request.requestTypeID, ParameterDirection.Input);
			Parameters[15] = _getrequestStatusIDParameter(Request.requestStatusID, ParameterDirection.Input);
			Parameters[16] = _getrequestCalssIDParameter(Request.requestCalssID, ParameterDirection.Input);
			Parameters[17] = _getrequestPriorityIDParameter(Request.requestPriorityID, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Transactions].[UpdateRequest]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(Request Request)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, Request);
		}

		public int DeleteRow(DbTransaction pTran,Request Request)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(Request.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Transactions].[DeleteRequest]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(RequestList RequestList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestList);
		}

		public int SaveRows(DbTransaction pTran,RequestList RequestList)
		{
			int intRows = 0;

			for (int i = 0; i < RequestList.Count; i++)
			{
				switch (RequestList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, RequestList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, RequestList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, RequestList[i]);
						break;
				}
			}

			return intRows;
		}

		#endregion

		#region SelectRows

		public RequestList SelectRows(System.Int32? Id,System.String requestNumber,System.Int32? customerID,System.DateTime? creationDate,System.Int32? creationUserID,System.DateTime? approvalDate,System.Int32? approvalUserID,System.DateTime? receiveDate,System.Int32? receiveUserID,System.DateTime? rejectionDate,System.Int32? rejectionUserID,System.Int32? rejectionReasonID,System.Int32? requestTypeID,System.Int32? requestStatusID,System.Int32? requestCalssID,System.Int32? requestPriorityID)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,requestNumber,customerID,creationDate,creationUserID,approvalDate,approvalUserID,receiveDate,receiveUserID,rejectionDate,rejectionUserID,rejectionReasonID,requestTypeID,requestStatusID,requestCalssID,requestPriorityID);
		}

		public RequestList SelectRows(DbTransaction pTran,System.Int32? Id,System.String requestNumber,System.Int32? customerID,System.DateTime? creationDate,System.Int32? creationUserID,System.DateTime? approvalDate,System.Int32? approvalUserID,System.DateTime? receiveDate,System.Int32? receiveUserID,System.DateTime? rejectionDate,System.Int32? rejectionUserID,System.Int32? rejectionReasonID,System.Int32? requestTypeID,System.Int32? requestStatusID,System.Int32? requestCalssID,System.Int32? requestPriorityID)
		{
			RequestList RequestList = new RequestList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[16];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getrequestNumberParameter(requestNumber, ParameterDirection.Input);
			Parameters[2] = _getcustomerIDParameter(customerID, ParameterDirection.Input);
			Parameters[3] = _getcreationDateParameter(creationDate, ParameterDirection.Input);
			Parameters[4] = _getcreationUserIDParameter(creationUserID, ParameterDirection.Input);
			Parameters[5] = _getapprovalDateParameter(approvalDate, ParameterDirection.Input);
			Parameters[6] = _getapprovalUserIDParameter(approvalUserID, ParameterDirection.Input);
			Parameters[7] = _getreceiveDateParameter(receiveDate, ParameterDirection.Input);
			Parameters[8] = _getreceiveUserIDParameter(receiveUserID, ParameterDirection.Input);
			Parameters[9] = _getrejectionDateParameter(rejectionDate, ParameterDirection.Input);
			Parameters[10] = _getrejectionUserIDParameter(rejectionUserID, ParameterDirection.Input);
			Parameters[11] = _getrejectionReasonIDParameter(rejectionReasonID, ParameterDirection.Input);
			Parameters[12] = _getrequestTypeIDParameter(requestTypeID, ParameterDirection.Input);
			Parameters[13] = _getrequestStatusIDParameter(requestStatusID, ParameterDirection.Input);
			Parameters[14] = _getrequestCalssIDParameter(requestCalssID, ParameterDirection.Input);
			Parameters[15] = _getrequestPriorityIDParameter(requestPriorityID, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Transactions].[SelectRequest]", Parameters);

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
					if(Dr.IsClosed==false)Dr.Close();
					Dr = null;
				}
			}
			return RequestList;
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
	
		#region _getPDDParameter
		/// <summary>
		/// Methods _getPDDParameter Represent Parameter PDD in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getPDDParameter(System.DateTime? PDD,ParameterDirection pParameterDirection)
		{
			return CreateParameter("PDD",PDD,DbType.DateTime,pParameterDirection,23,3);
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
	
		#region _getcreationDateParameter
		/// <summary>
		/// Methods _getcreationDateParameter Represent Parameter creationDate in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getcreationDateParameter(System.DateTime? creationDate,ParameterDirection pParameterDirection)
		{
			return CreateParameter("creationDate",creationDate,DbType.DateTime,pParameterDirection,23,3);
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
	
		#region _getapprovalDateParameter
		/// <summary>
		/// Methods _getapprovalDateParameter Represent Parameter approvalDate in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getapprovalDateParameter(System.DateTime? approvalDate,ParameterDirection pParameterDirection)
		{
			return CreateParameter("approvalDate",approvalDate,DbType.DateTime,pParameterDirection,23,3);
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
	
		#region _getreceiveDateParameter
		/// <summary>
		/// Methods _getreceiveDateParameter Represent Parameter receiveDate in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getreceiveDateParameter(System.DateTime? receiveDate,ParameterDirection pParameterDirection)
		{
			return CreateParameter("receiveDate",receiveDate,DbType.DateTime,pParameterDirection,23,3);
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
	
		#region _getrejectionDateParameter
		/// <summary>
		/// Methods _getrejectionDateParameter Represent Parameter rejectionDate in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getrejectionDateParameter(System.DateTime? rejectionDate,ParameterDirection pParameterDirection)
		{
			return CreateParameter("rejectionDate",rejectionDate,DbType.DateTime,pParameterDirection,23,3);
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
	
		#endregion

	}
}

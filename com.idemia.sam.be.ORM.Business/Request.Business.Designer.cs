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
using DataAccess;

namespace Business
{
	// Summary:
	// The RequestBusiness Class.
	[Serializable]
	public partial class RequestBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private RequestData RequestData = new RequestData();
	
		#region InsertRow

		public int InsertRow(Request Request)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, Request,false);
		}

		public int InsertRow(DbTransaction pTran, Request Request)
		{
			return InsertRow(pTran, Request,false);
		}

		public int InsertRow(DbTransaction pTran, Request Request,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestData.CreateTransaction();
				}
				intRow = RequestData.InsertRow(objTran, Request);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestData.RollbackTransaction(objTran,true);
					objTran = null;
				}
			}
			finally
			{
			}
			return intRow;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(Request Request)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, Request,false);
		}

		public int UpdateRow(DbTransaction pTran, Request Request)
		{
			return UpdateRow(pTran, Request,false);
		}

		public int UpdateRow(DbTransaction pTran, Request Request,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestData.CreateTransaction();
				}
				intRow = RequestData.UpdateRow(objTran, Request);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestData.RollbackTransaction(objTran,true);
					objTran = null;
				}
			}
			finally
			{
			}
			return intRow;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(Request Request)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, Request,false);
		}

		public int DeleteRow(DbTransaction pTran, Request Request)
		{
			return DeleteRow(pTran, Request,false);
		}

		public int DeleteRow(DbTransaction pTran, Request Request,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestData.CreateTransaction();
				}
				intRow = RequestData.DeleteRow(objTran, Request);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestData.RollbackTransaction(objTran,true);
					objTran = null;
				}
			}
			finally
			{
			}
			return intRow;
		}

		#endregion

		#region SaveRows

		public int SaveRows(RequestList RequestList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestList RequestList)
		{
			return SaveRows(pTran, RequestList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestList RequestList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestData.CreateTransaction();
				}
				intRows = RequestData.SaveRows(objTran, RequestList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestData.RollbackTransaction(objTran,true);
					objTran = null;
				}
			}
			finally
			{
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
			return RequestData.SelectRows(pTran, Id,requestNumber,customerID,creationDate,creationUserID,approvalDate,approvalUserID,receiveDate,receiveUserID,rejectionDate,rejectionUserID,rejectionReasonID,requestTypeID,requestStatusID,requestCalssID,requestPriorityID);
		}

		#endregion

	}
}

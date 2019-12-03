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
	// The RequestStatusBusiness Class.
	[Serializable]
	public partial class RequestStatusBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private RequestStatusData RequestStatusData = new RequestStatusData();
	
		#region InsertRow

		public int InsertRow(RequestStatus RequestStatus)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RequestStatus,false);
		}

		public int InsertRow(DbTransaction pTran, RequestStatus RequestStatus)
		{
			return InsertRow(pTran, RequestStatus,false);
		}

		public int InsertRow(DbTransaction pTran, RequestStatus RequestStatus,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestStatusData.CreateTransaction();
				}
				intRow = RequestStatusData.InsertRow(objTran, RequestStatus);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestStatusData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestStatusData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(RequestStatus RequestStatus)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RequestStatus,false);
		}

		public int UpdateRow(DbTransaction pTran, RequestStatus RequestStatus)
		{
			return UpdateRow(pTran, RequestStatus,false);
		}

		public int UpdateRow(DbTransaction pTran, RequestStatus RequestStatus,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestStatusData.CreateTransaction();
				}
				intRow = RequestStatusData.UpdateRow(objTran, RequestStatus);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestStatusData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestStatusData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(RequestStatus RequestStatus)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RequestStatus,false);
		}

		public int DeleteRow(DbTransaction pTran, RequestStatus RequestStatus)
		{
			return DeleteRow(pTran, RequestStatus,false);
		}

		public int DeleteRow(DbTransaction pTran, RequestStatus RequestStatus,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestStatusData.CreateTransaction();
				}
				intRow = RequestStatusData.DeleteRow(objTran, RequestStatus);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestStatusData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestStatusData.RollbackTransaction(objTran,true);
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

		public int SaveRows(RequestStatusList RequestStatusList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestStatusList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestStatusList RequestStatusList)
		{
			return SaveRows(pTran, RequestStatusList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestStatusList RequestStatusList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestStatusData.CreateTransaction();
				}
				intRows = RequestStatusData.SaveRows(objTran, RequestStatusList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestStatusData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestStatusData.RollbackTransaction(objTran,true);
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

		public RequestStatusList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public RequestStatusList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			return RequestStatusData.SelectRows(pTran, Id,name,nameAr);
		}

		#endregion

	}
}

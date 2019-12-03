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
	// The RequestPriorityBusiness Class.
	[Serializable]
	public partial class RequestPriorityBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private RequestPriorityData RequestPriorityData = new RequestPriorityData();
	
		#region InsertRow

		public int InsertRow(RequestPriority RequestPriority)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RequestPriority,false);
		}

		public int InsertRow(DbTransaction pTran, RequestPriority RequestPriority)
		{
			return InsertRow(pTran, RequestPriority,false);
		}

		public int InsertRow(DbTransaction pTran, RequestPriority RequestPriority,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestPriorityData.CreateTransaction();
				}
				intRow = RequestPriorityData.InsertRow(objTran, RequestPriority);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestPriorityData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestPriorityData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(RequestPriority RequestPriority)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RequestPriority,false);
		}

		public int UpdateRow(DbTransaction pTran, RequestPriority RequestPriority)
		{
			return UpdateRow(pTran, RequestPriority,false);
		}

		public int UpdateRow(DbTransaction pTran, RequestPriority RequestPriority,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestPriorityData.CreateTransaction();
				}
				intRow = RequestPriorityData.UpdateRow(objTran, RequestPriority);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestPriorityData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestPriorityData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(RequestPriority RequestPriority)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RequestPriority,false);
		}

		public int DeleteRow(DbTransaction pTran, RequestPriority RequestPriority)
		{
			return DeleteRow(pTran, RequestPriority,false);
		}

		public int DeleteRow(DbTransaction pTran, RequestPriority RequestPriority,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestPriorityData.CreateTransaction();
				}
				intRow = RequestPriorityData.DeleteRow(objTran, RequestPriority);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestPriorityData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestPriorityData.RollbackTransaction(objTran,true);
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

		public int SaveRows(RequestPriorityList RequestPriorityList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestPriorityList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestPriorityList RequestPriorityList)
		{
			return SaveRows(pTran, RequestPriorityList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestPriorityList RequestPriorityList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestPriorityData.CreateTransaction();
				}
				intRows = RequestPriorityData.SaveRows(objTran, RequestPriorityList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestPriorityData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestPriorityData.RollbackTransaction(objTran,true);
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

		public RequestPriorityList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public RequestPriorityList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			return RequestPriorityData.SelectRows(pTran, Id,name,nameAr);
		}

		#endregion

	}
}

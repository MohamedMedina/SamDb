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
	// The RequestTypeBusiness Class.
	[Serializable]
	public partial class RequestTypeBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private RequestTypeData RequestTypeData = new RequestTypeData();
	
		#region InsertRow

		public int InsertRow(RequestType RequestType)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RequestType,false);
		}

		public int InsertRow(DbTransaction pTran, RequestType RequestType)
		{
			return InsertRow(pTran, RequestType,false);
		}

		public int InsertRow(DbTransaction pTran, RequestType RequestType,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestTypeData.CreateTransaction();
				}
				intRow = RequestTypeData.InsertRow(objTran, RequestType);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestTypeData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestTypeData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(RequestType RequestType)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RequestType,false);
		}

		public int UpdateRow(DbTransaction pTran, RequestType RequestType)
		{
			return UpdateRow(pTran, RequestType,false);
		}

		public int UpdateRow(DbTransaction pTran, RequestType RequestType,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestTypeData.CreateTransaction();
				}
				intRow = RequestTypeData.UpdateRow(objTran, RequestType);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestTypeData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestTypeData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(RequestType RequestType)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RequestType,false);
		}

		public int DeleteRow(DbTransaction pTran, RequestType RequestType)
		{
			return DeleteRow(pTran, RequestType,false);
		}

		public int DeleteRow(DbTransaction pTran, RequestType RequestType,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestTypeData.CreateTransaction();
				}
				intRow = RequestTypeData.DeleteRow(objTran, RequestType);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestTypeData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestTypeData.RollbackTransaction(objTran,true);
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

		public int SaveRows(RequestTypeList RequestTypeList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestTypeList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestTypeList RequestTypeList)
		{
			return SaveRows(pTran, RequestTypeList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestTypeList RequestTypeList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestTypeData.CreateTransaction();
				}
				intRows = RequestTypeData.SaveRows(objTran, RequestTypeList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestTypeData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestTypeData.RollbackTransaction(objTran,true);
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

		public RequestTypeList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public RequestTypeList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			return RequestTypeData.SelectRows(pTran, Id,name,nameAr);
		}

		#endregion

	}
}

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
	// The RequestClassBusiness Class.
	[Serializable]
	public partial class RequestClassBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private RequestClassData RequestClassData = new RequestClassData();
	
		#region InsertRow

		public int InsertRow(RequestClass RequestClass)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RequestClass,false);
		}

		public int InsertRow(DbTransaction pTran, RequestClass RequestClass)
		{
			return InsertRow(pTran, RequestClass,false);
		}

		public int InsertRow(DbTransaction pTran, RequestClass RequestClass,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestClassData.CreateTransaction();
				}
				intRow = RequestClassData.InsertRow(objTran, RequestClass);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestClassData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestClassData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(RequestClass RequestClass)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RequestClass,false);
		}

		public int UpdateRow(DbTransaction pTran, RequestClass RequestClass)
		{
			return UpdateRow(pTran, RequestClass,false);
		}

		public int UpdateRow(DbTransaction pTran, RequestClass RequestClass,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestClassData.CreateTransaction();
				}
				intRow = RequestClassData.UpdateRow(objTran, RequestClass);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestClassData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestClassData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(RequestClass RequestClass)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RequestClass,false);
		}

		public int DeleteRow(DbTransaction pTran, RequestClass RequestClass)
		{
			return DeleteRow(pTran, RequestClass,false);
		}

		public int DeleteRow(DbTransaction pTran, RequestClass RequestClass,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestClassData.CreateTransaction();
				}
				intRow = RequestClassData.DeleteRow(objTran, RequestClass);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestClassData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestClassData.RollbackTransaction(objTran,true);
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

		public int SaveRows(RequestClassList RequestClassList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestClassList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestClassList RequestClassList)
		{
			return SaveRows(pTran, RequestClassList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestClassList RequestClassList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestClassData.CreateTransaction();
				}
				intRows = RequestClassData.SaveRows(objTran, RequestClassList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestClassData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestClassData.RollbackTransaction(objTran,true);
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

		public RequestClassList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public RequestClassList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			return RequestClassData.SelectRows(pTran, Id,name,nameAr);
		}

		#endregion

	}
}

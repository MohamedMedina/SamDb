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
	// The FunctionBusiness Class.
	[Serializable]
	public partial class FunctionBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private FunctionData FunctionData = new FunctionData();
	
		#region InsertRow

		public int InsertRow(Function Function)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, Function,false);
		}

		public int InsertRow(DbTransaction pTran, Function Function)
		{
			return InsertRow(pTran, Function,false);
		}

		public int InsertRow(DbTransaction pTran, Function Function,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = FunctionData.CreateTransaction();
				}
				intRow = FunctionData.InsertRow(objTran, Function);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					FunctionData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					FunctionData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(Function Function)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, Function,false);
		}

		public int UpdateRow(DbTransaction pTran, Function Function)
		{
			return UpdateRow(pTran, Function,false);
		}

		public int UpdateRow(DbTransaction pTran, Function Function,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = FunctionData.CreateTransaction();
				}
				intRow = FunctionData.UpdateRow(objTran, Function);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					FunctionData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					FunctionData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(Function Function)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, Function,false);
		}

		public int DeleteRow(DbTransaction pTran, Function Function)
		{
			return DeleteRow(pTran, Function,false);
		}

		public int DeleteRow(DbTransaction pTran, Function Function,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = FunctionData.CreateTransaction();
				}
				intRow = FunctionData.DeleteRow(objTran, Function);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					FunctionData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					FunctionData.RollbackTransaction(objTran,true);
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

		public int SaveRows(FunctionList FunctionList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, FunctionList,true);
		}

		public int SaveRows(DbTransaction pTran, FunctionList FunctionList)
		{
			return SaveRows(pTran, FunctionList,true);
		}

		public int SaveRows(DbTransaction pTran, FunctionList FunctionList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = FunctionData.CreateTransaction();
				}
				intRows = FunctionData.SaveRows(objTran, FunctionList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					FunctionData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					FunctionData.RollbackTransaction(objTran,true);
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

		public FunctionList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public FunctionList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			return FunctionData.SelectRows(pTran, Id,name,nameAr);
		}

		#endregion

	}
}

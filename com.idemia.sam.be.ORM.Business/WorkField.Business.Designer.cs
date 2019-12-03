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
	// The WorkFieldBusiness Class.
	[Serializable]
	public partial class WorkFieldBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private WorkFieldData WorkFieldData = new WorkFieldData();
	
		#region InsertRow

		public int InsertRow(WorkField WorkField)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, WorkField,false);
		}

		public int InsertRow(DbTransaction pTran, WorkField WorkField)
		{
			return InsertRow(pTran, WorkField,false);
		}

		public int InsertRow(DbTransaction pTran, WorkField WorkField,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = WorkFieldData.CreateTransaction();
				}
				intRow = WorkFieldData.InsertRow(objTran, WorkField);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					WorkFieldData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					WorkFieldData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(WorkField WorkField)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, WorkField,false);
		}

		public int UpdateRow(DbTransaction pTran, WorkField WorkField)
		{
			return UpdateRow(pTran, WorkField,false);
		}

		public int UpdateRow(DbTransaction pTran, WorkField WorkField,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = WorkFieldData.CreateTransaction();
				}
				intRow = WorkFieldData.UpdateRow(objTran, WorkField);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					WorkFieldData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					WorkFieldData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(WorkField WorkField)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, WorkField,false);
		}

		public int DeleteRow(DbTransaction pTran, WorkField WorkField)
		{
			return DeleteRow(pTran, WorkField,false);
		}

		public int DeleteRow(DbTransaction pTran, WorkField WorkField,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = WorkFieldData.CreateTransaction();
				}
				intRow = WorkFieldData.DeleteRow(objTran, WorkField);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					WorkFieldData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					WorkFieldData.RollbackTransaction(objTran,true);
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

		public int SaveRows(WorkFieldList WorkFieldList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, WorkFieldList,true);
		}

		public int SaveRows(DbTransaction pTran, WorkFieldList WorkFieldList)
		{
			return SaveRows(pTran, WorkFieldList,true);
		}

		public int SaveRows(DbTransaction pTran, WorkFieldList WorkFieldList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = WorkFieldData.CreateTransaction();
				}
				intRows = WorkFieldData.SaveRows(objTran, WorkFieldList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					WorkFieldData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					WorkFieldData.RollbackTransaction(objTran,true);
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

		public WorkFieldList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public WorkFieldList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			return WorkFieldData.SelectRows(pTran, Id,name,nameAr);
		}

		#endregion

	}
}

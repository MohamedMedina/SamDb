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
	// The RejectReasonBusiness Class.
	[Serializable]
	public partial class RejectReasonBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private RejectReasonData RejectReasonData = new RejectReasonData();
	
		#region InsertRow

		public int InsertRow(RejectReason RejectReason)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RejectReason,false);
		}

		public int InsertRow(DbTransaction pTran, RejectReason RejectReason)
		{
			return InsertRow(pTran, RejectReason,false);
		}

		public int InsertRow(DbTransaction pTran, RejectReason RejectReason,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RejectReasonData.CreateTransaction();
				}
				intRow = RejectReasonData.InsertRow(objTran, RejectReason);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RejectReasonData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RejectReasonData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(RejectReason RejectReason)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RejectReason,false);
		}

		public int UpdateRow(DbTransaction pTran, RejectReason RejectReason)
		{
			return UpdateRow(pTran, RejectReason,false);
		}

		public int UpdateRow(DbTransaction pTran, RejectReason RejectReason,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RejectReasonData.CreateTransaction();
				}
				intRow = RejectReasonData.UpdateRow(objTran, RejectReason);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RejectReasonData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RejectReasonData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(RejectReason RejectReason)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RejectReason,false);
		}

		public int DeleteRow(DbTransaction pTran, RejectReason RejectReason)
		{
			return DeleteRow(pTran, RejectReason,false);
		}

		public int DeleteRow(DbTransaction pTran, RejectReason RejectReason,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RejectReasonData.CreateTransaction();
				}
				intRow = RejectReasonData.DeleteRow(objTran, RejectReason);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RejectReasonData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RejectReasonData.RollbackTransaction(objTran,true);
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

		public int SaveRows(RejectReasonList RejectReasonList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RejectReasonList,true);
		}

		public int SaveRows(DbTransaction pTran, RejectReasonList RejectReasonList)
		{
			return SaveRows(pTran, RejectReasonList,true);
		}

		public int SaveRows(DbTransaction pTran, RejectReasonList RejectReasonList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RejectReasonData.CreateTransaction();
				}
				intRows = RejectReasonData.SaveRows(objTran, RejectReasonList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RejectReasonData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RejectReasonData.RollbackTransaction(objTran,true);
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

		public RejectReasonList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public RejectReasonList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			return RejectReasonData.SelectRows(pTran, Id,name,nameAr);
		}

		#endregion

	}
}

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
	// The GroupFunctionBusiness Class.
	[Serializable]
	public partial class GroupFunctionBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private GroupFunctionData GroupFunctionData = new GroupFunctionData();
	
		#region InsertRow

		public int InsertRow(GroupFunction GroupFunction)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, GroupFunction,false);
		}

		public int InsertRow(DbTransaction pTran, GroupFunction GroupFunction)
		{
			return InsertRow(pTran, GroupFunction,false);
		}

		public int InsertRow(DbTransaction pTran, GroupFunction GroupFunction,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = GroupFunctionData.CreateTransaction();
				}
				intRow = GroupFunctionData.InsertRow(objTran, GroupFunction);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupFunctionData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupFunctionData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(GroupFunction GroupFunction)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, GroupFunction,false);
		}

		public int UpdateRow(DbTransaction pTran, GroupFunction GroupFunction)
		{
			return UpdateRow(pTran, GroupFunction,false);
		}

		public int UpdateRow(DbTransaction pTran, GroupFunction GroupFunction,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = GroupFunctionData.CreateTransaction();
				}
				intRow = GroupFunctionData.UpdateRow(objTran, GroupFunction);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupFunctionData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupFunctionData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(GroupFunction GroupFunction)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, GroupFunction,false);
		}

		public int DeleteRow(DbTransaction pTran, GroupFunction GroupFunction)
		{
			return DeleteRow(pTran, GroupFunction,false);
		}

		public int DeleteRow(DbTransaction pTran, GroupFunction GroupFunction,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = GroupFunctionData.CreateTransaction();
				}
				intRow = GroupFunctionData.DeleteRow(objTran, GroupFunction);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupFunctionData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupFunctionData.RollbackTransaction(objTran,true);
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

		public int SaveRows(GroupFunctionList GroupFunctionList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, GroupFunctionList,true);
		}

		public int SaveRows(DbTransaction pTran, GroupFunctionList GroupFunctionList)
		{
			return SaveRows(pTran, GroupFunctionList,true);
		}

		public int SaveRows(DbTransaction pTran, GroupFunctionList GroupFunctionList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = GroupFunctionData.CreateTransaction();
				}
				intRows = GroupFunctionData.SaveRows(objTran, GroupFunctionList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupFunctionData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupFunctionData.RollbackTransaction(objTran,true);
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

		public GroupFunctionList SelectRows(System.Int32? Id,System.Int32? functionId,System.Int32? groupId)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,functionId,groupId);
		}

		public GroupFunctionList SelectRows(DbTransaction pTran,System.Int32? Id,System.Int32? functionId,System.Int32? groupId)
		{
			return GroupFunctionData.SelectRows(pTran, Id,functionId,groupId);
		}

		#endregion

	}
}

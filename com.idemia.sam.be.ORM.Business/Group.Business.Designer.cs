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
	// The GroupBusiness Class.
	[Serializable]
	public partial class GroupBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private GroupData GroupData = new GroupData();
	
		#region InsertRow

		public int InsertRow(Group Group)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, Group,false);
		}

		public int InsertRow(DbTransaction pTran, Group Group)
		{
			return InsertRow(pTran, Group,false);
		}

		public int InsertRow(DbTransaction pTran, Group Group,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = GroupData.CreateTransaction();
				}
				intRow = GroupData.InsertRow(objTran, Group);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(Group Group)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, Group,false);
		}

		public int UpdateRow(DbTransaction pTran, Group Group)
		{
			return UpdateRow(pTran, Group,false);
		}

		public int UpdateRow(DbTransaction pTran, Group Group,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = GroupData.CreateTransaction();
				}
				intRow = GroupData.UpdateRow(objTran, Group);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(Group Group)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, Group,false);
		}

		public int DeleteRow(DbTransaction pTran, Group Group)
		{
			return DeleteRow(pTran, Group,false);
		}

		public int DeleteRow(DbTransaction pTran, Group Group,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = GroupData.CreateTransaction();
				}
				intRow = GroupData.DeleteRow(objTran, Group);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupData.RollbackTransaction(objTran,true);
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

		public int SaveRows(GroupList GroupList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, GroupList,true);
		}

		public int SaveRows(DbTransaction pTran, GroupList GroupList)
		{
			return SaveRows(pTran, GroupList,true);
		}

		public int SaveRows(DbTransaction pTran, GroupList GroupList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = GroupData.CreateTransaction();
				}
				intRows = GroupData.SaveRows(objTran, GroupList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					GroupData.RollbackTransaction(objTran,true);
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

		public GroupList SelectRows(System.Int32? Id,System.String name)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name);
		}

		public GroupList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name)
		{
			return GroupData.SelectRows(pTran, Id,name);
		}

		#endregion

	}
}

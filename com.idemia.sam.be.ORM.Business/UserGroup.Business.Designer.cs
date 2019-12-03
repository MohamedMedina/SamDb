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
	// The UserGroupBusiness Class.
	[Serializable]
	public partial class UserGroupBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private UserGroupData UserGroupData = new UserGroupData();
	
		#region InsertRow

		public int InsertRow(UserGroup UserGroup)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, UserGroup,false);
		}

		public int InsertRow(DbTransaction pTran, UserGroup UserGroup)
		{
			return InsertRow(pTran, UserGroup,false);
		}

		public int InsertRow(DbTransaction pTran, UserGroup UserGroup,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = UserGroupData.CreateTransaction();
				}
				intRow = UserGroupData.InsertRow(objTran, UserGroup);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserGroupData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserGroupData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(UserGroup UserGroup)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, UserGroup,false);
		}

		public int UpdateRow(DbTransaction pTran, UserGroup UserGroup)
		{
			return UpdateRow(pTran, UserGroup,false);
		}

		public int UpdateRow(DbTransaction pTran, UserGroup UserGroup,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = UserGroupData.CreateTransaction();
				}
				intRow = UserGroupData.UpdateRow(objTran, UserGroup);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserGroupData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserGroupData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(UserGroup UserGroup)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, UserGroup,false);
		}

		public int DeleteRow(DbTransaction pTran, UserGroup UserGroup)
		{
			return DeleteRow(pTran, UserGroup,false);
		}

		public int DeleteRow(DbTransaction pTran, UserGroup UserGroup,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = UserGroupData.CreateTransaction();
				}
				intRow = UserGroupData.DeleteRow(objTran, UserGroup);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserGroupData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserGroupData.RollbackTransaction(objTran,true);
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

		public int SaveRows(UserGroupList UserGroupList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, UserGroupList,true);
		}

		public int SaveRows(DbTransaction pTran, UserGroupList UserGroupList)
		{
			return SaveRows(pTran, UserGroupList,true);
		}

		public int SaveRows(DbTransaction pTran, UserGroupList UserGroupList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = UserGroupData.CreateTransaction();
				}
				intRows = UserGroupData.SaveRows(objTran, UserGroupList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserGroupData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserGroupData.RollbackTransaction(objTran,true);
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

		public UserGroupList SelectRows(System.Int32? Id,System.Int32? userId,System.Int32? groupId)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,userId,groupId);
		}

		public UserGroupList SelectRows(DbTransaction pTran,System.Int32? Id,System.Int32? userId,System.Int32? groupId)
		{
			return UserGroupData.SelectRows(pTran, Id,userId,groupId);
		}

		#endregion

	}
}

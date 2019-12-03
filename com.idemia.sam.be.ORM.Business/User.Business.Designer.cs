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
	// The UserBusiness Class.
	[Serializable]
	public partial class UserBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private UserData UserData = new UserData();
	
		#region InsertRow

		public int InsertRow(User User)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, User,false);
		}

		public int InsertRow(DbTransaction pTran, User User)
		{
			return InsertRow(pTran, User,false);
		}

		public int InsertRow(DbTransaction pTran, User User,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = UserData.CreateTransaction();
				}
				intRow = UserData.InsertRow(objTran, User);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(User User)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, User,false);
		}

		public int UpdateRow(DbTransaction pTran, User User)
		{
			return UpdateRow(pTran, User,false);
		}

		public int UpdateRow(DbTransaction pTran, User User,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = UserData.CreateTransaction();
				}
				intRow = UserData.UpdateRow(objTran, User);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(User User)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, User,false);
		}

		public int DeleteRow(DbTransaction pTran, User User)
		{
			return DeleteRow(pTran, User,false);
		}

		public int DeleteRow(DbTransaction pTran, User User,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = UserData.CreateTransaction();
				}
				intRow = UserData.DeleteRow(objTran, User);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserData.RollbackTransaction(objTran,true);
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

		public int SaveRows(UserList UserList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, UserList,true);
		}

		public int SaveRows(DbTransaction pTran, UserList UserList)
		{
			return SaveRows(pTran, UserList,true);
		}

		public int SaveRows(DbTransaction pTran, UserList UserList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = UserData.CreateTransaction();
				}
				intRows = UserData.SaveRows(objTran, UserList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					UserData.RollbackTransaction(objTran,true);
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

		public UserList SelectRows(System.Int32? Id,System.String userName,System.String fullName,System.DateTime? createDate)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,userName,fullName,createDate);
		}

		public UserList SelectRows(DbTransaction pTran,System.Int32? Id,System.String userName,System.String fullName,System.DateTime? createDate)
		{
			return UserData.SelectRows(pTran, Id,userName,fullName,createDate);
		}

		#endregion

	}
}

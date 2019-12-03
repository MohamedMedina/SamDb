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

namespace DataAccess
{
	// Summary:
	// The UserData Class.
	[Serializable]
	public partial class UserData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(User User)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, User);
		}

		public int InsertRow(DbTransaction pTran,User User)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[6];
			Parameters[0] = _getIdParameter(User.Id, ParameterDirection.Output);
			Parameters[1] = _getuserNameParameter(User.userName, ParameterDirection.Input);
			Parameters[2] = _getfullNameParameter(User.fullName, ParameterDirection.Input);
			Parameters[3] = _getPasswordParameter(User.Password, ParameterDirection.Input);
			Parameters[4] = _getstatusParameter(User.status, ParameterDirection.Input);
			Parameters[5] = _getcreateDateParameter(User.createDate, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[InsertUser]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				User.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(User User)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, User);
		}

		public int UpdateRow(DbTransaction pTran,User User)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[6];
			Parameters[0] = _getIdParameter(User.Id, ParameterDirection.Input);
			Parameters[1] = _getuserNameParameter(User.userName, ParameterDirection.Input);
			Parameters[2] = _getfullNameParameter(User.fullName, ParameterDirection.Input);
			Parameters[3] = _getPasswordParameter(User.Password, ParameterDirection.Input);
			Parameters[4] = _getstatusParameter(User.status, ParameterDirection.Input);
			Parameters[5] = _getcreateDateParameter(User.createDate, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[UpdateUser]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(User User)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, User);
		}

		public int DeleteRow(DbTransaction pTran,User User)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(User.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[DeleteUser]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(UserList UserList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, UserList);
		}

		public int SaveRows(DbTransaction pTran,UserList UserList)
		{
			int intRows = 0;

			for (int i = 0; i < UserList.Count; i++)
			{
				switch (UserList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, UserList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, UserList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, UserList[i]);
						break;
				}
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
			UserList UserList = new UserList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[4];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getuserNameParameter(userName, ParameterDirection.Input);
			Parameters[2] = _getfullNameParameter(fullName, ParameterDirection.Input);
			Parameters[3] = _getcreateDateParameter(createDate, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Lookups].[SelectUser]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						User User = new User();
						if (Dr["Id"] != DBNull.Value) User.Id = (System.Int32)Dr["Id"];
						if (Dr["userName"] != DBNull.Value) User.userName = (System.String)Dr["userName"];
						if (Dr["fullName"] != DBNull.Value) User.fullName = (System.String)Dr["fullName"];
						if (Dr["Password"] != DBNull.Value) User.Password = (System.String)Dr["Password"];
						if (Dr["status"] != DBNull.Value) User.status = (System.Boolean?)Dr["status"];
						if (Dr["createDate"] != DBNull.Value) User.createDate = (System.DateTime?)Dr["createDate"];
						UserList.FillRow(User);
						User = null;
					}
				}
			}
			catch (Exception Ex)
			{
				exception = Ex;
			}
			finally
			{
				if (Dr != null)
				{
					if(Dr.IsClosed==false)Dr.Close();
					Dr = null;
				}
			}
			return UserList;
		}

		#endregion

		#region Parameters
		#region _getIdParameter
		/// <summary>
		/// Methods _getIdParameter Represent Parameter Id in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getIdParameter(System.Int32? Id,ParameterDirection pParameterDirection)
		{
			return CreateParameter("Id",Id,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getuserNameParameter
		/// <summary>
		/// Methods _getuserNameParameter Represent Parameter userName in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getuserNameParameter(System.String userName,ParameterDirection pParameterDirection)
		{
			return CreateParameter("userName",userName,DbType.String,pParameterDirection,60);
		}
		#endregion
	
		#region _getfullNameParameter
		/// <summary>
		/// Methods _getfullNameParameter Represent Parameter fullName in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getfullNameParameter(System.String fullName,ParameterDirection pParameterDirection)
		{
			return CreateParameter("fullName",fullName,DbType.String,pParameterDirection,100);
		}
		#endregion
	
		#region _getPasswordParameter
		/// <summary>
		/// Methods _getPasswordParameter Represent Parameter Password in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getPasswordParameter(System.String Password,ParameterDirection pParameterDirection)
		{
			return CreateParameter("Password",Password,DbType.String,pParameterDirection,60);
		}
		#endregion
	
		#region _getstatusParameter
		/// <summary>
		/// Methods _getstatusParameter Represent Parameter status in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getstatusParameter(System.Boolean? status,ParameterDirection pParameterDirection)
		{
			return CreateParameter("status",status,DbType.Boolean,pParameterDirection,1);
		}
		#endregion
	
		#region _getcreateDateParameter
		/// <summary>
		/// Methods _getcreateDateParameter Represent Parameter createDate in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getcreateDateParameter(System.DateTime? createDate,ParameterDirection pParameterDirection)
		{
			return CreateParameter("createDate",createDate,DbType.DateTime,pParameterDirection,23,3);
		}
		#endregion
	
		#endregion

	}
}

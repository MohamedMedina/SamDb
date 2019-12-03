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
	// The UserGroupData Class.
	[Serializable]
	public partial class UserGroupData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(UserGroup UserGroup)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, UserGroup);
		}

		public int InsertRow(DbTransaction pTran,UserGroup UserGroup)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(UserGroup.Id, ParameterDirection.Output);
			Parameters[1] = _getuserIdParameter(UserGroup.userId, ParameterDirection.Input);
			Parameters[2] = _getgroupIdParameter(UserGroup.groupId, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[InsertUserGroup]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				UserGroup.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(UserGroup UserGroup)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, UserGroup);
		}

		public int UpdateRow(DbTransaction pTran,UserGroup UserGroup)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(UserGroup.Id, ParameterDirection.Input);
			Parameters[1] = _getuserIdParameter(UserGroup.userId, ParameterDirection.Input);
			Parameters[2] = _getgroupIdParameter(UserGroup.groupId, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[UpdateUserGroup]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(UserGroup UserGroup)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, UserGroup);
		}

		public int DeleteRow(DbTransaction pTran,UserGroup UserGroup)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(UserGroup.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[DeleteUserGroup]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(UserGroupList UserGroupList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, UserGroupList);
		}

		public int SaveRows(DbTransaction pTran,UserGroupList UserGroupList)
		{
			int intRows = 0;

			for (int i = 0; i < UserGroupList.Count; i++)
			{
				switch (UserGroupList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, UserGroupList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, UserGroupList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, UserGroupList[i]);
						break;
				}
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
			UserGroupList UserGroupList = new UserGroupList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getuserIdParameter(userId, ParameterDirection.Input);
			Parameters[2] = _getgroupIdParameter(groupId, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Lookups].[SelectUserGroup]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						UserGroup UserGroup = new UserGroup();
						if (Dr["Id"] != DBNull.Value) UserGroup.Id = (System.Int32)Dr["Id"];
						if (Dr["userId"] != DBNull.Value) UserGroup.userId = (System.Int32)Dr["userId"];
						if (Dr["groupId"] != DBNull.Value) UserGroup.groupId = (System.Int32)Dr["groupId"];
						UserGroupList.FillRow(UserGroup);
						UserGroup = null;
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
			return UserGroupList;
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
	
		#region _getuserIdParameter
		/// <summary>
		/// Methods _getuserIdParameter Represent Parameter userId in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getuserIdParameter(System.Int32? userId,ParameterDirection pParameterDirection)
		{
			return CreateParameter("userId",userId,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getgroupIdParameter
		/// <summary>
		/// Methods _getgroupIdParameter Represent Parameter groupId in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getgroupIdParameter(System.Int32? groupId,ParameterDirection pParameterDirection)
		{
			return CreateParameter("groupId",groupId,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#endregion

	}
}

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
	// The GroupFunctionData Class.
	[Serializable]
	public partial class GroupFunctionData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(GroupFunction GroupFunction)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, GroupFunction);
		}

		public int InsertRow(DbTransaction pTran,GroupFunction GroupFunction)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[4];
			Parameters[0] = _getIdParameter(GroupFunction.Id, ParameterDirection.Output);
			Parameters[1] = _getfunctionIdParameter(GroupFunction.functionId, ParameterDirection.Input);
			Parameters[2] = _getgroupIdParameter(GroupFunction.groupId, ParameterDirection.Input);
			Parameters[3] = _getstatusParameter(GroupFunction.status, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[InsertGroupFunction]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				GroupFunction.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(GroupFunction GroupFunction)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, GroupFunction);
		}

		public int UpdateRow(DbTransaction pTran,GroupFunction GroupFunction)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[4];
			Parameters[0] = _getIdParameter(GroupFunction.Id, ParameterDirection.Input);
			Parameters[1] = _getfunctionIdParameter(GroupFunction.functionId, ParameterDirection.Input);
			Parameters[2] = _getgroupIdParameter(GroupFunction.groupId, ParameterDirection.Input);
			Parameters[3] = _getstatusParameter(GroupFunction.status, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[UpdateGroupFunction]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(GroupFunction GroupFunction)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, GroupFunction);
		}

		public int DeleteRow(DbTransaction pTran,GroupFunction GroupFunction)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(GroupFunction.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[DeleteGroupFunction]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(GroupFunctionList GroupFunctionList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, GroupFunctionList);
		}

		public int SaveRows(DbTransaction pTran,GroupFunctionList GroupFunctionList)
		{
			int intRows = 0;

			for (int i = 0; i < GroupFunctionList.Count; i++)
			{
				switch (GroupFunctionList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, GroupFunctionList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, GroupFunctionList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, GroupFunctionList[i]);
						break;
				}
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
			GroupFunctionList GroupFunctionList = new GroupFunctionList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getfunctionIdParameter(functionId, ParameterDirection.Input);
			Parameters[2] = _getgroupIdParameter(groupId, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Lookups].[SelectGroupFunction]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						GroupFunction GroupFunction = new GroupFunction();
						if (Dr["Id"] != DBNull.Value) GroupFunction.Id = (System.Int32)Dr["Id"];
						if (Dr["functionId"] != DBNull.Value) GroupFunction.functionId = (System.Int32?)Dr["functionId"];
						if (Dr["groupId"] != DBNull.Value) GroupFunction.groupId = (System.Int32?)Dr["groupId"];
						if (Dr["status"] != DBNull.Value) GroupFunction.status = (System.Boolean?)Dr["status"];
						GroupFunctionList.FillRow(GroupFunction);
						GroupFunction = null;
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
			return GroupFunctionList;
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
	
		#region _getfunctionIdParameter
		/// <summary>
		/// Methods _getfunctionIdParameter Represent Parameter functionId in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getfunctionIdParameter(System.Int32? functionId,ParameterDirection pParameterDirection)
		{
			return CreateParameter("functionId",functionId,DbType.Int32,pParameterDirection,4);
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
	
		#endregion

	}
}

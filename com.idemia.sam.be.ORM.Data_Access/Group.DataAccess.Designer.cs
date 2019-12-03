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
	// The GroupData Class.
	[Serializable]
	public partial class GroupData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(Group Group)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, Group);
		}

		public int InsertRow(DbTransaction pTran,Group Group)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Group.Id, ParameterDirection.Output);
			Parameters[1] = _getnameParameter(Group.name, ParameterDirection.Input);
			Parameters[2] = _getstatusParameter(Group.status, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[InsertGroup]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				Group.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(Group Group)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, Group);
		}

		public int UpdateRow(DbTransaction pTran,Group Group)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Group.Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(Group.name, ParameterDirection.Input);
			Parameters[2] = _getstatusParameter(Group.status, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[UpdateGroup]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(Group Group)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, Group);
		}

		public int DeleteRow(DbTransaction pTran,Group Group)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(Group.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[DeleteGroup]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(GroupList GroupList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, GroupList);
		}

		public int SaveRows(DbTransaction pTran,GroupList GroupList)
		{
			int intRows = 0;

			for (int i = 0; i < GroupList.Count; i++)
			{
				switch (GroupList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, GroupList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, GroupList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, GroupList[i]);
						break;
				}
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
			GroupList GroupList = new GroupList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[2];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(name, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Lookups].[SelectGroup]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						Group Group = new Group();
						if (Dr["Id"] != DBNull.Value) Group.Id = (System.Int32)Dr["Id"];
						if (Dr["name"] != DBNull.Value) Group.name = (System.String)Dr["name"];
						if (Dr["status"] != DBNull.Value) Group.status = (System.Boolean?)Dr["status"];
						GroupList.FillRow(Group);
						Group = null;
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
			return GroupList;
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
	
		#region _getnameParameter
		/// <summary>
		/// Methods _getnameParameter Represent Parameter name in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getnameParameter(System.String name,ParameterDirection pParameterDirection)
		{
			return CreateParameter("name",name,DbType.String,pParameterDirection,100);
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

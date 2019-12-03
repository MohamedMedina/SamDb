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
	// The FunctionData Class.
	[Serializable]
	public partial class FunctionData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(Function Function)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, Function);
		}

		public int InsertRow(DbTransaction pTran,Function Function)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[5];
			Parameters[0] = _getIdParameter(Function.Id, ParameterDirection.Output);
			Parameters[1] = _getnameParameter(Function.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(Function.nameAr, ParameterDirection.Input);
			Parameters[3] = _getrouteParameter(Function.route, ParameterDirection.Input);
			Parameters[4] = _getstatusParameter(Function.status, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[InsertFunction]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				Function.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(Function Function)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, Function);
		}

		public int UpdateRow(DbTransaction pTran,Function Function)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[5];
			Parameters[0] = _getIdParameter(Function.Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(Function.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(Function.nameAr, ParameterDirection.Input);
			Parameters[3] = _getrouteParameter(Function.route, ParameterDirection.Input);
			Parameters[4] = _getstatusParameter(Function.status, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[UpdateFunction]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(Function Function)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, Function);
		}

		public int DeleteRow(DbTransaction pTran,Function Function)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(Function.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[DeleteFunction]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(FunctionList FunctionList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, FunctionList);
		}

		public int SaveRows(DbTransaction pTran,FunctionList FunctionList)
		{
			int intRows = 0;

			for (int i = 0; i < FunctionList.Count; i++)
			{
				switch (FunctionList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, FunctionList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, FunctionList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, FunctionList[i]);
						break;
				}
			}

			return intRows;
		}

		#endregion

		#region SelectRows

		public FunctionList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public FunctionList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			FunctionList FunctionList = new FunctionList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(nameAr, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Lookups].[SelectFunction]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						Function Function = new Function();
						if (Dr["Id"] != DBNull.Value) Function.Id = (System.Int32)Dr["Id"];
						if (Dr["name"] != DBNull.Value) Function.name = (System.String)Dr["name"];
						if (Dr["nameAr"] != DBNull.Value) Function.nameAr = (System.String)Dr["nameAr"];
						if (Dr["route"] != DBNull.Value) Function.route = (System.String)Dr["route"];
						if (Dr["status"] != DBNull.Value) Function.status = (System.Boolean?)Dr["status"];
						FunctionList.FillRow(Function);
						Function = null;
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
			return FunctionList;
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
			return CreateParameter("name",name,DbType.String,pParameterDirection,60);
		}
		#endregion
	
		#region _getnameArParameter
		/// <summary>
		/// Methods _getnameArParameter Represent Parameter nameAr in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getnameArParameter(System.String nameAr,ParameterDirection pParameterDirection)
		{
			return CreateParameter("nameAr",nameAr,DbType.String,pParameterDirection,60);
		}
		#endregion
	
		#region _getrouteParameter
		/// <summary>
		/// Methods _getrouteParameter Represent Parameter route in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getrouteParameter(System.String route,ParameterDirection pParameterDirection)
		{
			return CreateParameter("route",route,DbType.String,pParameterDirection);
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

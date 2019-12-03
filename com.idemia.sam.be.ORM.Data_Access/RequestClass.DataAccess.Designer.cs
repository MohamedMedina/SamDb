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
	// The RequestClassData Class.
	[Serializable]
	public partial class RequestClassData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(RequestClass RequestClass)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RequestClass);
		}

		public int InsertRow(DbTransaction pTran,RequestClass RequestClass)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(RequestClass.Id, ParameterDirection.Output);
			Parameters[1] = _getnameParameter(RequestClass.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(RequestClass.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[InsertRequestClass]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				RequestClass.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(RequestClass RequestClass)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RequestClass);
		}

		public int UpdateRow(DbTransaction pTran,RequestClass RequestClass)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(RequestClass.Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(RequestClass.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(RequestClass.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[UpdateRequestClass]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(RequestClass RequestClass)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RequestClass);
		}

		public int DeleteRow(DbTransaction pTran,RequestClass RequestClass)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(RequestClass.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[DeleteRequestClass]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(RequestClassList RequestClassList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestClassList);
		}

		public int SaveRows(DbTransaction pTran,RequestClassList RequestClassList)
		{
			int intRows = 0;

			for (int i = 0; i < RequestClassList.Count; i++)
			{
				switch (RequestClassList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, RequestClassList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, RequestClassList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, RequestClassList[i]);
						break;
				}
			}

			return intRows;
		}

		#endregion

		#region SelectRows

		public RequestClassList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public RequestClassList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			RequestClassList RequestClassList = new RequestClassList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(nameAr, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Lookups].[SelectRequestClass]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						RequestClass RequestClass = new RequestClass();
						if (Dr["Id"] != DBNull.Value) RequestClass.Id = (System.Int32)Dr["Id"];
						if (Dr["name"] != DBNull.Value) RequestClass.name = (System.String)Dr["name"];
						if (Dr["nameAr"] != DBNull.Value) RequestClass.nameAr = (System.String)Dr["nameAr"];
						RequestClassList.FillRow(RequestClass);
						RequestClass = null;
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
			return RequestClassList;
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
	
		#endregion

	}
}

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
	// The RequestTypeData Class.
	[Serializable]
	public partial class RequestTypeData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(RequestType RequestType)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RequestType);
		}

		public int InsertRow(DbTransaction pTran,RequestType RequestType)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(RequestType.Id, ParameterDirection.Output);
			Parameters[1] = _getnameParameter(RequestType.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(RequestType.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[InsertRequestType]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				RequestType.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(RequestType RequestType)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RequestType);
		}

		public int UpdateRow(DbTransaction pTran,RequestType RequestType)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(RequestType.Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(RequestType.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(RequestType.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[UpdateRequestType]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(RequestType RequestType)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RequestType);
		}

		public int DeleteRow(DbTransaction pTran,RequestType RequestType)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(RequestType.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[DeleteRequestType]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(RequestTypeList RequestTypeList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestTypeList);
		}

		public int SaveRows(DbTransaction pTran,RequestTypeList RequestTypeList)
		{
			int intRows = 0;

			for (int i = 0; i < RequestTypeList.Count; i++)
			{
				switch (RequestTypeList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, RequestTypeList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, RequestTypeList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, RequestTypeList[i]);
						break;
				}
			}

			return intRows;
		}

		#endregion

		#region SelectRows

		public RequestTypeList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public RequestTypeList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			RequestTypeList RequestTypeList = new RequestTypeList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(nameAr, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Lookups].[SelectRequestType]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						RequestType RequestType = new RequestType();
						if (Dr["Id"] != DBNull.Value) RequestType.Id = (System.Int32)Dr["Id"];
						if (Dr["name"] != DBNull.Value) RequestType.name = (System.String)Dr["name"];
						if (Dr["nameAr"] != DBNull.Value) RequestType.nameAr = (System.String)Dr["nameAr"];
						RequestTypeList.FillRow(RequestType);
						RequestType = null;
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
			return RequestTypeList;
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

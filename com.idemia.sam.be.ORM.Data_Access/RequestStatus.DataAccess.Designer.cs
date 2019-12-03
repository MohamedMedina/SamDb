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
	// The RequestStatusData Class.
	[Serializable]
	public partial class RequestStatusData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(RequestStatus RequestStatus)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RequestStatus);
		}

		public int InsertRow(DbTransaction pTran,RequestStatus RequestStatus)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(RequestStatus.Id, ParameterDirection.Output);
			Parameters[1] = _getnameParameter(RequestStatus.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(RequestStatus.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[InsertRequestStatus]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				RequestStatus.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(RequestStatus RequestStatus)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RequestStatus);
		}

		public int UpdateRow(DbTransaction pTran,RequestStatus RequestStatus)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(RequestStatus.Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(RequestStatus.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(RequestStatus.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[UpdateRequestStatus]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(RequestStatus RequestStatus)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RequestStatus);
		}

		public int DeleteRow(DbTransaction pTran,RequestStatus RequestStatus)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(RequestStatus.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[DeleteRequestStatus]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(RequestStatusList RequestStatusList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestStatusList);
		}

		public int SaveRows(DbTransaction pTran,RequestStatusList RequestStatusList)
		{
			int intRows = 0;

			for (int i = 0; i < RequestStatusList.Count; i++)
			{
				switch (RequestStatusList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, RequestStatusList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, RequestStatusList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, RequestStatusList[i]);
						break;
				}
			}

			return intRows;
		}

		#endregion

		#region SelectRows

		public RequestStatusList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public RequestStatusList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			RequestStatusList RequestStatusList = new RequestStatusList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(nameAr, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Lookups].[SelectRequestStatus]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						RequestStatus RequestStatus = new RequestStatus();
						if (Dr["Id"] != DBNull.Value) RequestStatus.Id = (System.Int32)Dr["Id"];
						if (Dr["name"] != DBNull.Value) RequestStatus.name = (System.String)Dr["name"];
						if (Dr["nameAr"] != DBNull.Value) RequestStatus.nameAr = (System.String)Dr["nameAr"];
						RequestStatusList.FillRow(RequestStatus);
						RequestStatus = null;
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
			return RequestStatusList;
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

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
	// The RequestPriorityData Class.
	[Serializable]
	public partial class RequestPriorityData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(RequestPriority RequestPriority)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RequestPriority);
		}

		public int InsertRow(DbTransaction pTran,RequestPriority RequestPriority)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(RequestPriority.Id, ParameterDirection.Output);
			Parameters[1] = _getnameParameter(RequestPriority.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(RequestPriority.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[InsertRequestPriority]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				RequestPriority.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(RequestPriority RequestPriority)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RequestPriority);
		}

		public int UpdateRow(DbTransaction pTran,RequestPriority RequestPriority)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(RequestPriority.Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(RequestPriority.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(RequestPriority.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[UpdateRequestPriority]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(RequestPriority RequestPriority)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RequestPriority);
		}

		public int DeleteRow(DbTransaction pTran,RequestPriority RequestPriority)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(RequestPriority.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[DeleteRequestPriority]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(RequestPriorityList RequestPriorityList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestPriorityList);
		}

		public int SaveRows(DbTransaction pTran,RequestPriorityList RequestPriorityList)
		{
			int intRows = 0;

			for (int i = 0; i < RequestPriorityList.Count; i++)
			{
				switch (RequestPriorityList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, RequestPriorityList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, RequestPriorityList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, RequestPriorityList[i]);
						break;
				}
			}

			return intRows;
		}

		#endregion

		#region SelectRows

		public RequestPriorityList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public RequestPriorityList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			RequestPriorityList RequestPriorityList = new RequestPriorityList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(nameAr, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Lookups].[SelectRequestPriority]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						RequestPriority RequestPriority = new RequestPriority();
						if (Dr["Id"] != DBNull.Value) RequestPriority.Id = (System.Int32)Dr["Id"];
						if (Dr["name"] != DBNull.Value) RequestPriority.name = (System.String)Dr["name"];
						if (Dr["nameAr"] != DBNull.Value) RequestPriority.nameAr = (System.String)Dr["nameAr"];
						RequestPriorityList.FillRow(RequestPriority);
						RequestPriority = null;
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
			return RequestPriorityList;
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

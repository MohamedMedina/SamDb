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
	// The RejectReasonData Class.
	[Serializable]
	public partial class RejectReasonData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(RejectReason RejectReason)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RejectReason);
		}

		public int InsertRow(DbTransaction pTran,RejectReason RejectReason)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(RejectReason.Id, ParameterDirection.Output);
			Parameters[1] = _getnameParameter(RejectReason.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(RejectReason.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[InsertRejectReason]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				RejectReason.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(RejectReason RejectReason)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RejectReason);
		}

		public int UpdateRow(DbTransaction pTran,RejectReason RejectReason)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(RejectReason.Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(RejectReason.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(RejectReason.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[UpdateRejectReason]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(RejectReason RejectReason)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RejectReason);
		}

		public int DeleteRow(DbTransaction pTran,RejectReason RejectReason)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(RejectReason.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[DeleteRejectReason]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(RejectReasonList RejectReasonList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RejectReasonList);
		}

		public int SaveRows(DbTransaction pTran,RejectReasonList RejectReasonList)
		{
			int intRows = 0;

			for (int i = 0; i < RejectReasonList.Count; i++)
			{
				switch (RejectReasonList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, RejectReasonList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, RejectReasonList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, RejectReasonList[i]);
						break;
				}
			}

			return intRows;
		}

		#endregion

		#region SelectRows

		public RejectReasonList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public RejectReasonList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			RejectReasonList RejectReasonList = new RejectReasonList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(nameAr, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Lookups].[SelectRejectReason]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						RejectReason RejectReason = new RejectReason();
						if (Dr["Id"] != DBNull.Value) RejectReason.Id = (System.Int32)Dr["Id"];
						if (Dr["name"] != DBNull.Value) RejectReason.name = (System.String)Dr["name"];
						if (Dr["nameAr"] != DBNull.Value) RejectReason.nameAr = (System.String)Dr["nameAr"];
						RejectReasonList.FillRow(RejectReason);
						RejectReason = null;
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
			return RejectReasonList;
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

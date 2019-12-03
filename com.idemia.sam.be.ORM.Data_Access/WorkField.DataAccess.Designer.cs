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
	// The WorkFieldData Class.
	[Serializable]
	public partial class WorkFieldData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(WorkField WorkField)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, WorkField);
		}

		public int InsertRow(DbTransaction pTran,WorkField WorkField)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(WorkField.Id, ParameterDirection.Output);
			Parameters[1] = _getnameParameter(WorkField.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(WorkField.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[InsertWorkField]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				WorkField.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(WorkField WorkField)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, WorkField);
		}

		public int UpdateRow(DbTransaction pTran,WorkField WorkField)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(WorkField.Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(WorkField.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(WorkField.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[UpdateWorkField]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(WorkField WorkField)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, WorkField);
		}

		public int DeleteRow(DbTransaction pTran,WorkField WorkField)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(WorkField.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[DeleteWorkField]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(WorkFieldList WorkFieldList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, WorkFieldList);
		}

		public int SaveRows(DbTransaction pTran,WorkFieldList WorkFieldList)
		{
			int intRows = 0;

			for (int i = 0; i < WorkFieldList.Count; i++)
			{
				switch (WorkFieldList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, WorkFieldList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, WorkFieldList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, WorkFieldList[i]);
						break;
				}
			}

			return intRows;
		}

		#endregion

		#region SelectRows

		public WorkFieldList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public WorkFieldList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			WorkFieldList WorkFieldList = new WorkFieldList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(nameAr, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Lookups].[SelectWorkField]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						WorkField WorkField = new WorkField();
						if (Dr["Id"] != DBNull.Value) WorkField.Id = (System.Int32)Dr["Id"];
						if (Dr["name"] != DBNull.Value) WorkField.name = (System.String)Dr["name"];
						if (Dr["nameAr"] != DBNull.Value) WorkField.nameAr = (System.String)Dr["nameAr"];
						WorkFieldList.FillRow(WorkField);
						WorkField = null;
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
			return WorkFieldList;
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

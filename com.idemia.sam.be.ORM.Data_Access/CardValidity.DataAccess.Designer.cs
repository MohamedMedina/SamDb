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
	// The CardValidityData Class.
	[Serializable]
	public partial class CardValidityData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(CardValidity CardValidity)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, CardValidity);
		}

		public int InsertRow(DbTransaction pTran,CardValidity CardValidity)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(CardValidity.Id, ParameterDirection.Output);
			Parameters[1] = _getnameParameter(CardValidity.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(CardValidity.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[InsertCardValidity]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				CardValidity.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(CardValidity CardValidity)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, CardValidity);
		}

		public int UpdateRow(DbTransaction pTran,CardValidity CardValidity)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(CardValidity.Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(CardValidity.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(CardValidity.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[UpdateCardValidity]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(CardValidity CardValidity)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, CardValidity);
		}

		public int DeleteRow(DbTransaction pTran,CardValidity CardValidity)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(CardValidity.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[DeleteCardValidity]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(CardValidityList CardValidityList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, CardValidityList);
		}

		public int SaveRows(DbTransaction pTran,CardValidityList CardValidityList)
		{
			int intRows = 0;

			for (int i = 0; i < CardValidityList.Count; i++)
			{
				switch (CardValidityList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, CardValidityList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, CardValidityList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, CardValidityList[i]);
						break;
				}
			}

			return intRows;
		}

		#endregion

		#region SelectRows

		public CardValidityList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public CardValidityList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			CardValidityList CardValidityList = new CardValidityList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(nameAr, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Lookups].[SelectCardValidity]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						CardValidity CardValidity = new CardValidity();
						if (Dr["Id"] != DBNull.Value) CardValidity.Id = (System.Int32)Dr["Id"];
						if (Dr["name"] != DBNull.Value) CardValidity.name = (System.String)Dr["name"];
						if (Dr["nameAr"] != DBNull.Value) CardValidity.nameAr = (System.String)Dr["nameAr"];
						CardValidityList.FillRow(CardValidity);
						CardValidity = null;
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
			return CardValidityList;
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
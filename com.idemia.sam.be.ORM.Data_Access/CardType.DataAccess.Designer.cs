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
	// The CardTypeData Class.
	[Serializable]
	public partial class CardTypeData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(CardType CardType)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, CardType);
		}

		public int InsertRow(DbTransaction pTran,CardType CardType)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(CardType.Id, ParameterDirection.Output);
			Parameters[1] = _getnameParameter(CardType.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(CardType.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[InsertCardType]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				CardType.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(CardType CardType)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, CardType);
		}

		public int UpdateRow(DbTransaction pTran,CardType CardType)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(CardType.Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(CardType.name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(CardType.nameAr, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[UpdateCardType]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(CardType CardType)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, CardType);
		}

		public int DeleteRow(DbTransaction pTran,CardType CardType)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(CardType.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Lookups].[DeleteCardType]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(CardTypeList CardTypeList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, CardTypeList);
		}

		public int SaveRows(DbTransaction pTran,CardTypeList CardTypeList)
		{
			int intRows = 0;

			for (int i = 0; i < CardTypeList.Count; i++)
			{
				switch (CardTypeList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, CardTypeList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, CardTypeList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, CardTypeList[i]);
						break;
				}
			}

			return intRows;
		}

		#endregion

		#region SelectRows

		public CardTypeList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public CardTypeList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			CardTypeList CardTypeList = new CardTypeList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getnameParameter(name, ParameterDirection.Input);
			Parameters[2] = _getnameArParameter(nameAr, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Lookups].[SelectCardType]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						CardType CardType = new CardType();
						if (Dr["Id"] != DBNull.Value) CardType.Id = (System.Int32)Dr["Id"];
						if (Dr["name"] != DBNull.Value) CardType.name = (System.String)Dr["name"];
						if (Dr["nameAr"] != DBNull.Value) CardType.nameAr = (System.String)Dr["nameAr"];
						CardTypeList.FillRow(CardType);
						CardType = null;
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
			return CardTypeList;
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

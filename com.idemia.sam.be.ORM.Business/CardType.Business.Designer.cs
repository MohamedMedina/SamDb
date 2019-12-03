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
using DataAccess;

namespace Business
{
	// Summary:
	// The CardTypeBusiness Class.
	[Serializable]
	public partial class CardTypeBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private CardTypeData CardTypeData = new CardTypeData();
	
		#region InsertRow

		public int InsertRow(CardType CardType)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, CardType,false);
		}

		public int InsertRow(DbTransaction pTran, CardType CardType)
		{
			return InsertRow(pTran, CardType,false);
		}

		public int InsertRow(DbTransaction pTran, CardType CardType,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = CardTypeData.CreateTransaction();
				}
				intRow = CardTypeData.InsertRow(objTran, CardType);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardTypeData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardTypeData.RollbackTransaction(objTran,true);
					objTran = null;
				}
			}
			finally
			{
			}
			return intRow;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(CardType CardType)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, CardType,false);
		}

		public int UpdateRow(DbTransaction pTran, CardType CardType)
		{
			return UpdateRow(pTran, CardType,false);
		}

		public int UpdateRow(DbTransaction pTran, CardType CardType,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = CardTypeData.CreateTransaction();
				}
				intRow = CardTypeData.UpdateRow(objTran, CardType);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardTypeData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardTypeData.RollbackTransaction(objTran,true);
					objTran = null;
				}
			}
			finally
			{
			}
			return intRow;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(CardType CardType)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, CardType,false);
		}

		public int DeleteRow(DbTransaction pTran, CardType CardType)
		{
			return DeleteRow(pTran, CardType,false);
		}

		public int DeleteRow(DbTransaction pTran, CardType CardType,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = CardTypeData.CreateTransaction();
				}
				intRow = CardTypeData.DeleteRow(objTran, CardType);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardTypeData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardTypeData.RollbackTransaction(objTran,true);
					objTran = null;
				}
			}
			finally
			{
			}
			return intRow;
		}

		#endregion

		#region SaveRows

		public int SaveRows(CardTypeList CardTypeList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, CardTypeList,true);
		}

		public int SaveRows(DbTransaction pTran, CardTypeList CardTypeList)
		{
			return SaveRows(pTran, CardTypeList,true);
		}

		public int SaveRows(DbTransaction pTran, CardTypeList CardTypeList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = CardTypeData.CreateTransaction();
				}
				intRows = CardTypeData.SaveRows(objTran, CardTypeList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardTypeData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardTypeData.RollbackTransaction(objTran,true);
					objTran = null;
				}
			}
			finally
			{
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
			return CardTypeData.SelectRows(pTran, Id,name,nameAr);
		}

		#endregion

	}
}

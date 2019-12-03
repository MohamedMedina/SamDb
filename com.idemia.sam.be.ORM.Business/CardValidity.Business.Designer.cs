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
	// The CardValidityBusiness Class.
	[Serializable]
	public partial class CardValidityBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private CardValidityData CardValidityData = new CardValidityData();
	
		#region InsertRow

		public int InsertRow(CardValidity CardValidity)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, CardValidity,false);
		}

		public int InsertRow(DbTransaction pTran, CardValidity CardValidity)
		{
			return InsertRow(pTran, CardValidity,false);
		}

		public int InsertRow(DbTransaction pTran, CardValidity CardValidity,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = CardValidityData.CreateTransaction();
				}
				intRow = CardValidityData.InsertRow(objTran, CardValidity);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardValidityData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardValidityData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(CardValidity CardValidity)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, CardValidity,false);
		}

		public int UpdateRow(DbTransaction pTran, CardValidity CardValidity)
		{
			return UpdateRow(pTran, CardValidity,false);
		}

		public int UpdateRow(DbTransaction pTran, CardValidity CardValidity,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = CardValidityData.CreateTransaction();
				}
				intRow = CardValidityData.UpdateRow(objTran, CardValidity);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardValidityData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardValidityData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(CardValidity CardValidity)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, CardValidity,false);
		}

		public int DeleteRow(DbTransaction pTran, CardValidity CardValidity)
		{
			return DeleteRow(pTran, CardValidity,false);
		}

		public int DeleteRow(DbTransaction pTran, CardValidity CardValidity,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = CardValidityData.CreateTransaction();
				}
				intRow = CardValidityData.DeleteRow(objTran, CardValidity);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardValidityData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardValidityData.RollbackTransaction(objTran,true);
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

		public int SaveRows(CardValidityList CardValidityList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, CardValidityList,true);
		}

		public int SaveRows(DbTransaction pTran, CardValidityList CardValidityList)
		{
			return SaveRows(pTran, CardValidityList,true);
		}

		public int SaveRows(DbTransaction pTran, CardValidityList CardValidityList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = CardValidityData.CreateTransaction();
				}
				intRows = CardValidityData.SaveRows(objTran, CardValidityList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardValidityData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CardValidityData.RollbackTransaction(objTran,true);
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

		public CardValidityList SelectRows(System.Int32? Id,System.String name,System.String nameAr)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,name,nameAr);
		}

		public CardValidityList SelectRows(DbTransaction pTran,System.Int32? Id,System.String name,System.String nameAr)
		{
			return CardValidityData.SelectRows(pTran, Id,name,nameAr);
		}

		#endregion

	}
}

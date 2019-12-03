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
	// The CustomerBusiness Class.
	[Serializable]
	public partial class CustomerBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private CustomerData CustomerData = new CustomerData();
	
		#region InsertRow

		public int InsertRow(Customer Customer)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, Customer,false);
		}

		public int InsertRow(DbTransaction pTran, Customer Customer)
		{
			return InsertRow(pTran, Customer,false);
		}

		public int InsertRow(DbTransaction pTran, Customer Customer,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = CustomerData.CreateTransaction();
				}
				intRow = CustomerData.InsertRow(objTran, Customer);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CustomerData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CustomerData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(Customer Customer)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, Customer,false);
		}

		public int UpdateRow(DbTransaction pTran, Customer Customer)
		{
			return UpdateRow(pTran, Customer,false);
		}

		public int UpdateRow(DbTransaction pTran, Customer Customer,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = CustomerData.CreateTransaction();
				}
				intRow = CustomerData.UpdateRow(objTran, Customer);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CustomerData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CustomerData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(Customer Customer)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, Customer,false);
		}

		public int DeleteRow(DbTransaction pTran, Customer Customer)
		{
			return DeleteRow(pTran, Customer,false);
		}

		public int DeleteRow(DbTransaction pTran, Customer Customer,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = CustomerData.CreateTransaction();
				}
				intRow = CustomerData.DeleteRow(objTran, Customer);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CustomerData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CustomerData.RollbackTransaction(objTran,true);
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

		public int SaveRows(CustomerList CustomerList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, CustomerList,true);
		}

		public int SaveRows(DbTransaction pTran, CustomerList CustomerList)
		{
			return SaveRows(pTran, CustomerList,true);
		}

		public int SaveRows(DbTransaction pTran, CustomerList CustomerList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = CustomerData.CreateTransaction();
				}
				intRows = CustomerData.SaveRows(objTran, CustomerList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CustomerData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					CustomerData.RollbackTransaction(objTran,true);
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

		public CustomerList SelectRows(System.Int32? Id,System.String code,System.String name,System.String nameAr,System.Int32? workFieldId)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,code,name,nameAr,workFieldId);
		}

		public CustomerList SelectRows(DbTransaction pTran,System.Int32? Id,System.String code,System.String name,System.String nameAr,System.Int32? workFieldId)
		{
			return CustomerData.SelectRows(pTran, Id,code,name,nameAr,workFieldId);
		}

		#endregion

	}
}

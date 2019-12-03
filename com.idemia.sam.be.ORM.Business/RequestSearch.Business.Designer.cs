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
	// The RequestSearchBusiness Class.
	[Serializable]
	public partial class RequestSearchBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private RequestSearchData RequestSearchData = new RequestSearchData();
	
		#region InsertRow

		public int InsertRow(RequestSearch RequestSearch)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RequestSearch,false);
		}

		public int InsertRow(DbTransaction pTran, RequestSearch RequestSearch)
		{
			return InsertRow(pTran, RequestSearch,false);
		}

		public int InsertRow(DbTransaction pTran, RequestSearch RequestSearch,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestSearchData.CreateTransaction();
				}
				intRow = RequestSearchData.InsertRow(objTran, RequestSearch);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestSearchData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestSearchData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(RequestSearch RequestSearch)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RequestSearch,false);
		}

		public int UpdateRow(DbTransaction pTran, RequestSearch RequestSearch)
		{
			return UpdateRow(pTran, RequestSearch,false);
		}

		public int UpdateRow(DbTransaction pTran, RequestSearch RequestSearch,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestSearchData.CreateTransaction();
				}
				intRow = RequestSearchData.UpdateRow(objTran, RequestSearch);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestSearchData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestSearchData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(RequestSearch RequestSearch)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RequestSearch,false);
		}

		public int DeleteRow(DbTransaction pTran, RequestSearch RequestSearch)
		{
			return DeleteRow(pTran, RequestSearch,false);
		}

		public int DeleteRow(DbTransaction pTran, RequestSearch RequestSearch,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestSearchData.CreateTransaction();
				}
				intRow = RequestSearchData.DeleteRow(objTran, RequestSearch);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestSearchData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestSearchData.RollbackTransaction(objTran,true);
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

		public int SaveRows(RequestSearchList RequestSearchList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestSearchList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestSearchList RequestSearchList)
		{
			return SaveRows(pTran, RequestSearchList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestSearchList RequestSearchList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestSearchData.CreateTransaction();
				}
				intRows = RequestSearchData.SaveRows(objTran, RequestSearchList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestSearchData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestSearchData.RollbackTransaction(objTran,true);
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

		public RequestSearchList SelectRows(System.Int32? Id,System.String requestNumber,System.DateTime? creationDateFrom,System.DateTime? creationDateTo,System.DateTime? approvalDateFrom,System.DateTime? approvalDateTo,System.DateTime? receiveDateFrom,System.DateTime? receiveDateTo,System.DateTime? rejectionDateFrom,System.DateTime? rejectionDateTo)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,requestNumber,creationDateFrom,creationDateTo,approvalDateFrom,approvalDateTo,receiveDateFrom,receiveDateTo,rejectionDateFrom,rejectionDateTo);
		}

		public RequestSearchList SelectRows(DbTransaction pTran,System.Int32? Id,System.String requestNumber,System.DateTime? creationDateFrom,System.DateTime? creationDateTo,System.DateTime? approvalDateFrom,System.DateTime? approvalDateTo,System.DateTime? receiveDateFrom,System.DateTime? receiveDateTo,System.DateTime? rejectionDateFrom,System.DateTime? rejectionDateTo)
		{
			return RequestSearchData.SelectRows(pTran, Id,requestNumber,creationDateFrom,creationDateTo,approvalDateFrom,approvalDateTo,receiveDateFrom,receiveDateTo,rejectionDateFrom,rejectionDateTo);
		}

		#endregion

	}
}

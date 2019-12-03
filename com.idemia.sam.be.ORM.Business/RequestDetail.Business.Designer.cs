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
	// The RequestDetailBusiness Class.
	[Serializable]
	public partial class RequestDetailBusiness : ApplicationBlocks.Layers.BaseBusiness
	{
		private RequestDetailData RequestDetailData = new RequestDetailData();
	
		#region InsertRow

		public int InsertRow(RequestDetail RequestDetail)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RequestDetail,false);
		}

		public int InsertRow(DbTransaction pTran, RequestDetail RequestDetail)
		{
			return InsertRow(pTran, RequestDetail,false);
		}

		public int InsertRow(DbTransaction pTran, RequestDetail RequestDetail,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestDetailData.CreateTransaction();
				}
				intRow = RequestDetailData.InsertRow(objTran, RequestDetail);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestDetailData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestDetailData.RollbackTransaction(objTran,true);
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

		public int UpdateRow(RequestDetail RequestDetail)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RequestDetail,false);
		}

		public int UpdateRow(DbTransaction pTran, RequestDetail RequestDetail)
		{
			return UpdateRow(pTran, RequestDetail,false);
		}

		public int UpdateRow(DbTransaction pTran, RequestDetail RequestDetail,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestDetailData.CreateTransaction();
				}
				intRow = RequestDetailData.UpdateRow(objTran, RequestDetail);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestDetailData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestDetailData.RollbackTransaction(objTran,true);
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

		public int DeleteRow(RequestDetail RequestDetail)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RequestDetail,false);
		}

		public int DeleteRow(DbTransaction pTran, RequestDetail RequestDetail)
		{
			return DeleteRow(pTran, RequestDetail,false);
		}

		public int DeleteRow(DbTransaction pTran, RequestDetail RequestDetail,bool CreateTransaction)
		{
			int intRow = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestDetailData.CreateTransaction();
				}
				intRow = RequestDetailData.DeleteRow(objTran, RequestDetail);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestDetailData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestDetailData.RollbackTransaction(objTran,true);
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

		public int SaveRows(RequestDetailList RequestDetailList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestDetailList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestDetailList RequestDetailList)
		{
			return SaveRows(pTran, RequestDetailList,true);
		}

		public int SaveRows(DbTransaction pTran, RequestDetailList RequestDetailList,bool CreateTransaction)
		{
			int intRows = 0;
			DbTransaction objTran = pTran;
			Exception exception = null;
			try
			{
				if (pTran ==null && CreateTransaction == true)
				{
					objTran = RequestDetailData.CreateTransaction();
				}
				intRows = RequestDetailData.SaveRows(objTran, RequestDetailList);
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestDetailData.CommitTransaction(objTran,true);
					objTran = null;
				}
			}
			catch (Exception EX)
			{
				exception = EX;
				if (pTran == null && objTran != null && CreateTransaction == true)
				{
					RequestDetailData.RollbackTransaction(objTran,true);
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

		public RequestDetailList SelectRows(System.Int32? Id,System.Int32? cardTypeID,System.Int32? requestID)
		{
			DbTransaction Tran = null;
			return SelectRows(Tran, Id,cardTypeID,requestID);
		}

		public RequestDetailList SelectRows(DbTransaction pTran,System.Int32? Id,System.Int32? cardTypeID,System.Int32? requestID)
		{
			return RequestDetailData.SelectRows(pTran, Id,cardTypeID,requestID);
		}

		#endregion

	}
}

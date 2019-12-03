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
	// The RequestDetailData Class.
	[Serializable]
	public partial class RequestDetailData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(RequestDetail RequestDetail)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, RequestDetail);
		}

		public int InsertRow(DbTransaction pTran,RequestDetail RequestDetail)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[4];
			Parameters[0] = _getIdParameter(RequestDetail.Id, ParameterDirection.Output);
			Parameters[1] = _getquantityParameter(RequestDetail.quantity, ParameterDirection.Input);
			Parameters[2] = _getcardTypeIDParameter(RequestDetail.cardTypeID, ParameterDirection.Input);
			Parameters[3] = _getrequestIDParameter(RequestDetail.requestID, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Transactions].[InsertRequestDetail]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				RequestDetail.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(RequestDetail RequestDetail)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, RequestDetail);
		}

		public int UpdateRow(DbTransaction pTran,RequestDetail RequestDetail)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[4];
			Parameters[0] = _getIdParameter(RequestDetail.Id, ParameterDirection.Input);
			Parameters[1] = _getquantityParameter(RequestDetail.quantity, ParameterDirection.Input);
			Parameters[2] = _getcardTypeIDParameter(RequestDetail.cardTypeID, ParameterDirection.Input);
			Parameters[3] = _getrequestIDParameter(RequestDetail.requestID, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Transactions].[UpdateRequestDetail]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(RequestDetail RequestDetail)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, RequestDetail);
		}

		public int DeleteRow(DbTransaction pTran,RequestDetail RequestDetail)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(RequestDetail.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Transactions].[DeleteRequestDetail]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(RequestDetailList RequestDetailList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, RequestDetailList);
		}

		public int SaveRows(DbTransaction pTran,RequestDetailList RequestDetailList)
		{
			int intRows = 0;

			for (int i = 0; i < RequestDetailList.Count; i++)
			{
				switch (RequestDetailList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, RequestDetailList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, RequestDetailList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, RequestDetailList[i]);
						break;
				}
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
			RequestDetailList RequestDetailList = new RequestDetailList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[3];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getcardTypeIDParameter(cardTypeID, ParameterDirection.Input);
			Parameters[2] = _getrequestIDParameter(requestID, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Transactions].[SelectRequestDetail]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						RequestDetail RequestDetail = new RequestDetail();
						if (Dr["Id"] != DBNull.Value) RequestDetail.Id = (System.Int32)Dr["Id"];
						if (Dr["quantity"] != DBNull.Value) RequestDetail.quantity = (System.Int32?)Dr["quantity"];
						if (Dr["cardTypeID"] != DBNull.Value) RequestDetail.cardTypeID = (System.Int32?)Dr["cardTypeID"];
						if (Dr["requestID"] != DBNull.Value) RequestDetail.requestID = (System.Int32?)Dr["requestID"];
						RequestDetailList.FillRow(RequestDetail);
						RequestDetail = null;
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
			return RequestDetailList;
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
	
		#region _getquantityParameter
		/// <summary>
		/// Methods _getquantityParameter Represent Parameter quantity in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getquantityParameter(System.Int32? quantity,ParameterDirection pParameterDirection)
		{
			return CreateParameter("quantity",quantity,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getcardTypeIDParameter
		/// <summary>
		/// Methods _getcardTypeIDParameter Represent Parameter cardTypeID in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getcardTypeIDParameter(System.Int32? cardTypeID,ParameterDirection pParameterDirection)
		{
			return CreateParameter("cardTypeID",cardTypeID,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#region _getrequestIDParameter
		/// <summary>
		/// Methods _getrequestIDParameter Represent Parameter requestID in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getrequestIDParameter(System.Int32? requestID,ParameterDirection pParameterDirection)
		{
			return CreateParameter("requestID",requestID,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#endregion

	}
}

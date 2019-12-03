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
	// The CustomerData Class.
	[Serializable]
	public partial class CustomerData : ApplicationBlocks.Layers.BaseDataAccess
	{

		#region InsertRow

		public int InsertRow(Customer Customer)
		{
			DbTransaction Tran = null;
			return InsertRow(Tran, Customer);
		}

		public int InsertRow(DbTransaction pTran,Customer Customer)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[8];
			Parameters[0] = _getIdParameter(Customer.Id, ParameterDirection.Output);
			Parameters[1] = _getcodeParameter(Customer.code, ParameterDirection.Input);
			Parameters[2] = _getnameParameter(Customer.name, ParameterDirection.Input);
			Parameters[3] = _getnameArParameter(Customer.nameAr, ParameterDirection.Input);
			Parameters[4] = _getaddressParameter(Customer.address, ParameterDirection.Input);
			Parameters[5] = _getphoneParameter(Customer.phone, ParameterDirection.Input);
			Parameters[6] = _getemailParameter(Customer.email, ParameterDirection.Input);
			Parameters[7] = _getworkFieldIdParameter(Customer.workFieldId, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Transactions].[InsertCustomer]", Parameters);

			if(Parameters[0].Value != DBNull.Value)
				Customer.Id=(System.Int32)Parameters[0].Value;

			return intRows;
		}

		#endregion

		#region UpdateRow

		public int UpdateRow(Customer Customer)
		{
			DbTransaction Tran = null;
			return UpdateRow(Tran, Customer);
		}

		public int UpdateRow(DbTransaction pTran,Customer Customer)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[8];
			Parameters[0] = _getIdParameter(Customer.Id, ParameterDirection.Input);
			Parameters[1] = _getcodeParameter(Customer.code, ParameterDirection.Input);
			Parameters[2] = _getnameParameter(Customer.name, ParameterDirection.Input);
			Parameters[3] = _getnameArParameter(Customer.nameAr, ParameterDirection.Input);
			Parameters[4] = _getaddressParameter(Customer.address, ParameterDirection.Input);
			Parameters[5] = _getphoneParameter(Customer.phone, ParameterDirection.Input);
			Parameters[6] = _getemailParameter(Customer.email, ParameterDirection.Input);
			Parameters[7] = _getworkFieldIdParameter(Customer.workFieldId, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Transactions].[UpdateCustomer]", Parameters);

			return intRows;
		}

		#endregion

		#region DeleteRow

		public int DeleteRow(Customer Customer)
		{
			DbTransaction Tran = null;
			return DeleteRow(Tran, Customer);
		}

		public int DeleteRow(DbTransaction pTran,Customer Customer)
		{
			int intRows = 0;

			DbParameter[] Parameters= new DbParameter[1];
			Parameters[0] = _getIdParameter(Customer.Id, ParameterDirection.Input);

			intRows = ExecuteNonQuery(pTran, "[Transactions].[DeleteCustomer]", Parameters);

			return intRows;
		}

		#endregion

		#region SaveRows

		public int SaveRows(CustomerList CustomerList)
		{
			DbTransaction Tran = null;
			return SaveRows(Tran, CustomerList);
		}

		public int SaveRows(DbTransaction pTran,CustomerList CustomerList)
		{
			int intRows = 0;

			for (int i = 0; i < CustomerList.Count; i++)
			{
				switch (CustomerList[i].CommonState)
				{
					case CommonState.Added:
						intRows += InsertRow(pTran, CustomerList[i]);
						break;
					case CommonState.Modified:
						intRows += UpdateRow(pTran, CustomerList[i]);
						break;
					case CommonState.Deleted:
						intRows += DeleteRow(pTran, CustomerList[i]);
						break;
				}
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
			CustomerList CustomerList = new CustomerList();
			Exception exception = null;

			DbParameter[] Parameters= new DbParameter[5];
			Parameters[0] = _getIdParameter(Id, ParameterDirection.Input);
			Parameters[1] = _getcodeParameter(code, ParameterDirection.Input);
			Parameters[2] = _getnameParameter(name, ParameterDirection.Input);
			Parameters[3] = _getnameArParameter(nameAr, ParameterDirection.Input);
			Parameters[4] = _getworkFieldIdParameter(workFieldId, ParameterDirection.Input);

			DbDataReader Dr = ExecuteReader(pTran, "[Transactions].[SelectCustomer]", Parameters);

			try
			{
				if (Dr != null)
				{
					while (Dr.Read())
					{
						Customer Customer = new Customer();
						if (Dr["Id"] != DBNull.Value) Customer.Id = (System.Int32)Dr["Id"];
						if (Dr["code"] != DBNull.Value) Customer.code = (System.String)Dr["code"];
						if (Dr["name"] != DBNull.Value) Customer.name = (System.String)Dr["name"];
						if (Dr["nameAr"] != DBNull.Value) Customer.nameAr = (System.String)Dr["nameAr"];
						if (Dr["address"] != DBNull.Value) Customer.address = (System.String)Dr["address"];
						if (Dr["phone"] != DBNull.Value) Customer.phone = (System.String)Dr["phone"];
						if (Dr["email"] != DBNull.Value) Customer.email = (System.String)Dr["email"];
						if (Dr["workFieldId"] != DBNull.Value) Customer.workFieldId = (System.Int32?)Dr["workFieldId"];
						CustomerList.FillRow(Customer);
						Customer = null;
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
			return CustomerList;
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
	
		#region _getcodeParameter
		/// <summary>
		/// Methods _getcodeParameter Represent Parameter code in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getcodeParameter(System.String code,ParameterDirection pParameterDirection)
		{
			return CreateParameter("code",code,DbType.String,pParameterDirection,60);
		}
		#endregion
	
		#region _getnameParameter
		/// <summary>
		/// Methods _getnameParameter Represent Parameter name in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getnameParameter(System.String name,ParameterDirection pParameterDirection)
		{
			return CreateParameter("name",name,DbType.String,pParameterDirection,200);
		}
		#endregion
	
		#region _getnameArParameter
		/// <summary>
		/// Methods _getnameArParameter Represent Parameter nameAr in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getnameArParameter(System.String nameAr,ParameterDirection pParameterDirection)
		{
			return CreateParameter("nameAr",nameAr,DbType.String,pParameterDirection,200);
		}
		#endregion
	
		#region _getaddressParameter
		/// <summary>
		/// Methods _getaddressParameter Represent Parameter address in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getaddressParameter(System.String address,ParameterDirection pParameterDirection)
		{
			return CreateParameter("address",address,DbType.String,pParameterDirection,200);
		}
		#endregion
	
		#region _getphoneParameter
		/// <summary>
		/// Methods _getphoneParameter Represent Parameter phone in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getphoneParameter(System.String phone,ParameterDirection pParameterDirection)
		{
			return CreateParameter("phone",phone,DbType.String,pParameterDirection,40);
		}
		#endregion
	
		#region _getemailParameter
		/// <summary>
		/// Methods _getemailParameter Represent Parameter email in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getemailParameter(System.String email,ParameterDirection pParameterDirection)
		{
			return CreateParameter("email",email,DbType.String,pParameterDirection,200);
		}
		#endregion
	
		#region _getworkFieldIdParameter
		/// <summary>
		/// Methods _getworkFieldIdParameter Represent Parameter workFieldId in CodeGeneratingInfo Table
		/// <param name="pParameterDirection">Specifies the type of a parameter</param>
		/// </summary>
		private DbParameter _getworkFieldIdParameter(System.Int32? workFieldId,ParameterDirection pParameterDirection)
		{
			return CreateParameter("workFieldId",workFieldId,DbType.Int32,pParameterDirection,4);
		}
		#endregion
	
		#endregion

	}
}

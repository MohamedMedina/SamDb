using System.Text;
using System;
using System.Collections.Generic;
using ApplicationBlocks.Layers;
using ApplicationBlocks.Utilities;
using ApplicationBlocks.ExceptionManagement;
using ApplicationBlocks.DatabaseServices;

namespace Common
{
	// Summary:
	// The CustomerList Class.
	[Serializable]
	public partial class CustomerList : ApplicationBlocks.Layers.BaseCommonList<Customer>
	{
		#region Constructor
		/// <summary>
		/// Constructor To Create a new Customer object.
		/// </summary>
		public CustomerList():base()
		{
		}
		/// <summary>
		/// Constructor To Create a new Customer object.
		/// </summary>
		/// <param name="collection">IThe collection whose elements are copied to the new list.</param>
		public CustomerList(IEnumerable<Customer> collection):base(collection)
		{
		}
		/// <summary>
		/// Constructor To Create a new Customer object.
		/// </summary>
		/// <param name="capacity">The number of elements that the new list can initially store.</param>
		public CustomerList(int capacity):base(capacity)
		{
		}
		#endregion

	}
	
	// Summary:
	// The Customer Class.
	[Serializable]
	public partial class Customer : ApplicationBlocks.Layers.BaseCommon<Customer>
	{

		#region Factor Method
		/// <summary>
		/// Factor Method To Create a new Customer object.
		/// </summary>
		/// <param name="Id">Initial value of Id.</param>
		/// <param name="code">Initial value of code.</param>
		/// <param name="name">Initial value of name.</param>
		/// <param name="nameAr">Initial value of nameAr.</param>
		/// <param name="address">Initial value of address.</param>
		/// <param name="phone">Initial value of phone.</param>
		/// <param name="email">Initial value of email.</param>
		/// <param name="workFieldId">Initial value of workFieldId.</param>
		/// <returns>Return New Customer Object</returns>
		public static Customer CreateCustomer(
											System.Int32 Id, System.String code, System.String name, System.String nameAr, System.String address
											,System.String phone, System.String email, System.Int32? workFieldId)
		{
			Customer objCustomer = new Customer();
			objCustomer.Id = Id;
			objCustomer.code = code;
			objCustomer.name = name;
			objCustomer.nameAr = nameAr;
			objCustomer.address = address;
			objCustomer.phone = phone;
			objCustomer.email = email;
			objCustomer.workFieldId = workFieldId;
			return objCustomer;
		}
		#endregion

		#region CustomerList
		/// <summary>
		/// Property CustomerList Represent Rows Collection of Customer.
		/// </summary>
		public CustomerList CustomerList
		{
			get
			{
				return (CustomerList)base.BaseCommonList;
			}
		}
		#endregion
	
		#region Id
		/// <summary>
		/// Property Id Represent Column Id in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32 Id
		{
			get
			{
				return _Id;
			}
			set
			{
				_onIdChanging(value);
				_onChangingValue("Id",value,IsIdAllowNull);
				_Id = value;
				_onChangedValue("Id");
				_onIdChanged();
			}
		}
		private System.Int32 _Id;
		partial void _onIdChanging(System.Int32 value);
		partial void _onIdChanged();
		/// <summary>
		/// get value of Id Property is Allow Null or not
		/// </summary>
		public System.Boolean IsIdAllowNull
		{
			get
			{
				return false;
			}
		}
		#endregion
	
		#region code
		/// <summary>
		/// Property code Represent Column code in CodeGeneratingInfo Table
		/// </summary>
		public System.String code
		{
			get
			{
				return _code;
			}
			set
			{
				_oncodeChanging(value);
				_onChangingValue("code",value,IscodeAllowNull);
				_code = value;
				_onChangedValue("code");
				_oncodeChanged();
			}
		}
		private System.String _code;
		partial void _oncodeChanging(System.String value);
		partial void _oncodeChanged();
		/// <summary>
		/// get value of code Property is Allow Null or not
		/// </summary>
		public System.Boolean IscodeAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region name
		/// <summary>
		/// Property name Represent Column name in CodeGeneratingInfo Table
		/// </summary>
		public System.String name
		{
			get
			{
				return _name;
			}
			set
			{
				_onnameChanging(value);
				_onChangingValue("name",value,IsnameAllowNull);
				_name = value;
				_onChangedValue("name");
				_onnameChanged();
			}
		}
		private System.String _name;
		partial void _onnameChanging(System.String value);
		partial void _onnameChanged();
		/// <summary>
		/// get value of name Property is Allow Null or not
		/// </summary>
		public System.Boolean IsnameAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region nameAr
		/// <summary>
		/// Property nameAr Represent Column nameAr in CodeGeneratingInfo Table
		/// </summary>
		public System.String nameAr
		{
			get
			{
				return _nameAr;
			}
			set
			{
				_onnameArChanging(value);
				_onChangingValue("nameAr",value,IsnameArAllowNull);
				_nameAr = value;
				_onChangedValue("nameAr");
				_onnameArChanged();
			}
		}
		private System.String _nameAr;
		partial void _onnameArChanging(System.String value);
		partial void _onnameArChanged();
		/// <summary>
		/// get value of nameAr Property is Allow Null or not
		/// </summary>
		public System.Boolean IsnameArAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region address
		/// <summary>
		/// Property address Represent Column address in CodeGeneratingInfo Table
		/// </summary>
		public System.String address
		{
			get
			{
				return _address;
			}
			set
			{
				_onaddressChanging(value);
				_onChangingValue("address",value,IsaddressAllowNull);
				_address = value;
				_onChangedValue("address");
				_onaddressChanged();
			}
		}
		private System.String _address;
		partial void _onaddressChanging(System.String value);
		partial void _onaddressChanged();
		/// <summary>
		/// get value of address Property is Allow Null or not
		/// </summary>
		public System.Boolean IsaddressAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region phone
		/// <summary>
		/// Property phone Represent Column phone in CodeGeneratingInfo Table
		/// </summary>
		public System.String phone
		{
			get
			{
				return _phone;
			}
			set
			{
				_onphoneChanging(value);
				_onChangingValue("phone",value,IsphoneAllowNull);
				_phone = value;
				_onChangedValue("phone");
				_onphoneChanged();
			}
		}
		private System.String _phone;
		partial void _onphoneChanging(System.String value);
		partial void _onphoneChanged();
		/// <summary>
		/// get value of phone Property is Allow Null or not
		/// </summary>
		public System.Boolean IsphoneAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region email
		/// <summary>
		/// Property email Represent Column email in CodeGeneratingInfo Table
		/// </summary>
		public System.String email
		{
			get
			{
				return _email;
			}
			set
			{
				_onemailChanging(value);
				_onChangingValue("email",value,IsemailAllowNull);
				_email = value;
				_onChangedValue("email");
				_onemailChanged();
			}
		}
		private System.String _email;
		partial void _onemailChanging(System.String value);
		partial void _onemailChanged();
		/// <summary>
		/// get value of email Property is Allow Null or not
		/// </summary>
		public System.Boolean IsemailAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region workFieldId
		/// <summary>
		/// Property workFieldId Represent Column workFieldId in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? workFieldId
		{
			get
			{
				return _workFieldId;
			}
			set
			{
				_onworkFieldIdChanging(value);
				_onChangingValue("workFieldId",value,IsworkFieldIdAllowNull);
				_workFieldId = value;
				_onChangedValue("workFieldId");
				_onworkFieldIdChanged();
			}
		}
		private System.Int32? _workFieldId;
		partial void _onworkFieldIdChanging(System.Int32? value);
		partial void _onworkFieldIdChanged();
		/// <summary>
		/// get value of workFieldId Property is Allow Null or not
		/// </summary>
		public System.Boolean IsworkFieldIdAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region Relation Objects
		/// <summary>
		/// Property RequestList Represent FK_CustomerID_Request Relation
		/// ParentTable Request ParentColumn customerID ,ReferencedTable Customer ReferencedColumn Id
		/// </summary>
		public RequestList RequestList
		{
			get
			{
				return _RequestList;
			}
			set
			{
				_onRequestListChanging(value);
				_RequestList = value;
				_onRequestListChanged();
			}
		}
		private RequestList _RequestList;
		partial void _onRequestListChanging(RequestList value);
		partial void _onRequestListChanged();
	
		/// <summary>
		/// Property WorkFieldList Represent FK_WorkFieldId_Customer Relation
		/// ParentTable Customer ParentColumn workFieldId ,ReferencedTable WorkField ReferencedColumn Id
		/// </summary>
		public WorkFieldList WorkFieldList
		{
			get
			{
				return _WorkFieldList;
			}
			set
			{
				_onWorkFieldListChanging(value);
				_WorkFieldList = value;
				_onWorkFieldListChanged();
			}
		}
		private WorkFieldList _WorkFieldList;
		partial void _onWorkFieldListChanging(WorkFieldList value);
		partial void _onWorkFieldListChanged();
		#endregion
	}
}

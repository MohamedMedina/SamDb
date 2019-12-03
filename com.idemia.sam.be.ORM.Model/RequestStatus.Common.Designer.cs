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
	// The RequestStatusList Class.
	[Serializable]
	public partial class RequestStatusList : ApplicationBlocks.Layers.BaseCommonList<RequestStatus>
	{
		#region Constructor
		/// <summary>
		/// Constructor To Create a new RequestStatus object.
		/// </summary>
		public RequestStatusList():base()
		{
		}
		/// <summary>
		/// Constructor To Create a new RequestStatus object.
		/// </summary>
		/// <param name="collection">IThe collection whose elements are copied to the new list.</param>
		public RequestStatusList(IEnumerable<RequestStatus> collection):base(collection)
		{
		}
		/// <summary>
		/// Constructor To Create a new RequestStatus object.
		/// </summary>
		/// <param name="capacity">The number of elements that the new list can initially store.</param>
		public RequestStatusList(int capacity):base(capacity)
		{
		}
		#endregion

	}
	
	// Summary:
	// The RequestStatus Class.
	[Serializable]
	public partial class RequestStatus : ApplicationBlocks.Layers.BaseCommon<RequestStatus>
	{

		#region Factor Method
		/// <summary>
		/// Factor Method To Create a new RequestStatus object.
		/// </summary>
		/// <param name="Id">Initial value of Id.</param>
		/// <param name="name">Initial value of name.</param>
		/// <param name="nameAr">Initial value of nameAr.</param>
		/// <returns>Return New RequestStatus Object</returns>
		public static RequestStatus CreateRequestStatus(
											System.Int32 Id, System.String name, System.String nameAr)
		{
			RequestStatus objRequestStatus = new RequestStatus();
			objRequestStatus.Id = Id;
			objRequestStatus.name = name;
			objRequestStatus.nameAr = nameAr;
			return objRequestStatus;
		}
		#endregion

		#region RequestStatusList
		/// <summary>
		/// Property RequestStatusList Represent Rows Collection of RequestStatus.
		/// </summary>
		public RequestStatusList RequestStatusList
		{
			get
			{
				return (RequestStatusList)base.BaseCommonList;
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
	
		#region Relation Objects
		/// <summary>
		/// Property RequestList Represent FK_RequestStatusID_Request Relation
		/// ParentTable Request ParentColumn requestStatusID ,ReferencedTable RequestStatus ReferencedColumn Id
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
		#endregion
	}
}

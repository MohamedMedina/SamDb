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
	// The RequestDetailList Class.
	[Serializable]
	public partial class RequestDetailList : ApplicationBlocks.Layers.BaseCommonList<RequestDetail>
	{
		#region Constructor
		/// <summary>
		/// Constructor To Create a new RequestDetail object.
		/// </summary>
		public RequestDetailList():base()
		{
		}
		/// <summary>
		/// Constructor To Create a new RequestDetail object.
		/// </summary>
		/// <param name="collection">IThe collection whose elements are copied to the new list.</param>
		public RequestDetailList(IEnumerable<RequestDetail> collection):base(collection)
		{
		}
		/// <summary>
		/// Constructor To Create a new RequestDetail object.
		/// </summary>
		/// <param name="capacity">The number of elements that the new list can initially store.</param>
		public RequestDetailList(int capacity):base(capacity)
		{
		}
		#endregion

	}
	
	// Summary:
	// The RequestDetail Class.
	[Serializable]
	public partial class RequestDetail : ApplicationBlocks.Layers.BaseCommon<RequestDetail>
	{

		#region Factor Method
		/// <summary>
		/// Factor Method To Create a new RequestDetail object.
		/// </summary>
		/// <param name="Id">Initial value of Id.</param>
		/// <param name="quantity">Initial value of quantity.</param>
		/// <param name="cardTypeID">Initial value of cardTypeID.</param>
		/// <param name="requestID">Initial value of requestID.</param>
		/// <returns>Return New RequestDetail Object</returns>
		public static RequestDetail CreateRequestDetail(
											System.Int32 Id, System.Int32? quantity, System.Int32? cardTypeID, System.Int32? requestID)
		{
			RequestDetail objRequestDetail = new RequestDetail();
			objRequestDetail.Id = Id;
			objRequestDetail.quantity = quantity;
			objRequestDetail.cardTypeID = cardTypeID;
			objRequestDetail.requestID = requestID;
			return objRequestDetail;
		}
		#endregion

		#region RequestDetailList
		/// <summary>
		/// Property RequestDetailList Represent Rows Collection of RequestDetail.
		/// </summary>
		public RequestDetailList RequestDetailList
		{
			get
			{
				return (RequestDetailList)base.BaseCommonList;
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
	
		#region quantity
		/// <summary>
		/// Property quantity Represent Column quantity in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? quantity
		{
			get
			{
				return _quantity;
			}
			set
			{
				_onquantityChanging(value);
				_onChangingValue("quantity",value,IsquantityAllowNull);
				_quantity = value;
				_onChangedValue("quantity");
				_onquantityChanged();
			}
		}
		private System.Int32? _quantity;
		partial void _onquantityChanging(System.Int32? value);
		partial void _onquantityChanged();
		/// <summary>
		/// get value of quantity Property is Allow Null or not
		/// </summary>
		public System.Boolean IsquantityAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region cardTypeID
		/// <summary>
		/// Property cardTypeID Represent Column cardTypeID in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? cardTypeID
		{
			get
			{
				return _cardTypeID;
			}
			set
			{
				_oncardTypeIDChanging(value);
				_onChangingValue("cardTypeID",value,IscardTypeIDAllowNull);
				_cardTypeID = value;
				_onChangedValue("cardTypeID");
				_oncardTypeIDChanged();
			}
		}
		private System.Int32? _cardTypeID;
		partial void _oncardTypeIDChanging(System.Int32? value);
		partial void _oncardTypeIDChanged();
		/// <summary>
		/// get value of cardTypeID Property is Allow Null or not
		/// </summary>
		public System.Boolean IscardTypeIDAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region requestID
		/// <summary>
		/// Property requestID Represent Column requestID in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? requestID
		{
			get
			{
				return _requestID;
			}
			set
			{
				_onrequestIDChanging(value);
				_onChangingValue("requestID",value,IsrequestIDAllowNull);
				_requestID = value;
				_onChangedValue("requestID");
				_onrequestIDChanged();
			}
		}
		private System.Int32? _requestID;
		partial void _onrequestIDChanging(System.Int32? value);
		partial void _onrequestIDChanged();
		/// <summary>
		/// get value of requestID Property is Allow Null or not
		/// </summary>
		public System.Boolean IsrequestIDAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region Relation Objects
		/// <summary>
		/// Property CardTypeList Represent FK_CardTypeID_RequestDetail Relation
		/// ParentTable RequestDetail ParentColumn cardTypeID ,ReferencedTable CardType ReferencedColumn Id
		/// </summary>
		public CardTypeList CardTypeList
		{
			get
			{
				return _CardTypeList;
			}
			set
			{
				_onCardTypeListChanging(value);
				_CardTypeList = value;
				_onCardTypeListChanged();
			}
		}
		private CardTypeList _CardTypeList;
		partial void _onCardTypeListChanging(CardTypeList value);
		partial void _onCardTypeListChanged();
	
		/// <summary>
		/// Property RequestList Represent FK_RequestID_RequestDetail Relation
		/// ParentTable RequestDetail ParentColumn requestID ,ReferencedTable Request ReferencedColumn Id
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

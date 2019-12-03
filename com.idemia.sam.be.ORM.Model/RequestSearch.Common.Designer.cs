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
	// The RequestSearchList Class.
	[Serializable]
	public partial class RequestSearchList : ApplicationBlocks.Layers.BaseCommonList<RequestSearch>
	{
		#region Constructor
		/// <summary>
		/// Constructor To Create a new RequestSearch object.
		/// </summary>
		public RequestSearchList():base()
		{
		}
		/// <summary>
		/// Constructor To Create a new RequestSearch object.
		/// </summary>
		/// <param name="collection">IThe collection whose elements are copied to the new list.</param>
		public RequestSearchList(IEnumerable<RequestSearch> collection):base(collection)
		{
		}
		/// <summary>
		/// Constructor To Create a new RequestSearch object.
		/// </summary>
		/// <param name="capacity">The number of elements that the new list can initially store.</param>
		public RequestSearchList(int capacity):base(capacity)
		{
		}
		#endregion

	}
	
	// Summary:
	// The RequestSearch Class.
	[Serializable]
	public partial class RequestSearch : ApplicationBlocks.Layers.BaseCommon<RequestSearch>
	{

		#region Factor Method
		/// <summary>
		/// Factor Method To Create a new RequestSearch object.
		/// </summary>
		/// <param name="Id">Initial value of Id.</param>
		/// <param name="requestNumber">Initial value of requestNumber.</param>
		/// <param name="totalQuantity">Initial value of totalQuantity.</param>
		/// <param name="PDDFrom">Initial value of PDDFrom.</param>
		/// <param name="PDDTo">Initial value of PDDTo.</param>
		/// <param name="customerID">Initial value of customerID.</param>
		/// <param name="creationDateFrom">Initial value of creationDateFrom.</param>
		/// <param name="creationDateTo">Initial value of creationDateTo.</param>
		/// <param name="creationUserID">Initial value of creationUserID.</param>
		/// <param name="approvalDateFrom">Initial value of approvalDateFrom.</param>
		/// <param name="approvalDateTo">Initial value of approvalDateTo.</param>
		/// <param name="approvalUserID">Initial value of approvalUserID.</param>
		/// <param name="receiveDateFrom">Initial value of receiveDateFrom.</param>
		/// <param name="receiveDateTo">Initial value of receiveDateTo.</param>
		/// <param name="receiveUserID">Initial value of receiveUserID.</param>
		/// <param name="rejectionDateFrom">Initial value of rejectionDateFrom.</param>
		/// <param name="rejectionDateTo">Initial value of rejectionDateTo.</param>
		/// <param name="rejectionUserID">Initial value of rejectionUserID.</param>
		/// <param name="rejectionReasonID">Initial value of rejectionReasonID.</param>
		/// <param name="requestTypeID">Initial value of requestTypeID.</param>
		/// <param name="requestStatusID">Initial value of requestStatusID.</param>
		/// <param name="requestCalssID">Initial value of requestCalssID.</param>
		/// <param name="requestPriorityID">Initial value of requestPriorityID.</param>
		/// <param name="cardTypeID">Initial value of cardTypeID.</param>
		/// <returns>Return New RequestSearch Object</returns>
		public static RequestSearch CreateRequestSearch(
											System.Int32 Id, System.String requestNumber, System.Int32? totalQuantity, System.DateTime? PDDFrom, System.DateTime? PDDTo
											,System.Int32? customerID, System.DateTime? creationDateFrom, System.DateTime? creationDateTo, System.Int32? creationUserID, System.DateTime? approvalDateFrom
											,System.DateTime? approvalDateTo, System.Int32? approvalUserID, System.DateTime? receiveDateFrom, System.DateTime? receiveDateTo, System.Int32? receiveUserID
											,System.DateTime? rejectionDateFrom, System.DateTime? rejectionDateTo, System.Int32? rejectionUserID, System.Int32? rejectionReasonID, System.Int32? requestTypeID
											,System.Int32? requestStatusID, System.Int32? requestCalssID, System.Int32? requestPriorityID, System.Int32? cardTypeID)
		{
			RequestSearch objRequestSearch = new RequestSearch();
			objRequestSearch.Id = Id;
			objRequestSearch.requestNumber = requestNumber;
			objRequestSearch.totalQuantity = totalQuantity;
			objRequestSearch.PDDFrom = PDDFrom;
			objRequestSearch.PDDTo = PDDTo;
			objRequestSearch.customerID = customerID;
			objRequestSearch.creationDateFrom = creationDateFrom;
			objRequestSearch.creationDateTo = creationDateTo;
			objRequestSearch.creationUserID = creationUserID;
			objRequestSearch.approvalDateFrom = approvalDateFrom;
			objRequestSearch.approvalDateTo = approvalDateTo;
			objRequestSearch.approvalUserID = approvalUserID;
			objRequestSearch.receiveDateFrom = receiveDateFrom;
			objRequestSearch.receiveDateTo = receiveDateTo;
			objRequestSearch.receiveUserID = receiveUserID;
			objRequestSearch.rejectionDateFrom = rejectionDateFrom;
			objRequestSearch.rejectionDateTo = rejectionDateTo;
			objRequestSearch.rejectionUserID = rejectionUserID;
			objRequestSearch.rejectionReasonID = rejectionReasonID;
			objRequestSearch.requestTypeID = requestTypeID;
			objRequestSearch.requestStatusID = requestStatusID;
			objRequestSearch.requestCalssID = requestCalssID;
			objRequestSearch.requestPriorityID = requestPriorityID;
			objRequestSearch.cardTypeID = cardTypeID;
			return objRequestSearch;
		}
		#endregion

		#region RequestSearchList
		/// <summary>
		/// Property RequestSearchList Represent Rows Collection of RequestSearch.
		/// </summary>
		public RequestSearchList RequestSearchList
		{
			get
			{
				return (RequestSearchList)base.BaseCommonList;
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
	
		#region requestNumber
		/// <summary>
		/// Property requestNumber Represent Column requestNumber in CodeGeneratingInfo Table
		/// </summary>
		public System.String requestNumber
		{
			get
			{
				return _requestNumber;
			}
			set
			{
				_onrequestNumberChanging(value);
				_onChangingValue("requestNumber",value,IsrequestNumberAllowNull);
				_requestNumber = value;
				_onChangedValue("requestNumber");
				_onrequestNumberChanged();
			}
		}
		private System.String _requestNumber;
		partial void _onrequestNumberChanging(System.String value);
		partial void _onrequestNumberChanged();
		/// <summary>
		/// get value of requestNumber Property is Allow Null or not
		/// </summary>
		public System.Boolean IsrequestNumberAllowNull
		{
			get
			{
				return false;
			}
		}
		#endregion
	
		#region totalQuantity
		/// <summary>
		/// Property totalQuantity Represent Column totalQuantity in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? totalQuantity
		{
			get
			{
				return _totalQuantity;
			}
			set
			{
				_ontotalQuantityChanging(value);
				_onChangingValue("totalQuantity",value,IstotalQuantityAllowNull);
				_totalQuantity = value;
				_onChangedValue("totalQuantity");
				_ontotalQuantityChanged();
			}
		}
		private System.Int32? _totalQuantity;
		partial void _ontotalQuantityChanging(System.Int32? value);
		partial void _ontotalQuantityChanged();
		/// <summary>
		/// get value of totalQuantity Property is Allow Null or not
		/// </summary>
		public System.Boolean IstotalQuantityAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region PDDFrom
		/// <summary>
		/// Property PDDFrom Represent Column PDDFrom in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? PDDFrom
		{
			get
			{
				return _PDDFrom;
			}
			set
			{
				_onPDDFromChanging(value);
				_onChangingValue("PDDFrom",value,IsPDDFromAllowNull);
				_PDDFrom = value;
				_onChangedValue("PDDFrom");
				_onPDDFromChanged();
			}
		}
		private System.DateTime? _PDDFrom;
		partial void _onPDDFromChanging(System.DateTime? value);
		partial void _onPDDFromChanged();
		/// <summary>
		/// get value of PDDFrom Property is Allow Null or not
		/// </summary>
		public System.Boolean IsPDDFromAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region PDDTo
		/// <summary>
		/// Property PDDTo Represent Column PDDTo in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? PDDTo
		{
			get
			{
				return _PDDTo;
			}
			set
			{
				_onPDDToChanging(value);
				_onChangingValue("PDDTo",value,IsPDDToAllowNull);
				_PDDTo = value;
				_onChangedValue("PDDTo");
				_onPDDToChanged();
			}
		}
		private System.DateTime? _PDDTo;
		partial void _onPDDToChanging(System.DateTime? value);
		partial void _onPDDToChanged();
		/// <summary>
		/// get value of PDDTo Property is Allow Null or not
		/// </summary>
		public System.Boolean IsPDDToAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region customerID
		/// <summary>
		/// Property customerID Represent Column customerID in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? customerID
		{
			get
			{
				return _customerID;
			}
			set
			{
				_oncustomerIDChanging(value);
				_onChangingValue("customerID",value,IscustomerIDAllowNull);
				_customerID = value;
				_onChangedValue("customerID");
				_oncustomerIDChanged();
			}
		}
		private System.Int32? _customerID;
		partial void _oncustomerIDChanging(System.Int32? value);
		partial void _oncustomerIDChanged();
		/// <summary>
		/// get value of customerID Property is Allow Null or not
		/// </summary>
		public System.Boolean IscustomerIDAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region creationDateFrom
		/// <summary>
		/// Property creationDateFrom Represent Column creationDateFrom in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? creationDateFrom
		{
			get
			{
				return _creationDateFrom;
			}
			set
			{
				_oncreationDateFromChanging(value);
				_onChangingValue("creationDateFrom",value,IscreationDateFromAllowNull);
				_creationDateFrom = value;
				_onChangedValue("creationDateFrom");
				_oncreationDateFromChanged();
			}
		}
		private System.DateTime? _creationDateFrom;
		partial void _oncreationDateFromChanging(System.DateTime? value);
		partial void _oncreationDateFromChanged();
		/// <summary>
		/// get value of creationDateFrom Property is Allow Null or not
		/// </summary>
		public System.Boolean IscreationDateFromAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region creationDateTo
		/// <summary>
		/// Property creationDateTo Represent Column creationDateTo in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? creationDateTo
		{
			get
			{
				return _creationDateTo;
			}
			set
			{
				_oncreationDateToChanging(value);
				_onChangingValue("creationDateTo",value,IscreationDateToAllowNull);
				_creationDateTo = value;
				_onChangedValue("creationDateTo");
				_oncreationDateToChanged();
			}
		}
		private System.DateTime? _creationDateTo;
		partial void _oncreationDateToChanging(System.DateTime? value);
		partial void _oncreationDateToChanged();
		/// <summary>
		/// get value of creationDateTo Property is Allow Null or not
		/// </summary>
		public System.Boolean IscreationDateToAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region creationUserID
		/// <summary>
		/// Property creationUserID Represent Column creationUserID in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? creationUserID
		{
			get
			{
				return _creationUserID;
			}
			set
			{
				_oncreationUserIDChanging(value);
				_onChangingValue("creationUserID",value,IscreationUserIDAllowNull);
				_creationUserID = value;
				_onChangedValue("creationUserID");
				_oncreationUserIDChanged();
			}
		}
		private System.Int32? _creationUserID;
		partial void _oncreationUserIDChanging(System.Int32? value);
		partial void _oncreationUserIDChanged();
		/// <summary>
		/// get value of creationUserID Property is Allow Null or not
		/// </summary>
		public System.Boolean IscreationUserIDAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region approvalDateFrom
		/// <summary>
		/// Property approvalDateFrom Represent Column approvalDateFrom in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? approvalDateFrom
		{
			get
			{
				return _approvalDateFrom;
			}
			set
			{
				_onapprovalDateFromChanging(value);
				_onChangingValue("approvalDateFrom",value,IsapprovalDateFromAllowNull);
				_approvalDateFrom = value;
				_onChangedValue("approvalDateFrom");
				_onapprovalDateFromChanged();
			}
		}
		private System.DateTime? _approvalDateFrom;
		partial void _onapprovalDateFromChanging(System.DateTime? value);
		partial void _onapprovalDateFromChanged();
		/// <summary>
		/// get value of approvalDateFrom Property is Allow Null or not
		/// </summary>
		public System.Boolean IsapprovalDateFromAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region approvalDateTo
		/// <summary>
		/// Property approvalDateTo Represent Column approvalDateTo in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? approvalDateTo
		{
			get
			{
				return _approvalDateTo;
			}
			set
			{
				_onapprovalDateToChanging(value);
				_onChangingValue("approvalDateTo",value,IsapprovalDateToAllowNull);
				_approvalDateTo = value;
				_onChangedValue("approvalDateTo");
				_onapprovalDateToChanged();
			}
		}
		private System.DateTime? _approvalDateTo;
		partial void _onapprovalDateToChanging(System.DateTime? value);
		partial void _onapprovalDateToChanged();
		/// <summary>
		/// get value of approvalDateTo Property is Allow Null or not
		/// </summary>
		public System.Boolean IsapprovalDateToAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region approvalUserID
		/// <summary>
		/// Property approvalUserID Represent Column approvalUserID in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? approvalUserID
		{
			get
			{
				return _approvalUserID;
			}
			set
			{
				_onapprovalUserIDChanging(value);
				_onChangingValue("approvalUserID",value,IsapprovalUserIDAllowNull);
				_approvalUserID = value;
				_onChangedValue("approvalUserID");
				_onapprovalUserIDChanged();
			}
		}
		private System.Int32? _approvalUserID;
		partial void _onapprovalUserIDChanging(System.Int32? value);
		partial void _onapprovalUserIDChanged();
		/// <summary>
		/// get value of approvalUserID Property is Allow Null or not
		/// </summary>
		public System.Boolean IsapprovalUserIDAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region receiveDateFrom
		/// <summary>
		/// Property receiveDateFrom Represent Column receiveDateFrom in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? receiveDateFrom
		{
			get
			{
				return _receiveDateFrom;
			}
			set
			{
				_onreceiveDateFromChanging(value);
				_onChangingValue("receiveDateFrom",value,IsreceiveDateFromAllowNull);
				_receiveDateFrom = value;
				_onChangedValue("receiveDateFrom");
				_onreceiveDateFromChanged();
			}
		}
		private System.DateTime? _receiveDateFrom;
		partial void _onreceiveDateFromChanging(System.DateTime? value);
		partial void _onreceiveDateFromChanged();
		/// <summary>
		/// get value of receiveDateFrom Property is Allow Null or not
		/// </summary>
		public System.Boolean IsreceiveDateFromAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region receiveDateTo
		/// <summary>
		/// Property receiveDateTo Represent Column receiveDateTo in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? receiveDateTo
		{
			get
			{
				return _receiveDateTo;
			}
			set
			{
				_onreceiveDateToChanging(value);
				_onChangingValue("receiveDateTo",value,IsreceiveDateToAllowNull);
				_receiveDateTo = value;
				_onChangedValue("receiveDateTo");
				_onreceiveDateToChanged();
			}
		}
		private System.DateTime? _receiveDateTo;
		partial void _onreceiveDateToChanging(System.DateTime? value);
		partial void _onreceiveDateToChanged();
		/// <summary>
		/// get value of receiveDateTo Property is Allow Null or not
		/// </summary>
		public System.Boolean IsreceiveDateToAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region receiveUserID
		/// <summary>
		/// Property receiveUserID Represent Column receiveUserID in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? receiveUserID
		{
			get
			{
				return _receiveUserID;
			}
			set
			{
				_onreceiveUserIDChanging(value);
				_onChangingValue("receiveUserID",value,IsreceiveUserIDAllowNull);
				_receiveUserID = value;
				_onChangedValue("receiveUserID");
				_onreceiveUserIDChanged();
			}
		}
		private System.Int32? _receiveUserID;
		partial void _onreceiveUserIDChanging(System.Int32? value);
		partial void _onreceiveUserIDChanged();
		/// <summary>
		/// get value of receiveUserID Property is Allow Null or not
		/// </summary>
		public System.Boolean IsreceiveUserIDAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region rejectionDateFrom
		/// <summary>
		/// Property rejectionDateFrom Represent Column rejectionDateFrom in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? rejectionDateFrom
		{
			get
			{
				return _rejectionDateFrom;
			}
			set
			{
				_onrejectionDateFromChanging(value);
				_onChangingValue("rejectionDateFrom",value,IsrejectionDateFromAllowNull);
				_rejectionDateFrom = value;
				_onChangedValue("rejectionDateFrom");
				_onrejectionDateFromChanged();
			}
		}
		private System.DateTime? _rejectionDateFrom;
		partial void _onrejectionDateFromChanging(System.DateTime? value);
		partial void _onrejectionDateFromChanged();
		/// <summary>
		/// get value of rejectionDateFrom Property is Allow Null or not
		/// </summary>
		public System.Boolean IsrejectionDateFromAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region rejectionDateTo
		/// <summary>
		/// Property rejectionDateTo Represent Column rejectionDateTo in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? rejectionDateTo
		{
			get
			{
				return _rejectionDateTo;
			}
			set
			{
				_onrejectionDateToChanging(value);
				_onChangingValue("rejectionDateTo",value,IsrejectionDateToAllowNull);
				_rejectionDateTo = value;
				_onChangedValue("rejectionDateTo");
				_onrejectionDateToChanged();
			}
		}
		private System.DateTime? _rejectionDateTo;
		partial void _onrejectionDateToChanging(System.DateTime? value);
		partial void _onrejectionDateToChanged();
		/// <summary>
		/// get value of rejectionDateTo Property is Allow Null or not
		/// </summary>
		public System.Boolean IsrejectionDateToAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region rejectionUserID
		/// <summary>
		/// Property rejectionUserID Represent Column rejectionUserID in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? rejectionUserID
		{
			get
			{
				return _rejectionUserID;
			}
			set
			{
				_onrejectionUserIDChanging(value);
				_onChangingValue("rejectionUserID",value,IsrejectionUserIDAllowNull);
				_rejectionUserID = value;
				_onChangedValue("rejectionUserID");
				_onrejectionUserIDChanged();
			}
		}
		private System.Int32? _rejectionUserID;
		partial void _onrejectionUserIDChanging(System.Int32? value);
		partial void _onrejectionUserIDChanged();
		/// <summary>
		/// get value of rejectionUserID Property is Allow Null or not
		/// </summary>
		public System.Boolean IsrejectionUserIDAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region rejectionReasonID
		/// <summary>
		/// Property rejectionReasonID Represent Column rejectionReasonID in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? rejectionReasonID
		{
			get
			{
				return _rejectionReasonID;
			}
			set
			{
				_onrejectionReasonIDChanging(value);
				_onChangingValue("rejectionReasonID",value,IsrejectionReasonIDAllowNull);
				_rejectionReasonID = value;
				_onChangedValue("rejectionReasonID");
				_onrejectionReasonIDChanged();
			}
		}
		private System.Int32? _rejectionReasonID;
		partial void _onrejectionReasonIDChanging(System.Int32? value);
		partial void _onrejectionReasonIDChanged();
		/// <summary>
		/// get value of rejectionReasonID Property is Allow Null or not
		/// </summary>
		public System.Boolean IsrejectionReasonIDAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region requestTypeID
		/// <summary>
		/// Property requestTypeID Represent Column requestTypeID in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? requestTypeID
		{
			get
			{
				return _requestTypeID;
			}
			set
			{
				_onrequestTypeIDChanging(value);
				_onChangingValue("requestTypeID",value,IsrequestTypeIDAllowNull);
				_requestTypeID = value;
				_onChangedValue("requestTypeID");
				_onrequestTypeIDChanged();
			}
		}
		private System.Int32? _requestTypeID;
		partial void _onrequestTypeIDChanging(System.Int32? value);
		partial void _onrequestTypeIDChanged();
		/// <summary>
		/// get value of requestTypeID Property is Allow Null or not
		/// </summary>
		public System.Boolean IsrequestTypeIDAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region requestStatusID
		/// <summary>
		/// Property requestStatusID Represent Column requestStatusID in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? requestStatusID
		{
			get
			{
				return _requestStatusID;
			}
			set
			{
				_onrequestStatusIDChanging(value);
				_onChangingValue("requestStatusID",value,IsrequestStatusIDAllowNull);
				_requestStatusID = value;
				_onChangedValue("requestStatusID");
				_onrequestStatusIDChanged();
			}
		}
		private System.Int32? _requestStatusID;
		partial void _onrequestStatusIDChanging(System.Int32? value);
		partial void _onrequestStatusIDChanged();
		/// <summary>
		/// get value of requestStatusID Property is Allow Null or not
		/// </summary>
		public System.Boolean IsrequestStatusIDAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region requestCalssID
		/// <summary>
		/// Property requestCalssID Represent Column requestCalssID in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? requestCalssID
		{
			get
			{
				return _requestCalssID;
			}
			set
			{
				_onrequestCalssIDChanging(value);
				_onChangingValue("requestCalssID",value,IsrequestCalssIDAllowNull);
				_requestCalssID = value;
				_onChangedValue("requestCalssID");
				_onrequestCalssIDChanged();
			}
		}
		private System.Int32? _requestCalssID;
		partial void _onrequestCalssIDChanging(System.Int32? value);
		partial void _onrequestCalssIDChanged();
		/// <summary>
		/// get value of requestCalssID Property is Allow Null or not
		/// </summary>
		public System.Boolean IsrequestCalssIDAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region requestPriorityID
		/// <summary>
		/// Property requestPriorityID Represent Column requestPriorityID in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? requestPriorityID
		{
			get
			{
				return _requestPriorityID;
			}
			set
			{
				_onrequestPriorityIDChanging(value);
				_onChangingValue("requestPriorityID",value,IsrequestPriorityIDAllowNull);
				_requestPriorityID = value;
				_onChangedValue("requestPriorityID");
				_onrequestPriorityIDChanged();
			}
		}
		private System.Int32? _requestPriorityID;
		partial void _onrequestPriorityIDChanging(System.Int32? value);
		partial void _onrequestPriorityIDChanged();
		/// <summary>
		/// get value of requestPriorityID Property is Allow Null or not
		/// </summary>
		public System.Boolean IsrequestPriorityIDAllowNull
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
	
	}
}

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
	// The RequestList Class.
	[Serializable]
	public partial class RequestList : ApplicationBlocks.Layers.BaseCommonList<Request>
	{
		#region Constructor
		/// <summary>
		/// Constructor To Create a new Request object.
		/// </summary>
		public RequestList():base()
		{
		}
		/// <summary>
		/// Constructor To Create a new Request object.
		/// </summary>
		/// <param name="collection">IThe collection whose elements are copied to the new list.</param>
		public RequestList(IEnumerable<Request> collection):base(collection)
		{
		}
		/// <summary>
		/// Constructor To Create a new Request object.
		/// </summary>
		/// <param name="capacity">The number of elements that the new list can initially store.</param>
		public RequestList(int capacity):base(capacity)
		{
		}
		#endregion

	}
	
	// Summary:
	// The Request Class.
	[Serializable]
	public partial class Request : ApplicationBlocks.Layers.BaseCommon<Request>
	{

		#region Factor Method
		/// <summary>
		/// Factor Method To Create a new Request object.
		/// </summary>
		/// <param name="Id">Initial value of Id.</param>
		/// <param name="requestNumber">Initial value of requestNumber.</param>
		/// <param name="totalQuantity">Initial value of totalQuantity.</param>
		/// <param name="PDD">Initial value of PDD.</param>
		/// <param name="customerID">Initial value of customerID.</param>
		/// <param name="creationDate">Initial value of creationDate.</param>
		/// <param name="creationUserID">Initial value of creationUserID.</param>
		/// <param name="approvalDate">Initial value of approvalDate.</param>
		/// <param name="approvalUserID">Initial value of approvalUserID.</param>
		/// <param name="receiveDate">Initial value of receiveDate.</param>
		/// <param name="receiveUserID">Initial value of receiveUserID.</param>
		/// <param name="rejectionDate">Initial value of rejectionDate.</param>
		/// <param name="rejectionUserID">Initial value of rejectionUserID.</param>
		/// <param name="rejectionReasonID">Initial value of rejectionReasonID.</param>
		/// <param name="requestTypeID">Initial value of requestTypeID.</param>
		/// <param name="requestStatusID">Initial value of requestStatusID.</param>
		/// <param name="requestCalssID">Initial value of requestCalssID.</param>
		/// <param name="requestPriorityID">Initial value of requestPriorityID.</param>
		/// <returns>Return New Request Object</returns>
		public static Request CreateRequest(
											System.Int32 Id, System.String requestNumber, System.Int32? totalQuantity, System.DateTime? PDD, System.Int32? customerID
											,System.DateTime? creationDate, System.Int32? creationUserID, System.DateTime? approvalDate, System.Int32? approvalUserID, System.DateTime? receiveDate
											,System.Int32? receiveUserID, System.DateTime? rejectionDate, System.Int32? rejectionUserID, System.Int32? rejectionReasonID, System.Int32? requestTypeID
											,System.Int32? requestStatusID, System.Int32? requestCalssID, System.Int32? requestPriorityID)
		{
			Request objRequest = new Request();
			objRequest.Id = Id;
			objRequest.requestNumber = requestNumber;
			objRequest.totalQuantity = totalQuantity;
			objRequest.PDD = PDD;
			objRequest.customerID = customerID;
			objRequest.creationDate = creationDate;
			objRequest.creationUserID = creationUserID;
			objRequest.approvalDate = approvalDate;
			objRequest.approvalUserID = approvalUserID;
			objRequest.receiveDate = receiveDate;
			objRequest.receiveUserID = receiveUserID;
			objRequest.rejectionDate = rejectionDate;
			objRequest.rejectionUserID = rejectionUserID;
			objRequest.rejectionReasonID = rejectionReasonID;
			objRequest.requestTypeID = requestTypeID;
			objRequest.requestStatusID = requestStatusID;
			objRequest.requestCalssID = requestCalssID;
			objRequest.requestPriorityID = requestPriorityID;
			return objRequest;
		}
		#endregion

		#region RequestList
		/// <summary>
		/// Property RequestList Represent Rows Collection of Request.
		/// </summary>
		public RequestList RequestList
		{
			get
			{
				return (RequestList)base.BaseCommonList;
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
	
		#region PDD
		/// <summary>
		/// Property PDD Represent Column PDD in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? PDD
		{
			get
			{
				return _PDD;
			}
			set
			{
				_onPDDChanging(value);
				_onChangingValue("PDD",value,IsPDDAllowNull);
				_PDD = value;
				_onChangedValue("PDD");
				_onPDDChanged();
			}
		}
		private System.DateTime? _PDD;
		partial void _onPDDChanging(System.DateTime? value);
		partial void _onPDDChanged();
		/// <summary>
		/// get value of PDD Property is Allow Null or not
		/// </summary>
		public System.Boolean IsPDDAllowNull
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
	
		#region creationDate
		/// <summary>
		/// Property creationDate Represent Column creationDate in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? creationDate
		{
			get
			{
				return _creationDate;
			}
			set
			{
				_oncreationDateChanging(value);
				_onChangingValue("creationDate",value,IscreationDateAllowNull);
				_creationDate = value;
				_onChangedValue("creationDate");
				_oncreationDateChanged();
			}
		}
		private System.DateTime? _creationDate;
		partial void _oncreationDateChanging(System.DateTime? value);
		partial void _oncreationDateChanged();
		/// <summary>
		/// get value of creationDate Property is Allow Null or not
		/// </summary>
		public System.Boolean IscreationDateAllowNull
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
	
		#region approvalDate
		/// <summary>
		/// Property approvalDate Represent Column approvalDate in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? approvalDate
		{
			get
			{
				return _approvalDate;
			}
			set
			{
				_onapprovalDateChanging(value);
				_onChangingValue("approvalDate",value,IsapprovalDateAllowNull);
				_approvalDate = value;
				_onChangedValue("approvalDate");
				_onapprovalDateChanged();
			}
		}
		private System.DateTime? _approvalDate;
		partial void _onapprovalDateChanging(System.DateTime? value);
		partial void _onapprovalDateChanged();
		/// <summary>
		/// get value of approvalDate Property is Allow Null or not
		/// </summary>
		public System.Boolean IsapprovalDateAllowNull
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
	
		#region receiveDate
		/// <summary>
		/// Property receiveDate Represent Column receiveDate in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? receiveDate
		{
			get
			{
				return _receiveDate;
			}
			set
			{
				_onreceiveDateChanging(value);
				_onChangingValue("receiveDate",value,IsreceiveDateAllowNull);
				_receiveDate = value;
				_onChangedValue("receiveDate");
				_onreceiveDateChanged();
			}
		}
		private System.DateTime? _receiveDate;
		partial void _onreceiveDateChanging(System.DateTime? value);
		partial void _onreceiveDateChanged();
		/// <summary>
		/// get value of receiveDate Property is Allow Null or not
		/// </summary>
		public System.Boolean IsreceiveDateAllowNull
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
	
		#region rejectionDate
		/// <summary>
		/// Property rejectionDate Represent Column rejectionDate in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? rejectionDate
		{
			get
			{
				return _rejectionDate;
			}
			set
			{
				_onrejectionDateChanging(value);
				_onChangingValue("rejectionDate",value,IsrejectionDateAllowNull);
				_rejectionDate = value;
				_onChangedValue("rejectionDate");
				_onrejectionDateChanged();
			}
		}
		private System.DateTime? _rejectionDate;
		partial void _onrejectionDateChanging(System.DateTime? value);
		partial void _onrejectionDateChanged();
		/// <summary>
		/// get value of rejectionDate Property is Allow Null or not
		/// </summary>
		public System.Boolean IsrejectionDateAllowNull
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
	
		#region Relation Objects
		/// <summary>
		/// Property UserList Represent FK_ApprovalUserID_Request Relation
		/// ParentTable Request ParentColumn approvalUserID ,ReferencedTable User ReferencedColumn Id
		/// </summary>
		public UserList UserList
		{
			get
			{
				return _UserList;
			}
			set
			{
				_onUserListChanging(value);
				_UserList = value;
				_onUserListChanged();
			}
		}
		private UserList _UserList;
		partial void _onUserListChanging(UserList value);
		partial void _onUserListChanged();
	
		/// <summary>
		/// Property UserList1 Represent FK_CreationUserID_Request Relation
		/// ParentTable Request ParentColumn creationUserID ,ReferencedTable User ReferencedColumn Id
		/// </summary>
		public UserList UserList1
		{
			get
			{
				return _UserList1;
			}
			set
			{
				_onUserList1Changing(value);
				_UserList1 = value;
				_onUserList1Changed();
			}
		}
		private UserList _UserList1;
		partial void _onUserList1Changing(UserList value);
		partial void _onUserList1Changed();
	
		/// <summary>
		/// Property CustomerList Represent FK_CustomerID_Request Relation
		/// ParentTable Request ParentColumn customerID ,ReferencedTable Customer ReferencedColumn Id
		/// </summary>
		public CustomerList CustomerList
		{
			get
			{
				return _CustomerList;
			}
			set
			{
				_onCustomerListChanging(value);
				_CustomerList = value;
				_onCustomerListChanged();
			}
		}
		private CustomerList _CustomerList;
		partial void _onCustomerListChanging(CustomerList value);
		partial void _onCustomerListChanged();
	
		/// <summary>
		/// Property UserList2 Represent FK_ReceiveUserID_Request Relation
		/// ParentTable Request ParentColumn receiveUserID ,ReferencedTable User ReferencedColumn Id
		/// </summary>
		public UserList UserList2
		{
			get
			{
				return _UserList2;
			}
			set
			{
				_onUserList2Changing(value);
				_UserList2 = value;
				_onUserList2Changed();
			}
		}
		private UserList _UserList2;
		partial void _onUserList2Changing(UserList value);
		partial void _onUserList2Changed();
	
		/// <summary>
		/// Property RejectReasonList Represent FK_RejectionReasonID_Request Relation
		/// ParentTable Request ParentColumn rejectionReasonID ,ReferencedTable RejectReason ReferencedColumn Id
		/// </summary>
		public RejectReasonList RejectReasonList
		{
			get
			{
				return _RejectReasonList;
			}
			set
			{
				_onRejectReasonListChanging(value);
				_RejectReasonList = value;
				_onRejectReasonListChanged();
			}
		}
		private RejectReasonList _RejectReasonList;
		partial void _onRejectReasonListChanging(RejectReasonList value);
		partial void _onRejectReasonListChanged();
	
		/// <summary>
		/// Property UserList3 Represent FK_RejectionUserID_Request Relation
		/// ParentTable Request ParentColumn rejectionUserID ,ReferencedTable User ReferencedColumn Id
		/// </summary>
		public UserList UserList3
		{
			get
			{
				return _UserList3;
			}
			set
			{
				_onUserList3Changing(value);
				_UserList3 = value;
				_onUserList3Changed();
			}
		}
		private UserList _UserList3;
		partial void _onUserList3Changing(UserList value);
		partial void _onUserList3Changed();
	
		/// <summary>
		/// Property RequestClassList Represent FK_RequestClassID_Request Relation
		/// ParentTable Request ParentColumn requestCalssID ,ReferencedTable RequestClass ReferencedColumn Id
		/// </summary>
		public RequestClassList RequestClassList
		{
			get
			{
				return _RequestClassList;
			}
			set
			{
				_onRequestClassListChanging(value);
				_RequestClassList = value;
				_onRequestClassListChanged();
			}
		}
		private RequestClassList _RequestClassList;
		partial void _onRequestClassListChanging(RequestClassList value);
		partial void _onRequestClassListChanged();
	
		/// <summary>
		/// Property RequestDetailList Represent FK_RequestID_RequestDetail Relation
		/// ParentTable RequestDetail ParentColumn requestID ,ReferencedTable Request ReferencedColumn Id
		/// </summary>
		public RequestDetailList RequestDetailList
		{
			get
			{
				return _RequestDetailList;
			}
			set
			{
				_onRequestDetailListChanging(value);
				_RequestDetailList = value;
				_onRequestDetailListChanged();
			}
		}
		private RequestDetailList _RequestDetailList;
		partial void _onRequestDetailListChanging(RequestDetailList value);
		partial void _onRequestDetailListChanged();
	
		/// <summary>
		/// Property RequestPriorityList Represent FK_RequestPriorityID_Request Relation
		/// ParentTable Request ParentColumn requestPriorityID ,ReferencedTable RequestPriority ReferencedColumn Id
		/// </summary>
		public RequestPriorityList RequestPriorityList
		{
			get
			{
				return _RequestPriorityList;
			}
			set
			{
				_onRequestPriorityListChanging(value);
				_RequestPriorityList = value;
				_onRequestPriorityListChanged();
			}
		}
		private RequestPriorityList _RequestPriorityList;
		partial void _onRequestPriorityListChanging(RequestPriorityList value);
		partial void _onRequestPriorityListChanged();
	
		/// <summary>
		/// Property RequestStatusList Represent FK_RequestStatusID_Request Relation
		/// ParentTable Request ParentColumn requestStatusID ,ReferencedTable RequestStatus ReferencedColumn Id
		/// </summary>
		public RequestStatusList RequestStatusList
		{
			get
			{
				return _RequestStatusList;
			}
			set
			{
				_onRequestStatusListChanging(value);
				_RequestStatusList = value;
				_onRequestStatusListChanged();
			}
		}
		private RequestStatusList _RequestStatusList;
		partial void _onRequestStatusListChanging(RequestStatusList value);
		partial void _onRequestStatusListChanged();
	
		/// <summary>
		/// Property RequestTypeList Represent FK_RequestTypeID_Request Relation
		/// ParentTable Request ParentColumn requestTypeID ,ReferencedTable RequestType ReferencedColumn Id
		/// </summary>
		public RequestTypeList RequestTypeList
		{
			get
			{
				return _RequestTypeList;
			}
			set
			{
				_onRequestTypeListChanging(value);
				_RequestTypeList = value;
				_onRequestTypeListChanged();
			}
		}
		private RequestTypeList _RequestTypeList;
		partial void _onRequestTypeListChanging(RequestTypeList value);
		partial void _onRequestTypeListChanged();
		#endregion
	}
}

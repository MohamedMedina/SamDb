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
	// The GroupFunctionList Class.
	[Serializable]
	public partial class GroupFunctionList : ApplicationBlocks.Layers.BaseCommonList<GroupFunction>
	{
		#region Constructor
		/// <summary>
		/// Constructor To Create a new GroupFunction object.
		/// </summary>
		public GroupFunctionList():base()
		{
		}
		/// <summary>
		/// Constructor To Create a new GroupFunction object.
		/// </summary>
		/// <param name="collection">IThe collection whose elements are copied to the new list.</param>
		public GroupFunctionList(IEnumerable<GroupFunction> collection):base(collection)
		{
		}
		/// <summary>
		/// Constructor To Create a new GroupFunction object.
		/// </summary>
		/// <param name="capacity">The number of elements that the new list can initially store.</param>
		public GroupFunctionList(int capacity):base(capacity)
		{
		}
		#endregion

	}
	
	// Summary:
	// The GroupFunction Class.
	[Serializable]
	public partial class GroupFunction : ApplicationBlocks.Layers.BaseCommon<GroupFunction>
	{

		#region Factor Method
		/// <summary>
		/// Factor Method To Create a new GroupFunction object.
		/// </summary>
		/// <param name="Id">Initial value of Id.</param>
		/// <param name="functionId">Initial value of functionId.</param>
		/// <param name="groupId">Initial value of groupId.</param>
		/// <param name="status">Initial value of status.</param>
		/// <returns>Return New GroupFunction Object</returns>
		public static GroupFunction CreateGroupFunction(
											System.Int32 Id, System.Int32? functionId, System.Int32? groupId, System.Boolean? status)
		{
			GroupFunction objGroupFunction = new GroupFunction();
			objGroupFunction.Id = Id;
			objGroupFunction.functionId = functionId;
			objGroupFunction.groupId = groupId;
			objGroupFunction.status = status;
			return objGroupFunction;
		}
		#endregion

		#region GroupFunctionList
		/// <summary>
		/// Property GroupFunctionList Represent Rows Collection of GroupFunction.
		/// </summary>
		public GroupFunctionList GroupFunctionList
		{
			get
			{
				return (GroupFunctionList)base.BaseCommonList;
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
	
		#region functionId
		/// <summary>
		/// Property functionId Represent Column functionId in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? functionId
		{
			get
			{
				return _functionId;
			}
			set
			{
				_onfunctionIdChanging(value);
				_onChangingValue("functionId",value,IsfunctionIdAllowNull);
				_functionId = value;
				_onChangedValue("functionId");
				_onfunctionIdChanged();
			}
		}
		private System.Int32? _functionId;
		partial void _onfunctionIdChanging(System.Int32? value);
		partial void _onfunctionIdChanged();
		/// <summary>
		/// get value of functionId Property is Allow Null or not
		/// </summary>
		public System.Boolean IsfunctionIdAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region groupId
		/// <summary>
		/// Property groupId Represent Column groupId in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32? groupId
		{
			get
			{
				return _groupId;
			}
			set
			{
				_ongroupIdChanging(value);
				_onChangingValue("groupId",value,IsgroupIdAllowNull);
				_groupId = value;
				_onChangedValue("groupId");
				_ongroupIdChanged();
			}
		}
		private System.Int32? _groupId;
		partial void _ongroupIdChanging(System.Int32? value);
		partial void _ongroupIdChanged();
		/// <summary>
		/// get value of groupId Property is Allow Null or not
		/// </summary>
		public System.Boolean IsgroupIdAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region status
		/// <summary>
		/// Property status Represent Column status in CodeGeneratingInfo Table
		/// </summary>
		public System.Boolean? status
		{
			get
			{
				return _status;
			}
			set
			{
				_onstatusChanging(value);
				_onChangingValue("status",value,IsstatusAllowNull);
				_status = value;
				_onChangedValue("status");
				_onstatusChanged();
			}
		}
		private System.Boolean? _status;
		partial void _onstatusChanging(System.Boolean? value);
		partial void _onstatusChanged();
		/// <summary>
		/// get value of status Property is Allow Null or not
		/// </summary>
		public System.Boolean IsstatusAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region Relation Objects
		/// <summary>
		/// Property FunctionList Represent FK_FunctionID_GroupFunction Relation
		/// ParentTable GroupFunction ParentColumn functionId ,ReferencedTable Function ReferencedColumn Id
		/// </summary>
		public FunctionList FunctionList
		{
			get
			{
				return _FunctionList;
			}
			set
			{
				_onFunctionListChanging(value);
				_FunctionList = value;
				_onFunctionListChanged();
			}
		}
		private FunctionList _FunctionList;
		partial void _onFunctionListChanging(FunctionList value);
		partial void _onFunctionListChanged();
	
		/// <summary>
		/// Property GroupList Represent FK_GroupID_GroupFunction Relation
		/// ParentTable GroupFunction ParentColumn groupId ,ReferencedTable Group ReferencedColumn Id
		/// </summary>
		public GroupList GroupList
		{
			get
			{
				return _GroupList;
			}
			set
			{
				_onGroupListChanging(value);
				_GroupList = value;
				_onGroupListChanged();
			}
		}
		private GroupList _GroupList;
		partial void _onGroupListChanging(GroupList value);
		partial void _onGroupListChanged();
		#endregion
	}
}

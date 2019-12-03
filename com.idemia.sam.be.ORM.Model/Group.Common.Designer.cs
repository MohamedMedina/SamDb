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
	// The GroupList Class.
	[Serializable]
	public partial class GroupList : ApplicationBlocks.Layers.BaseCommonList<Group>
	{
		#region Constructor
		/// <summary>
		/// Constructor To Create a new Group object.
		/// </summary>
		public GroupList():base()
		{
		}
		/// <summary>
		/// Constructor To Create a new Group object.
		/// </summary>
		/// <param name="collection">IThe collection whose elements are copied to the new list.</param>
		public GroupList(IEnumerable<Group> collection):base(collection)
		{
		}
		/// <summary>
		/// Constructor To Create a new Group object.
		/// </summary>
		/// <param name="capacity">The number of elements that the new list can initially store.</param>
		public GroupList(int capacity):base(capacity)
		{
		}
		#endregion

	}
	
	// Summary:
	// The Group Class.
	[Serializable]
	public partial class Group : ApplicationBlocks.Layers.BaseCommon<Group>
	{

		#region Factor Method
		/// <summary>
		/// Factor Method To Create a new Group object.
		/// </summary>
		/// <param name="Id">Initial value of Id.</param>
		/// <param name="name">Initial value of name.</param>
		/// <param name="status">Initial value of status.</param>
		/// <returns>Return New Group Object</returns>
		public static Group CreateGroup(
											System.Int32 Id, System.String name, System.Boolean? status)
		{
			Group objGroup = new Group();
			objGroup.Id = Id;
			objGroup.name = name;
			objGroup.status = status;
			return objGroup;
		}
		#endregion

		#region GroupList
		/// <summary>
		/// Property GroupList Represent Rows Collection of Group.
		/// </summary>
		public GroupList GroupList
		{
			get
			{
				return (GroupList)base.BaseCommonList;
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
		/// Property GroupFunctionList Represent FK_GroupID_GroupFunction Relation
		/// ParentTable GroupFunction ParentColumn groupId ,ReferencedTable Group ReferencedColumn Id
		/// </summary>
		public GroupFunctionList GroupFunctionList
		{
			get
			{
				return _GroupFunctionList;
			}
			set
			{
				_onGroupFunctionListChanging(value);
				_GroupFunctionList = value;
				_onGroupFunctionListChanged();
			}
		}
		private GroupFunctionList _GroupFunctionList;
		partial void _onGroupFunctionListChanging(GroupFunctionList value);
		partial void _onGroupFunctionListChanged();
	
		/// <summary>
		/// Property UserGroupList Represent FK_GroupID_UserGroup Relation
		/// ParentTable UserGroup ParentColumn groupId ,ReferencedTable Group ReferencedColumn Id
		/// </summary>
		public UserGroupList UserGroupList
		{
			get
			{
				return _UserGroupList;
			}
			set
			{
				_onUserGroupListChanging(value);
				_UserGroupList = value;
				_onUserGroupListChanged();
			}
		}
		private UserGroupList _UserGroupList;
		partial void _onUserGroupListChanging(UserGroupList value);
		partial void _onUserGroupListChanged();
		#endregion
	}
}

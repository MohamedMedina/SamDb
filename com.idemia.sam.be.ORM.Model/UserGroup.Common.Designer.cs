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
	// The UserGroupList Class.
	[Serializable]
	public partial class UserGroupList : ApplicationBlocks.Layers.BaseCommonList<UserGroup>
	{
		#region Constructor
		/// <summary>
		/// Constructor To Create a new UserGroup object.
		/// </summary>
		public UserGroupList():base()
		{
		}
		/// <summary>
		/// Constructor To Create a new UserGroup object.
		/// </summary>
		/// <param name="collection">IThe collection whose elements are copied to the new list.</param>
		public UserGroupList(IEnumerable<UserGroup> collection):base(collection)
		{
		}
		/// <summary>
		/// Constructor To Create a new UserGroup object.
		/// </summary>
		/// <param name="capacity">The number of elements that the new list can initially store.</param>
		public UserGroupList(int capacity):base(capacity)
		{
		}
		#endregion

	}
	
	// Summary:
	// The UserGroup Class.
	[Serializable]
	public partial class UserGroup : ApplicationBlocks.Layers.BaseCommon<UserGroup>
	{

		#region Factor Method
		/// <summary>
		/// Factor Method To Create a new UserGroup object.
		/// </summary>
		/// <param name="Id">Initial value of Id.</param>
		/// <param name="userId">Initial value of userId.</param>
		/// <param name="groupId">Initial value of groupId.</param>
		/// <returns>Return New UserGroup Object</returns>
		public static UserGroup CreateUserGroup(
											System.Int32 Id, System.Int32 userId, System.Int32 groupId)
		{
			UserGroup objUserGroup = new UserGroup();
			objUserGroup.Id = Id;
			objUserGroup.userId = userId;
			objUserGroup.groupId = groupId;
			return objUserGroup;
		}
		#endregion

		#region UserGroupList
		/// <summary>
		/// Property UserGroupList Represent Rows Collection of UserGroup.
		/// </summary>
		public UserGroupList UserGroupList
		{
			get
			{
				return (UserGroupList)base.BaseCommonList;
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
	
		#region userId
		/// <summary>
		/// Property userId Represent Column userId in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32 userId
		{
			get
			{
				return _userId;
			}
			set
			{
				_onuserIdChanging(value);
				_onChangingValue("userId",value,IsuserIdAllowNull);
				_userId = value;
				_onChangedValue("userId");
				_onuserIdChanged();
			}
		}
		private System.Int32 _userId;
		partial void _onuserIdChanging(System.Int32 value);
		partial void _onuserIdChanged();
		/// <summary>
		/// get value of userId Property is Allow Null or not
		/// </summary>
		public System.Boolean IsuserIdAllowNull
		{
			get
			{
				return false;
			}
		}
		#endregion
	
		#region groupId
		/// <summary>
		/// Property groupId Represent Column groupId in CodeGeneratingInfo Table
		/// </summary>
		public System.Int32 groupId
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
		private System.Int32 _groupId;
		partial void _ongroupIdChanging(System.Int32 value);
		partial void _ongroupIdChanged();
		/// <summary>
		/// get value of groupId Property is Allow Null or not
		/// </summary>
		public System.Boolean IsgroupIdAllowNull
		{
			get
			{
				return false;
			}
		}
		#endregion
	
		#region Relation Objects
		/// <summary>
		/// Property GroupList Represent FK_GroupID_UserGroup Relation
		/// ParentTable UserGroup ParentColumn groupId ,ReferencedTable Group ReferencedColumn Id
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
	
		/// <summary>
		/// Property UserList Represent FK_UserID_UserGroup Relation
		/// ParentTable UserGroup ParentColumn userId ,ReferencedTable User ReferencedColumn Id
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
		#endregion
	}
}

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
	// The UserList Class.
	[Serializable]
	public partial class UserList : ApplicationBlocks.Layers.BaseCommonList<User>
	{
		#region Constructor
		/// <summary>
		/// Constructor To Create a new User object.
		/// </summary>
		public UserList():base()
		{
		}
		/// <summary>
		/// Constructor To Create a new User object.
		/// </summary>
		/// <param name="collection">IThe collection whose elements are copied to the new list.</param>
		public UserList(IEnumerable<User> collection):base(collection)
		{
		}
		/// <summary>
		/// Constructor To Create a new User object.
		/// </summary>
		/// <param name="capacity">The number of elements that the new list can initially store.</param>
		public UserList(int capacity):base(capacity)
		{
		}
		#endregion

	}
	
	// Summary:
	// The User Class.
	[Serializable]
	public partial class User : ApplicationBlocks.Layers.BaseCommon<User>
	{

		#region Factor Method
		/// <summary>
		/// Factor Method To Create a new User object.
		/// </summary>
		/// <param name="Id">Initial value of Id.</param>
		/// <param name="userName">Initial value of userName.</param>
		/// <param name="fullName">Initial value of fullName.</param>
		/// <param name="Password">Initial value of Password.</param>
		/// <param name="status">Initial value of status.</param>
		/// <param name="createDate">Initial value of createDate.</param>
		/// <returns>Return New User Object</returns>
		public static User CreateUser(
											System.Int32 Id, System.String userName, System.String fullName, System.String Password, System.Boolean? status
											,System.DateTime? createDate)
		{
			User objUser = new User();
			objUser.Id = Id;
			objUser.userName = userName;
			objUser.fullName = fullName;
			objUser.Password = Password;
			objUser.status = status;
			objUser.createDate = createDate;
			return objUser;
		}
		#endregion

		#region UserList
		/// <summary>
		/// Property UserList Represent Rows Collection of User.
		/// </summary>
		public UserList UserList
		{
			get
			{
				return (UserList)base.BaseCommonList;
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
	
		#region userName
		/// <summary>
		/// Property userName Represent Column userName in CodeGeneratingInfo Table
		/// </summary>
		public System.String userName
		{
			get
			{
				return _userName;
			}
			set
			{
				_onuserNameChanging(value);
				_onChangingValue("userName",value,IsuserNameAllowNull);
				_userName = value;
				_onChangedValue("userName");
				_onuserNameChanged();
			}
		}
		private System.String _userName;
		partial void _onuserNameChanging(System.String value);
		partial void _onuserNameChanged();
		/// <summary>
		/// get value of userName Property is Allow Null or not
		/// </summary>
		public System.Boolean IsuserNameAllowNull
		{
			get
			{
				return false;
			}
		}
		#endregion
	
		#region fullName
		/// <summary>
		/// Property fullName Represent Column fullName in CodeGeneratingInfo Table
		/// </summary>
		public System.String fullName
		{
			get
			{
				return _fullName;
			}
			set
			{
				_onfullNameChanging(value);
				_onChangingValue("fullName",value,IsfullNameAllowNull);
				_fullName = value;
				_onChangedValue("fullName");
				_onfullNameChanged();
			}
		}
		private System.String _fullName;
		partial void _onfullNameChanging(System.String value);
		partial void _onfullNameChanged();
		/// <summary>
		/// get value of fullName Property is Allow Null or not
		/// </summary>
		public System.Boolean IsfullNameAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region Password
		/// <summary>
		/// Property Password Represent Column Password in CodeGeneratingInfo Table
		/// </summary>
		public System.String Password
		{
			get
			{
				return _Password;
			}
			set
			{
				_onPasswordChanging(value);
				_onChangingValue("Password",value,IsPasswordAllowNull);
				_Password = value;
				_onChangedValue("Password");
				_onPasswordChanged();
			}
		}
		private System.String _Password;
		partial void _onPasswordChanging(System.String value);
		partial void _onPasswordChanged();
		/// <summary>
		/// get value of Password Property is Allow Null or not
		/// </summary>
		public System.Boolean IsPasswordAllowNull
		{
			get
			{
				return false;
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
	
		#region createDate
		/// <summary>
		/// Property createDate Represent Column createDate in CodeGeneratingInfo Table
		/// </summary>
		public System.DateTime? createDate
		{
			get
			{
				return _createDate;
			}
			set
			{
				_oncreateDateChanging(value);
				_onChangingValue("createDate",value,IscreateDateAllowNull);
				_createDate = value;
				_onChangedValue("createDate");
				_oncreateDateChanged();
			}
		}
		private System.DateTime? _createDate;
		partial void _oncreateDateChanging(System.DateTime? value);
		partial void _oncreateDateChanged();
		/// <summary>
		/// get value of createDate Property is Allow Null or not
		/// </summary>
		public System.Boolean IscreateDateAllowNull
		{
			get
			{
				return true;
			}
		}
		#endregion
	
		#region Relation Objects
		/// <summary>
		/// Property UserGroupList Represent FK_UserID_UserGroup Relation
		/// ParentTable UserGroup ParentColumn userId ,ReferencedTable User ReferencedColumn Id
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

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
	// The FunctionList Class.
	[Serializable]
	public partial class FunctionList : ApplicationBlocks.Layers.BaseCommonList<Function>
	{
		#region Constructor
		/// <summary>
		/// Constructor To Create a new Function object.
		/// </summary>
		public FunctionList():base()
		{
		}
		/// <summary>
		/// Constructor To Create a new Function object.
		/// </summary>
		/// <param name="collection">IThe collection whose elements are copied to the new list.</param>
		public FunctionList(IEnumerable<Function> collection):base(collection)
		{
		}
		/// <summary>
		/// Constructor To Create a new Function object.
		/// </summary>
		/// <param name="capacity">The number of elements that the new list can initially store.</param>
		public FunctionList(int capacity):base(capacity)
		{
		}
		#endregion

	}
	
	// Summary:
	// The Function Class.
	[Serializable]
	public partial class Function : ApplicationBlocks.Layers.BaseCommon<Function>
	{

		#region Factor Method
		/// <summary>
		/// Factor Method To Create a new Function object.
		/// </summary>
		/// <param name="Id">Initial value of Id.</param>
		/// <param name="name">Initial value of name.</param>
		/// <param name="nameAr">Initial value of nameAr.</param>
		/// <param name="route">Initial value of route.</param>
		/// <param name="status">Initial value of status.</param>
		/// <returns>Return New Function Object</returns>
		public static Function CreateFunction(
											System.Int32 Id, System.String name, System.String nameAr, System.String route, System.Boolean? status)
		{
			Function objFunction = new Function();
			objFunction.Id = Id;
			objFunction.name = name;
			objFunction.nameAr = nameAr;
			objFunction.route = route;
			objFunction.status = status;
			return objFunction;
		}
		#endregion

		#region FunctionList
		/// <summary>
		/// Property FunctionList Represent Rows Collection of Function.
		/// </summary>
		public FunctionList FunctionList
		{
			get
			{
				return (FunctionList)base.BaseCommonList;
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
	
		#region route
		/// <summary>
		/// Property route Represent Column route in CodeGeneratingInfo Table
		/// </summary>
		public System.String route
		{
			get
			{
				return _route;
			}
			set
			{
				_onrouteChanging(value);
				_onChangingValue("route",value,IsrouteAllowNull);
				_route = value;
				_onChangedValue("route");
				_onrouteChanged();
			}
		}
		private System.String _route;
		partial void _onrouteChanging(System.String value);
		partial void _onrouteChanged();
		/// <summary>
		/// get value of route Property is Allow Null or not
		/// </summary>
		public System.Boolean IsrouteAllowNull
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
		/// Property GroupFunctionList Represent FK_FunctionID_GroupFunction Relation
		/// ParentTable GroupFunction ParentColumn functionId ,ReferencedTable Function ReferencedColumn Id
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
		#endregion
	}
}

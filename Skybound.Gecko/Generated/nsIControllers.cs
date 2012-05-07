// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIControllers.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIControllers </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f36e3ec1-9197-4ad8-8d4c-d3b1927fd6df")]
	public interface nsIControllers
	{
		
		/// <summary>Member GetControllerForCommand </summary>
		/// <param name='command'> </param>
		/// <returns>A nsIController</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIController GetControllerForCommand([MarshalAs(UnmanagedType.LPStr)] string command);
		
		/// <summary>Member InsertControllerAt </summary>
		/// <param name='index'> </param>
		/// <param name='controller'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertControllerAt(uint index, [MarshalAs(UnmanagedType.Interface)] nsIController controller);
		
		/// <summary>Member RemoveControllerAt </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIController</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIController RemoveControllerAt(uint index);
		
		/// <summary>Member GetControllerAt </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIController</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIController GetControllerAt(uint index);
		
		/// <summary>Member AppendController </summary>
		/// <param name='controller'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendController([MarshalAs(UnmanagedType.Interface)] nsIController controller);
		
		/// <summary>Member RemoveController </summary>
		/// <param name='controller'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveController([MarshalAs(UnmanagedType.Interface)] nsIController controller);
		
		/// <summary>
        ///Return an ID for this controller which is unique to this
        ///        nsIControllers.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetControllerId([MarshalAs(UnmanagedType.Interface)] nsIController controller);
		
		/// <summary>
        ///Get the controller specified by the given ID.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIController GetControllerById(uint controllerID);
		
		/// <summary>Member GetControllerCount </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetControllerCount();
	}
}

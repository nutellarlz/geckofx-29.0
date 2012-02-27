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
// Generated by IDLImporter from file nsIXULAppInfo.idl
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
	
	
	/// <summary>
    /// A scriptable interface to the nsXULAppAPI structure. See nsXULAppAPI.h for
    /// a detailed description of each attribute.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a61ede2a-ef09-11d9-a5ce-001124787b2e")]
	public interface nsIXULAppInfo
	{
		
		/// <summary>
        /// @see nsXREAppData.vendor
        /// @returns an empty string if nsXREAppData.vendor is not set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVendorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aVendor);
		
		/// <summary>
        /// @see nsXREAppData.name
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName);
		
		/// <summary>
        /// @see nsXREAppData.ID
        /// @returns an empty string if nsXREAppData.ID is not set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aID);
		
		/// <summary>
        /// The version of the XUL application. It is different than the
        /// version of the XULRunner platform. Be careful about which one you want.
        ///
        /// @see nsXREAppData.version
        /// @returns an empty string if nsXREAppData.version is not set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aVersion);
		
		/// <summary>
        /// The build ID/date of the application. For xulrunner applications,
        /// this will be different than the build ID of the platform. Be careful
        /// about which one you want.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppBuildIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAppBuildID);
		
		/// <summary>
        /// The version of the XULRunner platform.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPlatformVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPlatformVersion);
		
		/// <summary>
        /// The build ID/date of gecko and the XULRunner platform.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPlatformBuildIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPlatformBuildID);
	}
}

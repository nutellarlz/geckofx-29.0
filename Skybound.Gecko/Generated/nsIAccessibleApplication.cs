// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIAccessibleApplication.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIAccessibleApplication.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIAccessibleApplication </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("79251626-387c-4531-89f3-680d31d6cf05")]
	public interface nsIAccessibleApplication
	{
		
		/// <summary>Member GetAppNameAttribute </summary>
		/// <param name='aAppName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAppName);
		
		/// <summary>Member GetAppVersionAttribute </summary>
		/// <param name='aAppVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAppVersion);
		
		/// <summary>Member GetPlatformNameAttribute </summary>
		/// <param name='aPlatformName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPlatformNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPlatformName);
		
		/// <summary>Member GetPlatformVersionAttribute </summary>
		/// <param name='aPlatformVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPlatformVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPlatformVersion);
	}
}
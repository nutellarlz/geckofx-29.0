// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsPIDNSService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsPIDNSService.idl
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
	
	
	/// <summary>nsPIDNSService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a26c5b45-7707-4412-bbc1-2462b890848d")]
	public interface nsPIDNSService : nsIDNSService
	{
		
		/// <summary>Member AsyncResolve </summary>
		/// <param name='aHostName'> </param>
		/// <param name='aFlags'> </param>
		/// <param name='aListener'> </param>
		/// <param name='aListenerTarget'> </param>
		/// <returns>A nsICancelable</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsICancelable AsyncResolve([MarshalAs(UnmanagedType.LPStruct)] nsAString  aHostName, System.UInt32  aFlags, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener  aListener, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget  aListenerTarget);
		
		/// <summary>Member Resolve </summary>
		/// <param name='aHostName'> </param>
		/// <param name='aFlags'> </param>
		/// <returns>A nsIDNSRecord</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDNSRecord Resolve([MarshalAs(UnmanagedType.LPStruct)] nsAString  aHostName, System.UInt32  aFlags);
		
		/// <summary>Member GetMyHostNameAttribute </summary>
		/// <param name='aMyHostName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMyHostNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aMyHostName);
		
		/// <summary>Member Init </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init();
		
		/// <summary>Member Shutdown </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Shutdown();
	}
}
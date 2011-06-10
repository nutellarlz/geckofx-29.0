// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsICommandHandler.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsICommandHandler.idl
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
	
	
	/// <summary>nsICommandHandlerInit </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("731C6C50-67D6-11d4-9529-0020183BF181")]
	public interface nsICommandHandlerInit
	{
		
		/// <summary>Member GetWindowAttribute </summary>
		/// <returns>A nsIDOMWindow </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow  GetWindowAttribute();
		
		/// <summary>Member SetWindowAttribute </summary>
		/// <param name='aWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWindowAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow);
	}
	
	/// <summary>nsICommandHandler </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("34A4FCF0-66FC-11d4-9528-0020183BF181")]
	public interface nsICommandHandler
	{
		
		/// <summary>Member Exec </summary>
		/// <param name='aCommand'> </param>
		/// <param name='aParameters'> </param>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string Exec([MarshalAs(UnmanagedType.LPStr)] System.String  aCommand, [MarshalAs(UnmanagedType.LPStr)] System.String  aParameters);
		
		/// <summary>Member Query </summary>
		/// <param name='aCommand'> </param>
		/// <param name='aParameters'> </param>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string Query([MarshalAs(UnmanagedType.LPStr)] System.String  aCommand, [MarshalAs(UnmanagedType.LPStr)] System.String  aParameters);
	}
}
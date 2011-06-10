// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIWeakReference.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIWeakReference.idl
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
	
	
	/// <summary>nsIWeakReference </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9188bc85-f92e-11d2-81ef-0060083a0bcf")]
	public interface nsIWeakReference
	{
		
		/// <summary>Member QueryReferent </summary>
		/// <param name='uuid'> </param>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr  QueryReferent(ref System.Guid uuid);
	}
	
	/// <summary>nsISupportsWeakReference </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9188bc86-f92e-11d2-81ef-0060083a0bcf")]
	public interface nsISupportsWeakReference
	{
		
		/// <summary>Member GetWeakReference </summary>
		/// <returns>A nsIWeakReference</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWeakReference GetWeakReference();
	}
}
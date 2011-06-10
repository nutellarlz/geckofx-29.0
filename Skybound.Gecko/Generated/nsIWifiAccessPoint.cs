// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIWifiAccessPoint.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIWifiAccessPoint.idl
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
	
	
	/// <summary>nsIWifiAccessPoint </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("E28E614F-8F86-44FF-BCF5-5F18225834A0")]
	public interface nsIWifiAccessPoint
	{
		
		/// <summary>Member GetMacAttribute </summary>
		/// <param name='aMac'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMacAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aMac);
		
		/// <summary>Member GetSsidAttribute </summary>
		/// <param name='aSsid'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSsidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSsid);
		
		/// <summary>Member GetRawSSIDAttribute </summary>
		/// <param name='aRawSSID'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRawSSIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aRawSSID);
		
		/// <summary>Member GetSignalAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetSignalAttribute();
	}
}
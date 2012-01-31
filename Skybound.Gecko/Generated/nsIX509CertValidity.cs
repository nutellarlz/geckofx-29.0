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
// Generated by IDLImporter from file nsIX509CertValidity.idl
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
    /// Information on the validity period of a X.509 certificate.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e701dfd8-1dd1-11b2-a172-ffa6cc6156ad")]
	public interface nsIX509CertValidity
	{
		
		/// <summary>
        /// The earliest point in time where
        /// a certificate is valid.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetNotBeforeAttribute();
		
		/// <summary>
        /// "notBefore" attribute formatted as a time string
        /// according to the environment locale,
        /// according to the environment time zone.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNotBeforeLocalTimeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNotBeforeLocalTime);
		
		/// <summary>
        /// The day portion of "notBefore"
        /// formatted as a time string
        /// according to the environment locale,
        /// according to the environment time zone.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNotBeforeLocalDayAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNotBeforeLocalDay);
		
		/// <summary>
        /// "notBefore" attribute formatted as a string
        /// according to the environment locale,
        /// displayed as GMT / UTC.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNotBeforeGMTAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNotBeforeGMT);
		
		/// <summary>
        /// The latest point in time where
        /// a certificate is valid.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetNotAfterAttribute();
		
		/// <summary>
        /// "notAfter" attribute formatted as a time string
        /// according to the environment locale,
        /// according to the environment time zone.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNotAfterLocalTimeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNotAfterLocalTime);
		
		/// <summary>
        /// The day portion of "notAfter"
        /// formatted as a time string
        /// according to the environment locale,
        /// according to the environment time zone.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNotAfterLocalDayAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNotAfterLocalDay);
		
		/// <summary>
        /// "notAfter" attribute formatted as a time string
        /// according to the environment locale,
        /// displayed as GMT / UTC.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNotAfterGMTAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNotAfterGMT);
	}
}

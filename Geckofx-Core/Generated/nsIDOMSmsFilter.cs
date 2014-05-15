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
// Generated by IDLImporter from file nsIDOMSmsFilter.idl
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
	
	
	/// <summary>
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("17890b60-0367-45c6-9729-62e5bf349b2b")]
	public interface nsIDOMMozSmsFilter
	{
		
		/// <summary>
        /// A date that can return null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetStartDateAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// A date that can return null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartDateAttribute(Gecko.JsVal aStartDate, System.IntPtr jsContext);
		
		/// <summary>
        /// A date that can return null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetEndDateAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// A date that can return null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEndDateAttribute(Gecko.JsVal aEndDate, System.IntPtr jsContext);
		
		/// <summary>
        /// An array of DOMString that can return null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetNumbersAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// An array of DOMString that can return null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNumbersAttribute(Gecko.JsVal aNumbers, System.IntPtr jsContext);
		
		/// <summary>
        /// A DOMString that can return and be set to "sent", "received" or null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDeliveryAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDelivery);
		
		/// <summary>
        /// A DOMString that can return and be set to "sent", "received" or null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDeliveryAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDelivery);
		
		/// <summary>
        /// A read flag that can return and be set to a boolean or null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetReadAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// A read flag that can return and be set to a boolean or null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReadAttribute(Gecko.JsVal aRead, System.IntPtr jsContext);
		
		/// <summary>
        /// A thread id that can return and be set to a numeric value or null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetThreadIdAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// A thread id that can return and be set to a numeric value or null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetThreadIdAttribute(Gecko.JsVal aThreadId, System.IntPtr jsContext);
	}
}

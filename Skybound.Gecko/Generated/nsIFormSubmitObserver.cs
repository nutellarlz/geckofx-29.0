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
// Generated by IDLImporter from file nsIFormSubmitObserver.idl
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
	
	
	/// <summary>nsIFormSubmitObserver </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("534ab795-6a99-4195-bfab-cfdd7836657d")]
	public interface nsIFormSubmitObserver
	{
		
		/// <summary>Member Notify </summary>
		/// <param name='formNode'> </param>
		/// <param name='window'> </param>
		/// <param name='actionURL'> </param>
		/// <param name='cancelSubmit'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Notify([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLFormElement formNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window, [MarshalAs(UnmanagedType.Interface)] nsIURI actionURL, [MarshalAs(UnmanagedType.Bool)] ref bool cancelSubmit);
		
		/// <summary>Member NotifyInvalidSubmit </summary>
		/// <param name='formNode'> </param>
		/// <param name='invalidElements'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyInvalidSubmit([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLFormElement formNode, [MarshalAs(UnmanagedType.Interface)] nsIArray invalidElements);
	}
}

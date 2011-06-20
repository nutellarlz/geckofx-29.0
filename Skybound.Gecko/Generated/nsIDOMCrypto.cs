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
// Generated by IDLImporter from file nsIDOMCrypto.idl
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
	
	
	/// <summary>nsIDOMCrypto </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("12b6d899-2aed-4ea9-8c02-2223ab7ab592")]
	public interface nsIDOMCrypto
	{
		
		/// <summary>Member GetVersionAttribute </summary>
		/// <param name='aVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aVersion);
		
		/// <summary>Member GetEnableSmartCardEventsAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetEnableSmartCardEventsAttribute();
		
		/// <summary>Member SetEnableSmartCardEventsAttribute </summary>
		/// <param name='aEnableSmartCardEvents'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEnableSmartCardEventsAttribute([MarshalAs(UnmanagedType.Bool)] bool aEnableSmartCardEvents);
		
		/// <summary>
        ///... </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCRMFObject GenerateCRMFRequest();
		
		/// <summary>Member ImportUserCertificates </summary>
		/// <param name='nickname'> </param>
		/// <param name='cmmfResponse'> </param>
		/// <param name='doForcedBackup'> </param>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ImportUserCertificates([MarshalAs(UnmanagedType.LPStruct)] nsAString nickname, [MarshalAs(UnmanagedType.LPStruct)] nsAString cmmfResponse, [MarshalAs(UnmanagedType.Bool)] bool doForcedBackup, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>Member PopChallengeResponse </summary>
		/// <param name='challenge'> </param>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PopChallengeResponse([MarshalAs(UnmanagedType.LPStruct)] nsAString challenge, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>Member Random </summary>
		/// <param name='numBytes'> </param>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Random(int numBytes, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        ///... </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SignText([MarshalAs(UnmanagedType.LPStruct)] nsAString stringToSign, [MarshalAs(UnmanagedType.LPStruct)] nsAString caOption, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>Member Logout </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Logout();
		
		/// <summary>Member DisableRightClick </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DisableRightClick();
	}
}

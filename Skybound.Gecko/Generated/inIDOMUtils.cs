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
// Generated by IDLImporter from file inIDOMUtils.idl
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
	
	
	/// <summary>inIDOMUtils </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0D9E5532-F5D5-44DD-94CA-D9EED5778B1C")]
	public interface inIDOMUtils
	{
		
		/// <summary>
        /// CSS utilities
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupportsArray GetCSSStyleRules([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPseudo);
		
		/// <summary>Member GetRuleLine </summary>
		/// <param name='aRule'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRuleLine([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSStyleRule aRule);
		
		/// <summary>
        /// Returns true if the string names a property that is inherited by default.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsInheritedProperty([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPropertyName);
		
		/// <summary>
        /// DOM Node utilities
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsIgnorableWhitespace([MarshalAs(UnmanagedType.Interface)] nsIDOMCharacterData aDataNode);
		
		/// <summary>
        /// whether we are showing anonymous content.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetParentForNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.U1)] bool aShowingAnonymousContent);
		
		/// <summary>Member GetChildrenForNode </summary>
		/// <param name='aNode'> </param>
		/// <param name='aShowingAnonymousContent'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetChildrenForNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.U1)] bool aShowingAnonymousContent);
		
		/// <summary>
        /// XBL utilities
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetBindingURLs([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>
        /// content state utilities
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetContentState([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>Member SetContentState </summary>
		/// <param name='aElement'> </param>
		/// <param name='aState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentState([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, ulong aState);
		
		/// <summary>Member GetUsedFontFaces </summary>
		/// <param name='aRange'> </param>
		/// <returns>A nsIDOMFontFaceList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMFontFaceList GetUsedFontFaces([MarshalAs(UnmanagedType.Interface)] nsIDOMRange aRange);
	}
}

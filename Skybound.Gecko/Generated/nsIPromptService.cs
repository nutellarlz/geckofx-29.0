// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIPromptService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIPromptService.idl
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
	
	
	/// <summary>nsIPromptService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1630C61A-325E-49ca-8759-A31B16C47AA5")]
	public interface nsIPromptService
	{
		
		/// <summary>Member Alert </summary>
		/// <param name='aParent'> </param>
		/// <param name='aDialogTitle'> </param>
		/// <param name='aText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Alert([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText);
		
		/// <summary>Member AlertCheck </summary>
		/// <param name='aParent'> </param>
		/// <param name='aDialogTitle'> </param>
		/// <param name='aText'> </param>
		/// <param name='aCheckMsg'> </param>
		/// <param name='aCheckState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AlertCheck([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCheckMsg, ref System.Boolean  aCheckState);
		
		/// <summary>Member Confirm </summary>
		/// <param name='aParent'> </param>
		/// <param name='aDialogTitle'> </param>
		/// <param name='aText'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Confirm([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText);
		
		/// <summary>Member ConfirmCheck </summary>
		/// <param name='aParent'> </param>
		/// <param name='aDialogTitle'> </param>
		/// <param name='aText'> </param>
		/// <param name='aCheckMsg'> </param>
		/// <param name='aCheckState'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ConfirmCheck([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCheckMsg, ref System.Boolean  aCheckState);
		
		/// <summary>Member ConfirmEx </summary>
		/// <param name='aParent'> </param>
		/// <param name='aDialogTitle'> </param>
		/// <param name='aText'> </param>
		/// <param name='aButtonFlags'> </param>
		/// <param name='aButton0Title'> </param>
		/// <param name='aButton1Title'> </param>
		/// <param name='aButton2Title'> </param>
		/// <param name='aCheckMsg'> </param>
		/// <param name='aCheckState'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int ConfirmEx([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, System.UInt32  aButtonFlags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aButton0Title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aButton1Title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aButton2Title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCheckMsg, ref System.Boolean  aCheckState);
		
		/// <summary>Member Prompt </summary>
		/// <param name='aParent'> </param>
		/// <param name='aDialogTitle'> </param>
		/// <param name='aText'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aCheckMsg'> </param>
		/// <param name='aCheckState'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Prompt([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] ref string aValue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCheckMsg, ref System.Boolean  aCheckState);
		
		/// <summary>Member PromptUsernameAndPassword </summary>
		/// <param name='aParent'> </param>
		/// <param name='aDialogTitle'> </param>
		/// <param name='aText'> </param>
		/// <param name='aUsername'> </param>
		/// <param name='aPassword'> </param>
		/// <param name='aCheckMsg'> </param>
		/// <param name='aCheckState'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PromptUsernameAndPassword([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] ref string aUsername, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] ref string aPassword, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCheckMsg, ref System.Boolean  aCheckState);
		
		/// <summary>Member PromptPassword </summary>
		/// <param name='aParent'> </param>
		/// <param name='aDialogTitle'> </param>
		/// <param name='aText'> </param>
		/// <param name='aPassword'> </param>
		/// <param name='aCheckMsg'> </param>
		/// <param name='aCheckState'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PromptPassword([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] ref string aPassword, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCheckMsg, ref System.Boolean  aCheckState);
		
		/// <summary>Member Select </summary>
		/// <param name='aParent'> </param>
		/// <param name='aDialogTitle'> </param>
		/// <param name='aText'> </param>
		/// <param name='aCount'> </param>
		/// <param name='aSelectList'> </param>
		/// <param name='aOutSelection'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Select([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aParent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDialogTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aText, System.UInt32  aCount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=3)] string aSelectList, out System.Int32  aOutSelection);
	}
}
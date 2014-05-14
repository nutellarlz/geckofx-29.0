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
// Generated by IDLImporter from file nsIPrintingPrompt.idl
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
    /// This is the printing prompt interface which can be used without knowlege of a
    /// parent window. The parentage is hidden by the GetInterface though
    /// which it is gotten. This interface is identical to nsIPintingPromptService
    /// but without the parent nsIDOMWindow parameter. See nsIPrintingPromptService
    /// for all documentation.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("44E314CA-75B1-4f3d-9553-9B3507912108")]
	public interface nsIPrintingPrompt
	{
		
		/// <summary>
        /// Show the Print Dialog
        ///
        /// @param webBrowserPrint - represents the document to be printed
        /// @param printSettings - PrintSettings for print "job"
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPrintDialog([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserPrint webBrowserPrint, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings);
		
		/// <summary>
        /// Shows the print progress dialog
        ///
        /// @param webBrowserPrint - represents the document to be printed
        /// @param printSettings - PrintSettings for print "job"
        /// @param openDialogObserver - an observer that will be notifed when the dialog is opened
        /// @param isForPrinting - true - for printing, false for print preview
        /// @param webProgressListener - additional listener can be registered for progress notifications
        /// @param printProgressParams - parameter object for passing progress state
        /// @param notifyOnOpen - this indicates that the observer will be notified when the progress
        /// dialog has been opened. If false is returned it means the observer
        /// (usually the caller) shouldn't wait
        /// For Print Preview Progress there is intermediate progress
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowProgress([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserPrint webBrowserPrint, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings, [MarshalAs(UnmanagedType.Interface)] nsIObserver openDialogObserver, [MarshalAs(UnmanagedType.U1)] bool isForPrinting, [MarshalAs(UnmanagedType.Interface)] ref nsIWebProgressListener webProgressListener, [MarshalAs(UnmanagedType.Interface)] ref nsIPrintProgressParams printProgressParams, [MarshalAs(UnmanagedType.U1)] ref bool notifyOnOpen);
		
		/// <summary>
        /// Shows the print progress dialog
        ///
        /// @param printSettings - PrintSettings for page setup (required)
        /// @param aObs - An observer to know if the contents of the Print Settings
        /// object has changed while the dialog is being shown.
        /// For example, some platforms may implement an "Apply" button (not required)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPageSetup([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObs);
		
		/// <summary>
        /// Sometimes platforms need to bring up a special properties dialog for showing
        /// print specific properties. Although the PrintSettings has a place to set the
        /// printer name, here is is an argument to be clear as to what printer is being
        /// asked to have the properties set for it. The Printer name in the PS is ignored.
        ///
        /// @param printerName - name of printer (required)
        /// @param printSettings - PrintSettings for page setup (required)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPrinterProperties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string printerName, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings);
	}
}

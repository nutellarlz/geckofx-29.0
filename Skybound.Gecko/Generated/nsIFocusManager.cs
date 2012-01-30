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
// Generated by IDLImporter from file nsIFocusManager.idl
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
    /// The focus manager deals with all focus related behaviour. Only one element
    /// in the entire application may have the focus at a time; this element
    /// receives any keyboard events. While there is only one application-wide
    /// focused element, each nsIDOMWindow maintains a reference to the element
    /// that would be focused if the window was active.
    ///
    /// If the window's reference is to a frame element (iframe, browser,
    /// editor), then the child window contains the element that is currently
    /// focused. If the window's reference is to a root element, then the root is
    /// focused. If a window's reference is null, then no element is focused, yet
    /// the window is still focused.
    ///
    /// The blur event is fired on an element when it loses the application focus.
    /// After this blur event, if the focus is moving away from a document, two
    /// additional blur events are fired on the old document and window containing
    /// the focus respectively.
    ///
    /// When a new document is focused, two focus events are fired on the new
    /// document and window respectively. Then the focus event is fired on an
    /// element when it gains the application focus.
    ///
    /// A special case is that the root element may be focused, yet does not
    /// receive the element focus and blur events. Instead a focus outline may be
    /// drawn around the document.
    ///
    /// Blur and focus events do not bubble as per the W3C DOM Events spec.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("51db277b-7ee7-4bce-9b84-fd2efcd2c8bd")]
	public interface nsIFocusManager
	{
		
		/// <summary>
        /// The most active (frontmost) window, or null if no window that is part of
        /// the application is active. Setting the activeWindow raises it, and
        /// focuses the current child window's current element, if any. Setting this
        /// to null or to a non-top-level window throws an NS_ERROR_INVALID_ARG
        /// exception.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetActiveWindowAttribute();
		
		/// <summary>
        /// The most active (frontmost) window, or null if no window that is part of
        /// the application is active. Setting the activeWindow raises it, and
        /// focuses the current child window's current element, if any. Setting this
        /// to null or to a non-top-level window throws an NS_ERROR_INVALID_ARG
        /// exception.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetActiveWindowAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aActiveWindow);
		
		/// <summary>
        /// The child window within the activeWindow that is focused. This will
        /// always be activeWindow, a child window of activeWindow or null if no
        /// child window is focused. Setting the focusedWindow changes the focused
        /// window and raises the toplevel window it is in. If the current focus
        /// within the new focusedWindow is a frame element, then the focusedWindow
        /// will actually be set to the child window and the current element within
        /// that set as the focused element. This process repeats downwards until a
        /// non-frame element is found.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetFocusedWindowAttribute();
		
		/// <summary>
        /// The child window within the activeWindow that is focused. This will
        /// always be activeWindow, a child window of activeWindow or null if no
        /// child window is focused. Setting the focusedWindow changes the focused
        /// window and raises the toplevel window it is in. If the current focus
        /// within the new focusedWindow is a frame element, then the focusedWindow
        /// will actually be set to the child window and the current element within
        /// that set as the focused element. This process repeats downwards until a
        /// non-frame element is found.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocusedWindowAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aFocusedWindow);
		
		/// <summary>
        /// The element that is currently focused. This will always be an element
        /// within the document loaded in focusedWindow or null if no element in that
        /// document is focused.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetFocusedElementAttribute();
		
		/// <summary>
        /// Returns the method that was used to focus the element in window. This
        /// will either be 0, FLAG_BYMOUSE or FLAG_BYKEY. If window is null, then
        /// the current focusedWindow will be used by default. This has the result
        /// of retrieving the method that was used to focus the currently focused
        /// element.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLastFocusMethod([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
		
		/// <summary>
        /// Changes the focused element reference within the window containing
        /// aElement to aElement.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocus([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, uint aFlags);
		
		/// <summary>
        /// Move the focus to another element. If aStartElement is specified, then
        /// movement is done relative to aStartElement. If aStartElement is null,
        /// then movement is done relative to the currently focused element. If no
        /// element is focused, focus the first focusable element within the
        /// document (or the last focusable element if aType is MOVEFOCUS_END). This
        /// method is equivalent to setting the focusedElement to the new element.
        ///
        /// Specifying aStartElement and using MOVEFOCUS_LAST is not currently
        /// implemented.
        ///
        /// If no element is found, and aType is either MOVEFOCUS_ROOT or
        /// MOVEFOCUS_CARET, then the focus is cleared. If aType is any other value,
        /// the focus is not changed.
        ///
        /// Returns the element that was focused.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement MoveFocus([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aStartElement, uint aType, uint aFlags);
		
		/// <summary>
        /// Clears the focused element within aWindow. If the current focusedWindow
        /// is a descendant of aWindow, sets the current focusedWindow to aWindow.
        ///
        /// @throws NS_ERROR_INVALID_ARG if aWindow is null
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearFocus([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        /// Returns the currently focused element within aWindow. If aWindow is equal
        /// to the current value of focusedWindow, then the returned element will be
        /// the application-wide focused element (the value of focusedElement). The
        /// return value will be null if no element is focused.
        ///
        /// If aDeep is true, then child frames are traversed and the return value
        /// may be the element within a child descendant window that is focused. If
        /// aDeep if false, then the return value will be the frame element if the
        /// focus is in a child frame.
        ///
        /// aFocusedWindow will be set to the currently focused descendant window of
        /// aWindow, or to aWindow if aDeep is false. This will be set even if no
        /// element is focused.
        ///
        /// @throws NS_ERROR_INVALID_ARG if aWindow is null
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetFocusedElementForWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Bool)] bool aDeep, [MarshalAs(UnmanagedType.Interface)] ref nsIDOMWindow aFocusedWindow);
		
		/// <summary>
        /// Moves the selection caret within aWindow to the current focus.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MoveCaretToFocus([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        /// Called when a window has been raised.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WindowRaised([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        /// Called when a window has been lowered.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WindowLowered([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        /// Called when a new document in a window is shown.
        ///
        /// If aNeedsFocus is true, then focus events are expected to be fired on the
        /// window if this window is in the focused window chain.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WindowShown([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.Bool)] bool aNeedsFocus);
		
		/// <summary>
        /// Called when a document in a window has been hidden or otherwise can no
        /// longer accept focus.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WindowHidden([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        /// Fire any events that have been delayed due to synchronized actions.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FireDelayedEvents(System.IntPtr aDocument);
		
		/// <summary>
        /// Indicate that a plugin wishes to take the focus. This is similar to a
        /// normal focus except that the widget focus is not changed. Updating the
        /// widget focus state is the responsibility of the caller.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FocusPlugin(System.IntPtr aPlugin);
	}
}

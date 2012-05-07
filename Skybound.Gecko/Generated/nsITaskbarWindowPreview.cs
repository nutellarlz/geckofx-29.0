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
// Generated by IDLImporter from file nsITaskbarWindowPreview.idl
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
    /// nsITaskbarWindowPreview
    ///
    /// This interface represents the preview for a window in the taskbar. By
    /// default, Windows implements much of the behavior for applications by
    /// default. The primary purpose of this interface is to allow Gecko
    /// applications to take control over parts of the preview. Some parts are not
    /// controlled through this interface: the title and icon of the preview match
    /// the title and icon of the window always.
    ///
    /// By default, Windows takes care of drawing the thumbnail and preview for the
    /// application however if enableCustomDrawing is set to true, then the
    /// controller will start to receive drawPreview and drawThumbnail calls as well
    /// as reads on the thumbnailAspectRatio, width and height properties.
    ///
    /// By default, nsITaskbarWindowPreviews are visible. When made invisible, the
    /// window disappears from the list of windows in the taskbar for the
    /// application.
    ///
    /// If the window has any visible nsITaskbarTabPreviews, then the
    /// nsITaskbarWindowPreview for the corresponding window is automatically
    /// hidden. This is not reflected in the visible property. Note that other parts
    /// of the system (such as alt-tab) may still request thumbnails and/or previews
    /// through the nsITaskbarWindowPreview's controller.
    ///
    /// nsITaskbarWindowPreview will never invoke the controller's onClose or
    /// onActivate methods since handling them may conflict with other internal
    /// Gecko state and there is existing infrastructure in place to allow clients
    /// to handle those events
    ///
    /// Window previews may have a toolbar with up to 7 buttons. See
    /// nsITaskbarPreviewButton for more information about button properties.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("EC67CC57-342D-4064-B4C6-74A375E07B10")]
	public interface nsITaskbarWindowPreview : nsITaskbarPreview
	{
		
		/// <summary>
        /// The controller for this preview. A controller is required to provide
        /// the behavior and appearance of the taskbar previews. It is responsible for
        /// determining the size and contents of the preview, which buttons are
        /// displayed and how the application responds to user actions on the preview.
        ///
        /// Neither preview makes full use of the controller. See the documentation
        /// for nsITaskbarWindowPreview and nsITaskbarTabPreview for details on which
        /// controller methods are used.
        ///
        /// The controller is not allowed to be null.
        ///
        /// @see nsITaskbarPreviewController
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsITaskbarPreviewController GetControllerAttribute();
		
		/// <summary>
        /// The controller for this preview. A controller is required to provide
        /// the behavior and appearance of the taskbar previews. It is responsible for
        /// determining the size and contents of the preview, which buttons are
        /// displayed and how the application responds to user actions on the preview.
        ///
        /// Neither preview makes full use of the controller. See the documentation
        /// for nsITaskbarWindowPreview and nsITaskbarTabPreview for details on which
        /// controller methods are used.
        ///
        /// The controller is not allowed to be null.
        ///
        /// @see nsITaskbarPreviewController
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetControllerAttribute([MarshalAs(UnmanagedType.Interface)] nsITaskbarPreviewController aController);
		
		/// <summary>
        /// The tooltip displayed above the preview when the user hovers over it
        ///
        /// Default: an empty string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTooltipAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTooltip);
		
		/// <summary>
        /// The tooltip displayed above the preview when the user hovers over it
        ///
        /// Default: an empty string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTooltipAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTooltip);
		
		/// <summary>
        /// Whether or not the preview is visible.
        ///
        /// Changing this option is expensive for tab previews since toggling this
        /// option will destroy/create the proxy window and its registration with the
        /// taskbar. If any step of that fails, an exception will be thrown.
        ///
        /// For window previews, this operation is very cheap.
        ///
        /// Default: false
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetVisibleAttribute();
		
		/// <summary>
        /// Whether or not the preview is visible.
        ///
        /// Changing this option is expensive for tab previews since toggling this
        /// option will destroy/create the proxy window and its registration with the
        /// taskbar. If any step of that fails, an exception will be thrown.
        ///
        /// For window previews, this operation is very cheap.
        ///
        /// Default: false
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetVisibleAttribute([MarshalAs(UnmanagedType.U1)] bool aVisible);
		
		/// <summary>
        /// Gets/sets whether or not the preview is marked active (selected) in the
        /// taskbar.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetActiveAttribute();
		
		/// <summary>
        /// Gets/sets whether or not the preview is marked active (selected) in the
        /// taskbar.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetActiveAttribute([MarshalAs(UnmanagedType.U1)] bool aActive);
		
		/// <summary>
        /// Invalidates the taskbar's cached image of this preview, forcing a redraw
        /// if necessary
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Invalidate();
		
		/// <summary>
        /// Gets the nth button for the preview image. By default, all of the buttons
        /// are invisible.
        ///
        /// @see nsITaskbarPreviewButton
        ///
        /// @param index The index into the button array. Must be >= 0 and <
        /// MAX_TOOLBAR_BUTTONS.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITaskbarPreviewButton GetButton(uint index);
		
		/// <summary>
        /// Enables/disables custom drawing of thumbnails and previews
        ///
        /// Default value: false
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetEnableCustomDrawingAttribute();
		
		/// <summary>
        /// Enables/disables custom drawing of thumbnails and previews
        ///
        /// Default value: false
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEnableCustomDrawingAttribute([MarshalAs(UnmanagedType.U1)] bool aEnableCustomDrawing);
	}
}

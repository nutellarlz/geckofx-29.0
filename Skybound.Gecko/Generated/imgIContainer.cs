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
// Generated by IDLImporter from file imgIContainer.idl
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
    /// imgIContainer is the interface that represents an image. It allows
    /// access to frames as Thebes surfaces, and permits users to extract subregions
    /// as other imgIContainers. It also allows drawing of images on to Thebes
    /// contexts.
    ///
    /// Internally, imgIContainer also manages animation of images.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("239dfa70-2285-4d63-99cd-e9b7ff9555c7")]
	public interface imgIContainer
	{
		
		/// <summary>
        /// The width of the container rectangle.  In the case of any error,
        /// zero is returned, and an exception will be thrown.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetWidthAttribute();
		
		/// <summary>
        /// The height of the container rectangle.  In the case of any error,
        /// zero is returned, and an exception will be thrown.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetHeightAttribute();
		
		/// <summary>
        /// The type of this image (one of the TYPE_* values above).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetTypeAttribute();
		
		/// <summary>
        /// Direct C++ accessor for 'type' attribute, for convenience.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetType();
		
		/// <summary>
        /// Whether this image is animated. You can only be guaranteed that querying
        /// this will not throw if STATUS_DECODE_COMPLETE is set on the imgIRequest.
        ///
        /// @throws NS_ERROR_NOT_AVAILABLE if the animated state cannot be determined.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAnimatedAttribute();
		
		/// <summary>
        /// Whether the current frame is opaque; that is, needs the background painted
        /// behind it.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCurrentFrameIsOpaqueAttribute();
		
		/// <summary>
        /// Get a surface for the given frame. This may be a platform-native,
        /// optimized surface, so you cannot inspect its pixel data.
        ///
        /// @param aWhichFrame Frame specifier of the FRAME_* variety.
        /// @param aFlags Flags of the FLAG_* variety
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetFrame(uint aWhichFrame, uint aFlags);
		
		/// <summary>
        /// Create and return a new copy of the given frame that you can write to
        /// and otherwise inspect the pixels of.
        ///
        /// @param aWhichFrame Frame specifier of the FRAME_* variety.
        /// @param aFlags Flags of the FLAG_* variety
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr CopyFrame(uint aWhichFrame, uint aFlags);
		
		/// <summary>
        /// Create a new imgContainer that contains only a single frame, which itself
        /// contains a subregion of the given frame.
        ///
        /// @param aWhichFrame Frame specifier of the FRAME_* variety.
        /// @param aRect the area of the current frame to be duplicated in the
        /// returned imgContainer's frame.
        /// @param aFlags Flags of the FLAG_* variety
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIContainer ExtractFrame(uint aWhichFrame, [MarshalAs(UnmanagedType.Interface)] nsIntRect aRect, uint aFlags);
		
		/// <summary>
        /// Draw the current frame on to the context specified.
        ///
        /// @param aContext The Thebes context to draw the image to.
        /// @param aFilter The filter to be used if we're scaling the image.
        /// @param aUserSpaceToImageSpace The transformation from user space (e.g.,
        /// appunits) to image space.
        /// @param aFill The area in the context to draw pixels to. Image will be
        /// automatically tiled as necessary.
        /// @param aSubimage The area of the image, in pixels, that we are allowed to
        /// sample from.
        /// @param aViewportSize
        /// The size (in CSS pixels) of the viewport that would be available
        /// for the full image to occupy, if we were drawing the full image.
        /// (Note that we might not actually be drawing the full image -- we
        /// might be restricted by aSubimage -- but we still need the full
        /// image's viewport-size in order for SVG images with the "viewBox"
        /// attribute to position their content correctly.)
        /// @param aFlags Flags of the FLAG_* variety
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Draw(System.IntPtr aContext, gfxGraphicsFilter aFilter, gfxMatrix aUserSpaceToImageSpace, gfxRect aFill, [MarshalAs(UnmanagedType.Interface)] nsIntRect aSubimage, uint aViewportSize, uint aFlags);
		
		/// <summary>
        /// If this image is TYPE_VECTOR, i.e. is really an embedded SVG document,
        /// this method returns a pointer to the root nsIFrame of that document. If
        /// not (or if the root nsIFrame isn't available for some reason), this method
        /// returns nsnull.
        ///
        /// "notxpcom" for convenience, since we have no need for nsresult return-val.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetRootLayoutFrame();
		
		/// <summary>
        /// Ensures that an image is decoding. Calling this function guarantees that
        /// the image will at some point fire off decode notifications. Calling draw(),
        /// getFrame(), copyFrame(), or extractCurrentFrame() triggers the same
        /// mechanism internally. Thus, if you want to be sure that the image will be
        /// decoded but don't want to access it until then, you must call
        /// requestDecode().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RequestDecode();
		
		/// <summary>
        /// Increments the lock count on the image. An image will not be discarded
        /// as long as the lock count is nonzero. Note that it is still possible for
        /// the image to be undecoded if decode-on-draw is enabled and the image
        /// was never drawn.
        ///
        /// Upon instantiation images have a lock count of zero.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LockImage();
		
		/// <summary>
        /// Decreases the lock count on the image. If the lock count drops to zero,
        /// the image is allowed to discard its frame data to save memory.
        ///
        /// Upon instantiation images have a lock count of zero. It is an error to
        /// call this method without first having made a matching lockImage() call.
        /// In other words, the lock count is not allowed to be negative.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnlockImage();
		
		/// <summary>
        /// Animation mode Constants
        /// 0 = normal
        /// 1 = don't animate
        /// 2 = loop once
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetAnimationModeAttribute();
		
		/// <summary>
        /// Animation mode Constants
        /// 0 = normal
        /// 1 = don't animate
        /// 2 = loop once
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAnimationModeAttribute(ushort aAnimationMode);
		
		/// <summary>
        ///Methods to control animation </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetAnimation();
	}
}

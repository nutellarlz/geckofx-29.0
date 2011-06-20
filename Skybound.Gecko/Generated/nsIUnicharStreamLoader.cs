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
// Generated by IDLImporter from file nsIUnicharStreamLoader.idl
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
	
	
	/// <summary>nsIUnicharStreamLoaderObserver </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6bb3e55b-69c0-4fc9-87e5-bed780d997ce")]
	public interface nsIUnicharStreamLoaderObserver
	{
		
		/// <summary>
        /// Called when the first full segment of data if available.
        ///
        /// @param aLoader the unichar stream loader
        /// @param aContext the context parameter of the underlying channel
        /// @param aFirstSegment the raw bytes of the first full data segment
        /// @param aLength the length of aFirstSegment
        ///
        /// @return charset corresponding to this stream
        ///
        /// @note this method will only be called if the stream loader receives an
        /// OnDataAvailable call.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnDetermineCharset([MarshalAs(UnmanagedType.Interface)] nsIUnicharStreamLoader aLoader, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStr, SizeParamIndex=3)] string aFirstSegment, uint aLength, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Called when the entire stream has been loaded.
        ///
        /// @param aLoader the unichar stream loader
        /// @param aContext the context parameter of the underlying channel
        /// @param aStatus the status of the underlying channel
        /// @param aUnicharData the unichar input stream containing the data.  This
        /// can be null in some failure conditions.
        ///
        /// This method will always be called asynchronously by the
        /// nsUnicharIStreamLoader involved, on the thread that called the
        /// loader's init() method.
        ///
        /// @note If the stream loader does not receive an OnDataAvailable call,
        /// aUnicharData will be null, and aStatus will be a success value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStreamComplete([MarshalAs(UnmanagedType.Interface)] nsIUnicharStreamLoader aLoader, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatus, [MarshalAs(UnmanagedType.Interface)] nsIUnicharInputStream aUnicharData);
	}
	
	/// <summary>
    /// Asynchronously load a channel, converting the data to UTF-16.
    ///
    /// To use this interface, first call init() with a
    /// nsIUnicharStreamLoaderObserver that will be notified when the data has been
    /// loaded. Then call asyncOpen() on the channel with the nsIUnicharStreamLoader
    /// as the listener. The context argument in the asyncOpen() call will be
    /// passed to the onStreamComplete() callback.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9037f476-7c08-4729-b690-3e425269802b")]
	public interface nsIUnicharStreamLoader : nsIStreamListener
	{
		
		/// <summary>
        /// Called to signify the beginning of an asynchronous request.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        ///
        /// An exception thrown from onStartRequest has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Called to signify the end of an asynchronous request.  This
        /// call is always preceded by a call to onStartRequest.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        /// @param aStatusCode reason for stopping (NS_OK if completed successfully)
        ///
        /// An exception thrown from onStopRequest is generally ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);
		
		/// <summary>
        /// Called when the next chunk of data (corresponding to the request) may
        /// be read without blocking the calling thread.  The onDataAvailable impl
        /// must read exactly |aCount| bytes of data before returning.
        ///
        /// @param aRequest request corresponding to the source of the data
        /// @param aContext user defined context
        /// @param aInputStream input stream containing the data chunk
        /// @param aOffset
        /// Number of bytes that were sent in previous onDataAvailable calls
        /// for this request. In other words, the sum of all previous count
        /// parameters.
        /// If that number is greater than or equal to 2^32, this parameter
        /// will be PR_UINT32_MAX (2^32 - 1).
        /// @param aCount number of bytes available in the stream
        ///
        /// NOTE: The aInputStream parameter must implement readSegments.
        ///
        /// An exception thrown from onDataAvailable has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, uint aOffset, uint aCount);
		
		/// <summary>
        /// Initializes the unichar stream loader
        ///
        /// @param aObserver the observer to notify when a charset is needed and when
        /// the load is complete
        /// @param aSegmentSize the size of the segments to use for the data, in bytes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIUnicharStreamLoaderObserver aObserver, uint aSegmentSize);
		
		/// <summary>
        /// The channel attribute is only valid inside the onDetermineCharset
        /// and onStreamComplete callbacks.  Otherwise it will be null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel GetChannelAttribute();
		
		/// <summary>
        /// The charset that onDetermineCharset returned, if that's been
        /// called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aCharset);
	}
}

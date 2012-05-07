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
// Generated by IDLImporter from file nsIProgressEventSink.idl
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
    /// nsIProgressEventSink
    ///
    /// This interface is used to asynchronously convey channel status and progress
    /// information that is generally not critical to the processing of the channel.
    /// The information is intended to be displayed to the user in some meaningful
    /// way.
    ///
    /// An implementation of this interface can be passed to a channel via the
    /// channel's notificationCallbacks attribute.  See nsIChannel for more info.
    ///
    /// The channel will begin passing notifications to the progress event sink
    /// after its asyncOpen method has been called.  Notifications will cease once
    /// the channel calls its listener's onStopRequest method or once the channel
    /// is canceled (via nsIRequest::cancel).
    ///
    /// NOTE: This interface is actually not specific to channels and may be used
    /// with other implementations of nsIRequest.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("D974C99E-4148-4df9-8D98-DE834A2F6462")]
	public interface nsIProgressEventSink
	{
		
		/// <summary>
        /// Called to notify the event sink that progress has occurred for the
        /// given request.
        ///
        /// @param aRequest
        /// the request being observed (may QI to nsIChannel).
        /// @param aContext
        /// if aRequest is a channel, then this parameter is the listener
        /// context passed to nsIChannel::asyncOpen.
        /// @param aProgress
        /// numeric value in the range 0 to aProgressMax indicating the
        /// number of bytes transfered thus far.
        /// @param aProgressMax
        /// numeric value indicating maximum number of bytes that will be
        /// transfered (or 0xFFFFFFFFFFFFFFFF if total is unknown).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnProgress([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, ulong aProgress, ulong aProgressMax);
		
		/// <summary>
        /// Called to notify the event sink with a status message for the given
        /// request.
        ///
        /// @param aRequest
        /// the request being observed (may QI to nsIChannel).
        /// @param aContext
        /// if aRequest is a channel, then this parameter is the listener
        /// context passed to nsIChannel::asyncOpen.
        /// @param aStatus
        /// status code (not necessarily an error code) indicating the
        /// state of the channel (usually the state of the underlying
        /// transport).  see nsISocketTransport for socket specific status
        /// codes.
        /// @param aStatusArg
        /// status code argument to be used with the string bundle service
        /// to convert the status message into localized, human readable
        /// text.  the meaning of this parameter is specific to the value
        /// of the status code.  for socket status codes, this parameter
        /// indicates the host:port associated with the status code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStatus([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatus, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aStatusArg);
	}
}

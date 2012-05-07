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
// Generated by IDLImporter from file nsIObserverService.idl
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
    /// nsIObserverService
    ///
    /// Service allows a client listener (nsIObserver) to register and unregister for
    /// notifications of specific string referenced topic. Service also provides a
    /// way to notify registered listeners and a way to enumerate registered client
    /// listeners.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("D07F5192-E3D1-11d2-8ACD-00105A1B8860")]
	public interface nsIObserverService
	{
		
		/// <summary>
        /// AddObserver
        ///
        /// Registers a given listener for a notifications regarding the specified
        /// topic.
        ///
        /// @param anObserve : The interface pointer which will receive notifications.
        /// @param aTopic    : The notification topic or subject.
        /// @param ownsWeak  : If set to false, the nsIObserverService will hold a
        /// strong reference to |anObserver|.  If set to true and
        /// |anObserver| supports the nsIWeakReference interface,
        /// a weak reference will be held.  Otherwise an error will be
        /// returned.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIObserver anObserver, [MarshalAs(UnmanagedType.LPStr)] string aTopic, [MarshalAs(UnmanagedType.U1)] bool ownsWeak);
		
		/// <summary>
        /// removeObserver
        ///
        /// Unregisters a given listener from notifications regarding the specified
        /// topic.
        ///
        /// @param anObserver : The interface pointer which will stop recieving
        /// notifications.
        /// @param aTopic     : The notification topic or subject.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIObserver anObserver, [MarshalAs(UnmanagedType.LPStr)] string aTopic);
		
		/// <summary>
        /// notifyObservers
        ///
        /// Notifies all registered listeners of the given topic.
        ///
        /// @param aSubject : Notification specific interface pointer.
        /// @param aTopic   : The notification topic or subject.
        /// @param someData : Notification specific wide string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyObservers([MarshalAs(UnmanagedType.Interface)] nsISupports aSubject, [MarshalAs(UnmanagedType.LPStr)] string aTopic, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string someData);
		
		/// <summary>
        /// enumerateObservers
        ///
        /// Returns an enumeration of all registered listeners.
        ///
        /// @param aTopic   : The notification topic or subject.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator EnumerateObservers([MarshalAs(UnmanagedType.LPStr)] string aTopic);
	}
}

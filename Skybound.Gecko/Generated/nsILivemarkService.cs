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
// Generated by IDLImporter from file nsILivemarkService.idl
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
    /// WARNING:
    ///
    /// This interface is deprecated and will be removed in a future release.
    /// Use the mozIAsyncLivemarks interface instead.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("62a5fe00-d85c-4a63-aef7-176d8f1b189d")]
	public interface nsILivemarkService
	{
		
		/// <summary>
        /// Starts the livemark refresh timer.
        /// Being able to manually control this allows activity such
        /// as bookmarks import to occur without kicking off HTTP traffic.
        ///
        /// @note This is a no-op and exists just as a compatibility shim.
        ///
        /// @deprecated use the mozIAsyncLivemarks interface instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Start();
		
		/// <summary>
        /// Stop the livemark refresh timer.
        ///
        /// @note This is a no-op and exists just as a compatibility shim.
        ///
        /// @deprecated use the mozIAsyncLivemarks interface instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopUpdateLivemarks();
		
		/// <summary>
        /// Creates a new livemark
        /// @param folder      The id of the parent folder
        /// @param name        The name to show when displaying the livemark
        /// @param siteURI     The URI of the site the livemark was created from
        /// @param feedURI     The URI of the actual RSS feed
        /// @param index       The index to insert at, or
        /// nsINavBookmarksService.DEFAULT_INDEX to append.
        /// @returns the ID of the folder for the livemark
        ///
        /// @deprecated use the mozIAsyncLivemarks interface instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int CreateLivemark(long folder, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsIURI siteURI, [MarshalAs(UnmanagedType.Interface)] nsIURI feedURI, int index);
		
		/// <summary>
        /// Same as above, use during startup to avoid HTTP traffic
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int CreateLivemarkFolderOnly(long folder, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsIURI siteURI, [MarshalAs(UnmanagedType.Interface)] nsIURI feedURI, int index);
		
		/// <summary>
        /// Determines whether the folder with the given folder ID identifies
        /// a livemark container.
        ///
        /// @param folder    A folder ID
        ///
        /// @returns true if the given folder is a livemark folder, or
        /// false otherwise
        ///
        /// @throws NS_ERROR_INVALID_ARG if the folder ID isn't known
        ///
        /// @deprecated use the mozIAsyncLivemarks interface instead.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsLivemark(long folder);
		
		/// <summary>
        /// Determines whether the feed URI is a currently registered livemark.
        ///
        /// @param aFeedURI
        /// Feed URI to look for.
        ///
        /// @returns the found livemark folder id, or -1 if nothing was found.
        ///
        /// @deprecated use the mozIAsyncLivemarks interface instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLivemarkIdForFeedURI([MarshalAs(UnmanagedType.Interface)] nsIURI aFeedURI);
		
		/// <summary>
        /// Gets the URI of the website associated with a livemark container.
        ///
        /// @param container  The folder ID of a livemark container
        ///
        /// @returns nsIURI representing the URI of the website; if the livemark
        /// container doesn't have a valid site URI, null will be returned
        ///
        /// @throws NS_ERROR_INVALID_ARG if the folder ID isn't known or identifies
        /// a folder that isn't a livemark container
        /// @throws NS_ERROR_MALFORMED_URI if the site URI annotation has
        /// somehow been corrupted (and can't be turned into an nsIURI)
        ///
        /// @deprecated use the mozIAsyncLivemarks interface instead.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetSiteURI(long container);
		
		/// <summary>
        /// Sets the URI of the website associated with a livemark container.
        ///
        /// @param container  The folder ID of a livemark container
        /// @param siteURI    nsIURI object representing the site URI, or null
        /// to clear the site URI for this livemark container
        ///
        /// @throws NS_ERROR_INVALID_ARG if the folder ID isn't known or identifies
        /// a folder that isn't a livemark container; also if the siteURI
        /// argument isn't a valid nsIURI object (or null)
        ///
        /// @note This is a no-op and exists just as a compatibility shim.
        ///
        /// @deprecated use the mozIAsyncLivemarks interface instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSiteURI(long container, [MarshalAs(UnmanagedType.Interface)] nsIURI siteURI);
		
		/// <summary>
        /// Gets the URI of the syndication feed associated with a livemark container.
        ///
        /// @param container  The folder ID of a livemark container
        ///
        /// @returns nsIURI representing the URI of the feed; if the livemark
        /// container doesn't have a valid feed URI, null will be returned
        /// of the nsIURI object returned will be the empty string.
        ///
        /// @throws NS_ERROR_INVALID_ARG if the folder ID isn't known or identifies
        /// a folder that isn't a livemark container
        /// @throws NS_ERROR_MALFORMED_URI if the site URI annotation has
        /// somehow been corrupted (and can't be turned into an nsIURI)
        ///
        /// @deprecated use the mozIAsyncLivemarks interface instead.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetFeedURI(long container);
		
		/// <summary>
        /// Sets the URI of the feed associated with a livemark container.
        ///
        /// NOTE: The caller is responsible for reloading the livemark after
        /// changing its feed URI (since the contents are likely to be different
        /// given a different feed).
        ///
        /// @param container  The folder ID of a livemark container
        /// @param feedURI    nsIURI object representing the syndication feed URI
        ///
        /// @throws NS_ERROR_INVALID_ARG if the folder ID isn't known or identifies
        /// a folder that isn't a livemark container; also if the feedURI
        /// argument isn't a valid nsIURI object
        ///
        /// @note This is a no-op and exists just as a compatibility shim.
        ///
        /// @deprecated use the mozIAsyncLivemarks interface instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFeedURI(long container, [MarshalAs(UnmanagedType.Interface)] nsIURI feedURI);
		
		/// <summary>
        /// Reloads all livemark subscriptions, whether or not they've expired.
        ///
        /// @deprecated use the mozIAsyncLivemarks interface instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReloadAllLivemarks();
		
		/// <summary>
        /// Reloads the livemark with this folder ID, whether or not it's expired.
        /// @param folderID The ID of the folder to be reloaded
        ///
        /// @deprecated use the mozIAsyncLivemarks interface instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReloadLivemarkFolder(long folderID);
	}
}

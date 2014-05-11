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
// Generated by IDLImporter from file nsICacheEntry.idl
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
    /// *********************** REMOVE **********************
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1785f6f1-18b3-4cb4-ae99-6c5545c1de19")]
	public interface nsICacheEntry
	{
		
		/// <summary>
        /// Get the key identifying the cache entry.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aKey);
		
		/// <summary>
        /// Whether the data can be persist to disk.
        /// NOTE: This attribute must be set BEFORE opening the output stream.
        /// Switching this flag does not immediately affect creation of the disk
        /// file from memory-only data or eviction of the disk file and loading it
        /// to memory-only.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPersistToDiskAttribute();
		
		/// <summary>
        /// Whether the data can be persist to disk.
        /// NOTE: This attribute must be set BEFORE opening the output stream.
        /// Switching this flag does not immediately affect creation of the disk
        /// file from memory-only data or eviction of the disk file and loading it
        /// to memory-only.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPersistToDiskAttribute([MarshalAs(UnmanagedType.U1)] bool aPersistToDisk);
		
		/// <summary>
        /// Get the number of times the cache entry has been opened.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetFetchCountAttribute();
		
		/// <summary>
        /// Get the last time the cache entry was opened (in seconds since the Epoch).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLastFetchedAttribute();
		
		/// <summary>
        /// Get the last time the cache entry was modified (in seconds since the Epoch).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLastModifiedAttribute();
		
		/// <summary>
        /// Get the expiration time of the cache entry (in seconds since the Epoch).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetExpirationTimeAttribute();
		
		/// <summary>
        /// Set the time at which the cache entry should be considered invalid (in
        /// seconds since the Epoch).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetExpirationTime(uint expirationTime);
		
		/// <summary>
        /// Open blocking input stream to cache data.  Use the stream transport
        /// service to asynchronously read this stream on a background thread.
        /// The returned stream MAY implement nsISeekableStream.
        ///
        /// @param offset
        /// read starting from this offset into the cached data.  an offset
        /// beyond the end of the stream has undefined consequences.
        ///
        /// @return blocking, unbuffered input stream.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream OpenInputStream(long offset);
		
		/// <summary>
        /// Open non-blocking output stream to cache data.  The returned stream
        /// MAY implement nsISeekableStream.
        ///
        /// If opening an output stream to existing cached data, the data will be
        /// truncated to the specified offset.
        ///
        /// @param offset
        /// write starting from this offset into the cached data.  an offset
        /// beyond the end of the stream has undefined consequences.
        ///
        /// @return blocking, unbuffered output stream.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIOutputStream OpenOutputStream(long offset);
		
		/// <summary>
        /// Stores the Content-Length specified in the HTTP header for this
        /// entry. Checked before we write to the cache entry, to prevent ever
        /// taking up space in the cache for an entry that we know up front
        /// is going to have to be evicted anyway. See bug 588507.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetPredictedDataSizeAttribute();
		
		/// <summary>
        /// Stores the Content-Length specified in the HTTP header for this
        /// entry. Checked before we write to the cache entry, to prevent ever
        /// taking up space in the cache for an entry that we know up front
        /// is going to have to be evicted anyway. See bug 588507.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPredictedDataSizeAttribute(long aPredictedDataSize);
		
		/// <summary>
        /// Get/set security info on the cache entry for this descriptor.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetSecurityInfoAttribute();
		
		/// <summary>
        /// Get/set security info on the cache entry for this descriptor.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSecurityInfoAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aSecurityInfo);
		
		/// <summary>
        /// Get the size of the cache entry data, as stored. This may differ
        /// from the entry's dataSize, if the entry is compressed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetStorageDataSizeAttribute();
		
		/// <summary>
        /// Asynchronously doom an entry. Listener will be notified about the status
        /// of the operation. Null may be passed if caller doesn't care about the
        /// result.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncDoom([MarshalAs(UnmanagedType.Interface)] nsICacheEntryDoomCallback listener);
		
		/// <summary>
        /// Methods for accessing meta data.  Meta data is a table of key/value
        /// string pairs.  The strings do not have to conform to any particular
        /// charset, but they must be null terminated.
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetMetaDataElement([MarshalAs(UnmanagedType.LPStr)] string key);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMetaDataElement([MarshalAs(UnmanagedType.LPStr)] string key, [MarshalAs(UnmanagedType.LPStr)] string value);
		
		/// <summary>
        /// Claims that all metadata on this entry are up-to-date and this entry
        /// now can be delivered to other waiting consumers.
        ///
        /// We need such method since metadata must be delivered synchronously.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MetaDataReady();
		
		/// <summary>
        /// Called by consumer upon 304/206 response from the server.  This marks
        /// the entry content as positively revalidated.
        /// Consumer uses this method after the consumer has returned ENTRY_NEEDS_REVALIDATION
        /// result from onCacheEntryCheck and after successfull revalidation with the server.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValid();
		
		/// <summary>
        /// Doom this entry and open a new, empty, entry for write.  Consumer has
        /// to exchange this entry for the newly created.
        /// Used on 200 responses to conditional requests.
        ///
        /// @returns
        /// - an entry that can be used to write to
        /// @throws
        /// - NS_ERROR_NOT_AVAILABLE when the entry cannot be from some reason
        /// recreated for write
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICacheEntry Recreate();
		
		/// <summary>
        /// Returns the length of data this entry holds.
        /// @throws
        /// NS_ERROR_IN_PROGRESS when the write is still in progress.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetDataSizeAttribute();
		
		/// <summary>
        /// FOR BACKWARD COMPATIBILITY ONLY
        /// When the old cache backend is eventually removed, this method
        /// can be removed too.
        ///
        /// In the new backend: this method is no-op
        /// In the old backend: this method delegates to nsICacheEntryDescriptor.close()
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		/// <summary>
        /// FOR BACKWARD COMPATIBILITY ONLY
        /// Marks the entry as valid so that others can use it and get only readonly
        /// access when the entry is held by the 1st writer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MarkValid();
		
		/// <summary>
        /// FOR BACKWARD COMPATIBILITY ONLY
        /// Marks the entry as valid when write access is acquired.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MaybeMarkValid();
		
		/// <summary>
        /// FOR BACKWARD COMPATIBILITY ONLY / KINDA HACK
        /// @param aWriteAllowed
        /// consumer indicates whether write to the entry is allowed for it
        /// depends on implementation how the flag is handled
        /// @returns
        /// true when write access is acquired for this entry
        /// false otherwise
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasWriteAccess([MarshalAs(UnmanagedType.U1)] bool aWriteAllowed);
		
		/// <summary>
        /// ************** GET RID OF THESE ??? ***************
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataSize(uint size);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetStoragePolicyAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStoragePolicyAttribute(System.IntPtr aStoragePolicy);
	}
}

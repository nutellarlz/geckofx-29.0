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
// Generated by IDLImporter from file nsICycleCollectorListener.idl
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
    ///Interface to pass to the cycle collector to get information about
    /// the CC graph while it's being built. The order of calls will be a
    /// call to begin(); then for every node in the graph a call to either
    /// noteRefCountedObject() or noteGCedObject(), followed by calls to
    /// noteEdge() for every edge starting at that node; then a call to
    /// beginResults(); then a mixture of describeRoot() for ref counted
    /// nodes the CC has identified as roots and describeGarbage() for
    /// nodes the CC has identified as garbage.  Ref counted nodes that are
    /// not identified as either roots or garbage are neither, and have a
    /// known edges count equal to their ref count.  Finally, there will be
    /// a call to end().  If begin() returns an error none of the other
    /// functions will be called.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3f3901bb-6a1c-4998-b32e-6f10a51db470")]
	public interface nsICycleCollectorListener
	{
		
		/// <summary>
        ///Interface to pass to the cycle collector to get information about
        /// the CC graph while it's being built. The order of calls will be a
        /// call to begin(); then for every node in the graph a call to either
        /// noteRefCountedObject() or noteGCedObject(), followed by calls to
        /// noteEdge() for every edge starting at that node; then a call to
        /// beginResults(); then a mixture of describeRoot() for ref counted
        /// nodes the CC has identified as roots and describeGarbage() for
        /// nodes the CC has identified as garbage.  Ref counted nodes that are
        /// not identified as either roots or garbage are neither, and have a
        /// known edges count equal to their ref count.  Finally, there will be
        /// a call to end().  If begin() returns an error none of the other
        /// functions will be called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Begin();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NoteRefCountedObject(ulong aAddress, uint aRefCount, [MarshalAs(UnmanagedType.LPStr)] string aObjectDescription);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NoteGCedObject(ulong aAddress, [MarshalAs(UnmanagedType.U1)] bool aMarked, [MarshalAs(UnmanagedType.LPStr)] string aObjectDescription);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NoteEdge(ulong aToAddress, [MarshalAs(UnmanagedType.LPStr)] string aEdgeName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginResults();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DescribeRoot(ulong aAddress, uint aKnownEdges);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DescribeGarbage(ulong aAddress);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void End();
	}
}

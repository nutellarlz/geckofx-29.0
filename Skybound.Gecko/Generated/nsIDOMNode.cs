// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMNode.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMNode.idl
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
	
	
	/// <summary>nsIDOMNode </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a6cf907c-15b3-11d2-932e-00805f8add32")]
	public interface nsIDOMNode
	{
		
		/// <summary>Member GetNodeNameAttribute </summary>
		/// <param name='aNodeName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNodeNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		/// <summary>Member GetNodeValueAttribute </summary>
		/// <param name='aNodeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		/// <summary>Member SetNodeValueAttribute </summary>
		/// <param name='aNodeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		/// <summary>Member GetNodeTypeAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetNodeTypeAttribute();
		
		/// <summary>Member GetParentNodeAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode  GetParentNodeAttribute();
		
		/// <summary>Member GetChildNodesAttribute </summary>
		/// <returns>A nsIDOMNodeList </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList  GetChildNodesAttribute();
		
		/// <summary>Member GetFirstChildAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode  GetFirstChildAttribute();
		
		/// <summary>Member GetLastChildAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode  GetLastChildAttribute();
		
		/// <summary>Member GetPreviousSiblingAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode  GetPreviousSiblingAttribute();
		
		/// <summary>Member GetNextSiblingAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode  GetNextSiblingAttribute();
		
		/// <summary>Member GetAttributesAttribute </summary>
		/// <returns>A nsIDOMNamedNodeMap </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNamedNodeMap  GetAttributesAttribute();
		
		/// <summary>Member GetOwnerDocumentAttribute </summary>
		/// <returns>A nsIDOMDocument </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument  GetOwnerDocumentAttribute();
		
		/// <summary>Member InsertBefore </summary>
		/// <param name='newChild'> </param>
		/// <param name='refChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode  refChild);
		
		/// <summary>Member ReplaceChild </summary>
		/// <param name='newChild'> </param>
		/// <param name='oldChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode  oldChild);
		
		/// <summary>Member RemoveChild </summary>
		/// <param name='oldChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  oldChild);
		
		/// <summary>Member AppendChild </summary>
		/// <param name='newChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  newChild);
		
		/// <summary>Member HasChildNodes </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasChildNodes();
		
		/// <summary>Member CloneNode </summary>
		/// <param name='deep'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode CloneNode(System.Boolean  deep);
		
		/// <summary>Member Normalize </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Normalize();
		
		/// <summary>Member IsSupported </summary>
		/// <param name='feature'> </param>
		/// <param name='version'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature, [MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		/// <summary>Member GetNamespaceURIAttribute </summary>
		/// <param name='aNamespaceURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNamespaceURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);
		
		/// <summary>Member GetPrefixAttribute </summary>
		/// <param name='aPrefix'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		/// <summary>Member SetPrefixAttribute </summary>
		/// <param name='aPrefix'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		/// <summary>Member GetLocalNameAttribute </summary>
		/// <param name='aLocalName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLocalNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		/// <summary>Member HasAttributes </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasAttributes();
	}
}
// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: imgIContainerObserver.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file imgIContainerObserver.idl
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
	
	
	/// <summary>imgIContainerObserver </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("aa2068c1-6b91-4f52-8603-487b14ac5f04")]
	public interface imgIContainerObserver
	{
		
		/// <summary>Member FrameChanged </summary>
		/// <param name='aContainer'> </param>
		/// <param name='aDirtyRect'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FrameChanged(imgIContainer  aContainer, [MarshalAs(UnmanagedType.Interface)] nsIntRect  aDirtyRect);
	}
}
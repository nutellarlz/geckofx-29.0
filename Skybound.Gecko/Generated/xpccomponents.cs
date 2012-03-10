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
// Generated by IDLImporter from file xpccomponents.idl
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
    /// interface of Components.interfacesByID
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c99cffac-5aed-4267-ad2f-f4a4c9d4a081")]
	public interface nsIXPCComponents_InterfacesByID
	{
	}
	
	/// <summary>
    /// interface of Components.interfaces
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b8c31bba-79db-4a1d-930d-4cdd68713f9e")]
	public interface nsIXPCComponents_Interfaces
	{
	}
	
	/// <summary>
    /// interface of Components.classes
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("978ff520-d26c-11d2-9842-006008962422")]
	public interface nsIXPCComponents_Classes
	{
	}
	
	/// <summary>
    /// interface of Components.classesByID
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("336a9590-4d19-11d3-9893-006008962422")]
	public interface nsIXPCComponents_ClassesByID
	{
	}
	
	/// <summary>
    /// interface of Components.results
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2fc229a0-5860-11d3-9899-006008962422")]
	public interface nsIXPCComponents_Results
	{
	}
	
	/// <summary>
    /// interface of Components.ID
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7994a6e0-e028-11d3-8f5d-0010a4e73d9a")]
	public interface nsIXPCComponents_ID
	{
	}
	
	/// <summary>
    /// interface of Components.Exception
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5bf039c0-e028-11d3-8f5d-0010a4e73d9a")]
	public interface nsIXPCComponents_Exception
	{
	}
	
	/// <summary>
    /// interface of Components.Constructor
    /// (interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("88655640-e028-11d3-8f5d-0010a4e73d9a")]
	public interface nsIXPCComponents_Constructor
	{
	}
	
	/// <summary>
    /// interface of object returned by Components.Constructor
    /// (additional interesting stuff only reflected into JavaScript) </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c814ca20-e0dc-11d3-8f5f-0010a4e73d9a")]
	public interface nsIXPCConstructor
	{
		
		/// <summary>
        /// interface of object returned by Components.Constructor
        /// (additional interesting stuff only reflected into JavaScript) </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIJSCID GetClassIDAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIJSIID GetInterfaceIDAttribute();
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetInitializerAttribute();
	}
	
	/// <summary>
    /// interface of object returned by Components.utils.Sandbox. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4f8ae0dc-d266-4a32-875b-6a9de71a8ce9")]
	public interface nsIXPCComponents_utils_Sandbox
	{
	}
	
	/// <summary>
    /// interface for callback to be passed to Cu.schedulePreciseGC
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("71000535-b0fd-44d1-8ce0-909760e3953c")]
	public interface ScheduledGCCallback
	{
		
		/// <summary>
        /// interface for callback to be passed to Cu.schedulePreciseGC
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Callback();
	}
	
	/// <summary>
    /// interface of Components.utils </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b032a8f1-9149-4cbe-bee6-4ac5dfe7c80a")]
	public interface nsIXPCComponents_Utils
	{
		
		/// <summary>
        ///reportError is designed to be called from JavaScript only.
        ///
        /// It will report a JS Error object to the JS console, and return. It
        /// is meant for use in exception handler blocks which want to "eat"
        /// an exception, but still want to report it to the console.
        ///
        /// It must be called with one param, usually an object which was caught by
        /// an exception handler.  If it is not a JS error object, the parameter
        /// is converted to a string and reported as a new error.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReportError(System.IntPtr error, System.IntPtr jsContext);
		
		/// <summary>
        ///lookupMethod is designed to be called from JavaScript only.
        ///
        /// It returns a method looking only at the idl interfaces and
        /// ignores any overrides or resolvers that might be in place for
        /// a given scriptable wrapped native.
        /// It must be called with two params: an object and a method name.
        /// It returns a function object or throws an exception on error.
        /// This method exists only to solve mozilla browser problems
        /// when chrome attempts to lookup and call methods in content
        /// and *must* not get confused by method properties that have been
        /// replaced in the content JS code. This method is not recommended for
        /// any other use.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr LookupMethod(System.IntPtr obj, System.IntPtr name, System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPCComponents_utils_Sandbox GetSandboxAttribute();
		
		/// <summary>
        /// evalInSandbox is designed to be called from JavaScript only.
        ///
        /// evalInSandbox evaluates the provided source string in the given sandbox.
        /// It returns the result of the evaluation to the caller.
        ///
        /// var s = new C.u.Sandbox("http://www.mozilla.org");
        /// var res = C.u.evalInSandbox("var five = 5; 2 + five", s);
        /// var outerFive = s.five;
        /// s.seven = res;
        /// var thirtyFive = C.u.evalInSandbox("five * seven", s);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr EvalInSandbox([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase source, System.IntPtr sandbox, System.IntPtr version, System.IntPtr filename, int lineNo, System.IntPtr jsContext, int argc);
		
		/// <summary>
        /// import is designed to be called from JavaScript only.
        ///
        /// Synchronously loads and evaluates the js file located at
        /// 'registryLocation' with a new, fully privileged global object.
        ///
        /// If 'targetObj' is specified and equal to null, returns the
        /// module's global object. Otherwise (if 'targetObj' is not
        /// specified, or 'targetObj' is != null) looks for a property
        /// 'EXPORTED_SYMBOLS' on the new global object. 'EXPORTED_SYMBOLS'
        /// is expected to be an array of strings identifying properties on
        /// the global object.  These properties will be installed as
        /// properties on 'targetObj', or, if 'targetObj' is not specified,
        /// on the caller's global object. If 'EXPORTED_SYMBOLS' is not
        /// found, an error is thrown.
        ///
        /// @param resourceURI A resource:// URI string to load the module from.
        /// @param targetObj  the object to install the exported properties on.
        /// If this parameter is a primitive value, this method throws
        /// an exception.
        /// @returns the module code's global object.
        ///
        /// The implementation maintains a hash of registryLocation->global obj.
        /// Subsequent invocations of importModule with 'registryLocation'
        /// pointing to the same file will not cause the module to be re-evaluated,
        /// but the symbols in EXPORTED_SYMBOLS will be exported into the
        /// specified target object and the global object returned as above.
        ///
        /// (This comment is duplicated from xpcIJSModuleLoader.)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr Import([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aResourceURI, System.IntPtr targetObj, System.IntPtr jsContext, int argc);
		
		/// <summary>
        /// Unloads the JS module at 'registryLocation'. Existing references to the
        /// module will continue to work but any subsequent import of the module will
        /// reload it and give new reference. If the JS module hasn't yet been
        /// imported then this method will do nothing.
        ///
        /// @param resourceURI A resource:// URI string to unload the module from.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Unload([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase registryLocation);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Return a weak reference for the given JS object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		xpcIJSWeakReference GetWeakReference(System.IntPtr obj, System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Force an immediate garbage collection cycle.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceGC(System.IntPtr jsContext);
		
		/// <summary>
        /// Schedule a garbage collection cycle for a point in the future when no JS
        /// is running. Call the provided function once this has occurred.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SchedulePreciseGC(ScheduledGCCallback callback, System.IntPtr jsContext);
		
		/// <summary>
        /// Return the keys in a weak map.  This operation is
        /// non-deterministic because it is affected by the scheduling of the
        /// garbage collector and the cycle collector.
        ///
        /// This should only be used to write tests of the interaction of
        /// the GC and CC with weak maps.
        ///
        /// @param aMap weak map or other JavaScript value
        /// @returns If aMap is a weak map object, return the keys of the weak
        ///                map as an array.  Otherwise, return undefined.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr NondeterministicGetWeakMapKeys(System.IntPtr aMap, System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Returns the global object with which the given object is associated.
        ///
        /// @param obj The JavaScript object whose global is to be gotten.
        /// @return the corresponding global.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetGlobalForObject(System.IntPtr obj, System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Returns an object created in |vobj|'s compartment.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr CreateObjectIn(System.IntPtr vobj, System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// Ensures that all functions come from vobj's scope (and aren't cross
        /// compartment wrappers).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MakeObjectPropsNormal(System.IntPtr vobj, System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// These are the set of JSContext options that privileged script
        /// is allowed to control for the purposes of testing.  These
        /// options should be kept in sync with what's controllable in the
        /// jsshell and by setting prefs in nsJSEnvironment.
        ///
        /// NB: Assume that getting any of these attributes is relatively
        /// cheap, but setting any of them is relatively expensive.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetStrictAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// To be called from JS only.
        ///
        /// These are the set of JSContext options that privileged script
        /// is allowed to control for the purposes of testing.  These
        /// options should be kept in sync with what's controllable in the
        /// jsshell and by setting prefs in nsJSEnvironment.
        ///
        /// NB: Assume that getting any of these attributes is relatively
        /// cheap, but setting any of them is relatively expensive.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStrictAttribute([MarshalAs(UnmanagedType.U1)] bool aStrict, System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetWerrorAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWerrorAttribute([MarshalAs(UnmanagedType.U1)] bool aWerror, System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAtlineAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAtlineAttribute([MarshalAs(UnmanagedType.U1)] bool aAtline, System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetXmlAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXmlAttribute([MarshalAs(UnmanagedType.U1)] bool aXml, System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRelimitAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRelimitAttribute([MarshalAs(UnmanagedType.U1)] bool aRelimit, System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMethodjitAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMethodjitAttribute([MarshalAs(UnmanagedType.U1)] bool aMethodjit, System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMethodjit_alwaysAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMethodjit_alwaysAttribute([MarshalAs(UnmanagedType.U1)] bool aMethodjit_always, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetGCZeal(int zeal, System.IntPtr jsContext);
	}
	
	/// <summary>
    /// interface of JavaScript's 'Components' object </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4676e9cf-2c07-423b-b161-26bb9d8067d3")]
	public interface nsIXPCComponents
	{
		
		/// <summary>
        /// interface of JavaScript's 'Components' object </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPCComponents_Interfaces GetInterfacesAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPCComponents_InterfacesByID GetInterfacesByIDAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetClassesAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetClassesByIDAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStackFrame GetStackAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetResultsAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIComponentManager GetManagerAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPCComponents_Utils GetUtilsAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetIDAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetExceptionAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetConstructorAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSuccessCode(int result);
		
		/// <summary>
        ///@deprecated Use Components.utils.lookupMethod instead.
        /// (But are you sure you really want this method any more?
        /// See http://developer-test.mozilla.org/en/docs/XPCNativeWrapper )
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr LookupMethod(System.IntPtr obj, System.IntPtr name, System.IntPtr jsContext);
		
		/// <summary>
        ///@deprecated Use Components.utils.reportError instead. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReportError(System.IntPtr error, System.IntPtr jsContext);
	}
}

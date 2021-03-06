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
// Generated by IDLImporter from file nsIWifi.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cf1ac02b-1f39-446e-815b-651ac78d2233")]
	public interface nsIWifiScanResult
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSsidAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSsid);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBssidAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBssid);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCapabilitiesAttribute();
		
		/// <summary>
        /// Strength of the signal to network.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetSignalStrengthAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRelSignalStrengthAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetConnectedAttribute();
	}
	
	/// <summary>nsIWifiScanResultConsts </summary>
	public class nsIWifiScanResultConsts
	{
		
		// 
		public const long WPA_PSK = 0x01;
		
		// 
		public const long WPA_EAP = 0x02;
		
		// 
		public const long WEP = 0x04;
	}
	
	/// <summary>nsIWifiScanResultsReady </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a6931ebf-8493-4014-90e2-99f406999982")]
	public interface nsIWifiScanResultsReady
	{
		
		/// <summary>
        /// Callback with list of networks.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Onready(uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] nsIWifiScanResult[] results);
		
		/// <summary>
        /// Callback if scanning for networks failed after 3 retry attempts.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Onfailure();
	}
	
	/// <summary>nsIWifi </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("08dfefed-5c5d-4468-8c5d-2c65c24692d9")]
	public interface nsIWifi
	{
		
		/// <summary>
        /// Shutdown the wifi system.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Shutdown();
		
		/// <summary>
        /// Returns the list of currently available networks as well as the list of
        /// currently configured networks.
        ///
        /// On success a callback is notified with the list of networks.
        /// On failure after 3 scan retry attempts a callback is notified of failure.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetWifiScanResults([MarshalAs(UnmanagedType.Interface)] nsIWifiScanResultsReady callback);
	}
	
	/// <summary>nsIDOMWifiManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e5a72295-1c5f-4848-9cbb-f1d3785c16c1")]
	public interface nsIDOMWifiManager
	{
		
		/// <summary>
        /// Returns the list of currently available networks.
        /// onsuccess: We have obtained the current list of networks. request.value
        /// is an object whose property names are SSIDs and values are
        /// network objects.
        /// onerror: We were unable to obtain a list of property names.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetNetworks();
		
		/// <summary>
        /// Returns the list of networks known to the system that will be
        /// automatically connected to if they're in range.
        /// onsuccess: request.value is an object whose property names are
        /// SSIDs and values are network objects.
        /// onerror: We were unable to obtain a list of known networks.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest GetKnownNetworks();
		
		/// <summary>
        /// Takes one of the networks returned from getNetworks and tries to
        /// connect to it.
        /// @param network A network object with information about the network,
        /// such as the SSID, key management desired, etc.
        /// onsuccess: We have started attempting to associate with the network.
        /// request.value is true.
        /// onerror: We were unable to select the network. This most likely means a
        /// configuration error.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest Associate(Gecko.JsVal network);
		
		/// <summary>
        /// Given a network, removes it from the list of networks that we'll
        /// automatically connect to. In order to re-connect to the network, it is
        /// necessary to call associate on it.
        /// @param network A network object with the SSID of the network to remove.
        /// onsuccess: We have removed this network. If we were previously
        /// connected to it, we have started reconnecting to the next
        /// network in the list.
        /// onerror: We were unable to remove the network.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest Forget(Gecko.JsVal network);
		
		/// <summary>
        /// Wi-Fi Protected Setup functionality.
        /// @param detail WPS detail which has 'method' and 'pin' field.
        /// The possible method field values are:
        /// - pbc: The Push Button Configuration.
        /// - pin: The PIN configuration.
        /// - cancel: Request to cancel WPS in progress.
        /// If method field is 'pin', 'pin' field can exist and has
        /// a PIN number.
        /// If method field is 'pin', 'bssid' field can exist and has
        /// a opposite BSSID.
        /// onsuccess: We have successfully started/canceled wps.
        /// onerror: We have failed to start/cancel wps.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest Wps(Gecko.JsVal detail);
		
		/// <summary>
        /// Turn on/off wifi power saving mode.
        /// @param enabled true or false.
        /// onsuccess: We have successfully turn on/off wifi power saving mode.
        /// onerror: We have failed to turn on/off wifi power saving mode.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SetPowerSavingMode([MarshalAs(UnmanagedType.U1)] bool enabled);
		
		/// <summary>
        /// Given a network, configure using static IP instead of running DHCP
        /// @param network A network object with the SSID of the network to set static ip.
        /// @param info info should have following field:
        /// - enabled True to enable static IP, false to use DHCP
        /// - ipaddr configured static IP address
        /// - proxy configured proxy server address
        /// - maskLength configured mask length
        /// - gateway configured gateway address
        /// - dns1 configured first DNS server address
        /// - dns2 configured seconf DNS server address
        /// onsuccess: We have successfully configure the static ip mode.
        /// onerror: We have failed to configure the static ip mode.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SetStaticIpMode(Gecko.JsVal network, Gecko.JsVal info);
		
		/// <summary>
        /// Given a network, configure http proxy when using wifi.
        /// @param network A network object with the SSID of the network to set http proxy.
        /// @param info info should have following field:
        /// - httpProxyHost ip address of http proxy.
        /// - httpProxyPort port of http proxy, set 0 to use default port 8080.
        /// set info to null to clear http proxy.
        /// onsuccess: We have successfully configure http proxy.
        /// onerror: We have failed to configure http proxy.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMRequest SetHttpProxy(Gecko.JsVal network, Gecko.JsVal info);
		
		/// <summary>
        /// Returns whether or not wifi is currently enabled.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetEnabledAttribute();
		
		/// <summary>
        /// Returns the MAC address of the wifi adapter.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMacAddressAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMacAddress);
		
		/// <summary>
        /// An non-null object containing the following information:
        /// - status ("disconnected", "connecting", "associated", "connected")
        /// - network
        ///
        /// Note that the object returned is read only. Any changes required must
        /// be done by calling other APIs.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetConnectionAttribute();
		
		/// <summary>
        /// A connectionInformation object with the same information found in an
        /// nsIDOMMozWifiConnectionInfoEvent (but without the network).
        /// If we are not currently connected to a network, this will be null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetConnectionInformationAttribute();
		
		/// <summary>
        /// State notification listeners. These all take an
        /// nsIDOMMozWifiStatusChangeEvent with the new status and a network (which
        /// may be null).
        ///
        /// The possible statuses are:
        /// - connecting: Fires when we start the process of connecting to a
        /// network.
        /// - associated: Fires when we have connected to an access point but do
        /// not yet have an IP address.
        /// - connected: Fires once we are fully connected to an access point and
        /// can access the internet.
        /// - disconnected: Fires when we either fail to connect to an access
        /// point (transition: associated -> disconnected) or
        /// when we were connected to a network but have
        /// disconnected for any reason (transition: connected ->
        /// disconnected).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnstatuschangeAttribute();
		
		/// <summary>
        /// State notification listeners. These all take an
        /// nsIDOMMozWifiStatusChangeEvent with the new status and a network (which
        /// may be null).
        ///
        /// The possible statuses are:
        /// - connecting: Fires when we start the process of connecting to a
        /// network.
        /// - associated: Fires when we have connected to an access point but do
        /// not yet have an IP address.
        /// - connected: Fires once we are fully connected to an access point and
        /// can access the internet.
        /// - disconnected: Fires when we either fail to connect to an access
        /// point (transition: associated -> disconnected) or
        /// when we were connected to a network but have
        /// disconnected for any reason (transition: connected ->
        /// disconnected).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnstatuschangeAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnstatuschange);
		
		/// <summary>
        /// An event listener that is called with information about the signal
        /// strength and link speed every 5 seconds.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetConnectionInfoUpdateAttribute();
		
		/// <summary>
        /// An event listener that is called with information about the signal
        /// strength and link speed every 5 seconds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetConnectionInfoUpdateAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aConnectionInfoUpdate);
		
		/// <summary>
        /// These two events fire when the wifi system is brought online or taken
        /// offline.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnenabledAttribute();
		
		/// <summary>
        /// These two events fire when the wifi system is brought online or taken
        /// offline.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnenabledAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnenabled);
		
		/// <summary>Member GetOndisabledAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOndisabledAttribute();
		
		/// <summary>Member SetOndisabledAttribute </summary>
		/// <param name='aOndisabled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndisabledAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOndisabled);
	}
}

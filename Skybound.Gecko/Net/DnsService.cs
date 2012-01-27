﻿using System;
using System.Linq;
using System.Text;
using Gecko.Collections;

namespace Gecko.Net
{
	//IAsyncResult

	public sealed class DnsService
	{
		private nsIDNSService _dnsService;

		public DnsService()
		{
			var dnsService = Xpcom.CreateInstance<nsIDNSService>( Contracts.DnsService );
			_dnsService = Xpcom.QueryInterface<nsIDNSService>( dnsService );
		}

		public string MyHostName
		{
			get { return nsString.Get( _dnsService.GetMyHostNameAttribute ); }
		}

		/// <summary>
		/// called to synchronously resolve a hostname.  warning this method may
		/// block the calling thread for a long period of time.  it is extremely
		/// unwise to call this function on the UI thread of an application.
		/// </summary>
		/// <param name="hostName"></param>
		/// <param name="flags"></param>
		/// <returns></returns>
		public DnsRecord Resolve(string hostName,ResolveFlags flags)
		{
			if (hostName==null)
			{
				throw new ArgumentException( "parameter cannot be null", "hostName" );
			}
			nsIDNSRecord record = null;
			using (nsAUTF8String value=new nsAUTF8String(hostName) )
			{
				record=_dnsService.Resolve(value, (uint)flags);
			}
			return record == null ? null : new DnsRecord( record );
		}
	}

	[Flags]
	public enum ResolveFlags
	{
		/// <summary>
		/// This flag suppresses the internal DNS lookup cache.
		/// </summary>
		ByPassCache=1<<0,
		/// <summary>
		/// The canonical name of the specified host will be queried.
		/// </summary>
		CanonicalName=1<<1,
		/// <summary>
		/// The query is given medium priority. If used with low, medium takes precedence.
		/// </summary>
		PriorityMedium=1<<2,
		/// <summary>
		/// The query is given lower priority. If used with medium, medium takes precedence.
		/// </summary>
		PriorityLow=1<<3,
		/// <summary>
		/// Indicates request is speculative. Speculative requests return errors if prefetching is disabled by configuration.
		/// </summary>
		Speculate=1<<4,
		/// <summary>
		/// If this flag is set, only IPv4 addresses will be returned by AsyncResolve() and Resolve()
		/// </summary>
		DisableIpV6=1<<5
	}
	
}
using System;
using System.Collections.Generic;

namespace Gecko.Cache
{
	public sealed class CacheService
	{
		private nsICacheService _cacheService;

		public CacheService()
		{
			var cacheService = Xpcom.GetService<nsICacheService>("@mozilla.org/network/cache-service;1");
			_cacheService = Xpcom.QueryInterface<nsICacheService>(cacheService);
		}

		public CacheSession CreateSession(string clientID, CacheStoragePolicy storagePolicy, bool streamBased)
		{
			return new CacheSession(_cacheService.CreateSession(clientID, (IntPtr)(int)storagePolicy, streamBased));
		}

		public string[] Search(string deviceID, Predicate<CacheEntryInfo> predicate)
		{
			string[] ret = null;
			using (var searcher = new CacheSearcher(predicate))
			{
				_cacheService.VisitEntries(searcher);
				ret = searcher.GetResult();
			}
			return ret;
		}

		/// <summary>
		/// Returns key's of founded entries
		/// 
		/// WARNING. We can't return all CacheEntryInfo entity because after search in becomes invalid :(
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public string[] Search(Predicate<CacheEntryInfo> predicate)
		{
			string[] ret = null;
			using (var searcher = new CacheSearcher(predicate))
			{
				_cacheService.VisitEntries( searcher );
				ret = searcher.GetResult();
			}
			return ret;
		}

		public static readonly string MemoryCacheDevice = "memory";
		public static readonly string DiskCacheDevice = "disk";
	}

	internal sealed class CacheSearcher
		: nsICacheVisitor,IDisposable
	{
		private Predicate<CacheEntryInfo> _predicate;
		private string _deviceID;

		private List<string> _foundEntries = new List<string>();

		internal CacheSearcher(Predicate<CacheEntryInfo> predicate)
			:this(null,predicate)
		{
			
		}

		internal CacheSearcher(string deviceID, Predicate<CacheEntryInfo> predicate)
		{
			_deviceID = deviceID;
			_predicate = predicate;
		}

		~CacheSearcher()
		{
			_foundEntries.Clear();
		}

		public void Dispose()
		{
			_foundEntries.Clear();
			GC.SuppressFinalize( this );
		}

		public bool VisitDevice( string deviceID, nsICacheDeviceInfo deviceInfo )
		{
			if (string.IsNullOrEmpty(_deviceID)) return true;
			return string.Equals( _deviceID, deviceID );
		}

		public bool VisitEntry( string deviceID, nsICacheEntryInfo entryInfo )
		{
			var entry = new CacheEntryInfo(entryInfo);
			if (_predicate(entry))
			{
				_foundEntries.Add( entry.Key );
			}
			return true;
		}

		public string[] GetResult()
		{
			return _foundEntries.ToArray();
		}
		
	}

	public enum CacheStoragePolicy
	{
		Anywhere = 0,
		InMemory = 1,
		OnDisk = 2,
		OnDiskAsFile = 3,
		Offline = 4
	}
}
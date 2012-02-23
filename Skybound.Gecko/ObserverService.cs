namespace Gecko
{
	public sealed class ObserverService
	{
		private nsIObserverService _observerService;

		public ObserverService()
		{
			var serv = Xpcom.GetService<nsIObserverService>(Contracts.ObserverService);
			_observerService = Xpcom.QueryInterface<nsIObserverService>( serv );
			
		}

		public void AddObserver(nsIObserver observer,string topic,bool ownsWeak)
		{
			_observerService.AddObserver( observer, topic, ownsWeak );
		}

		public void RemoveObserver(nsIObserver observer,string topic)
		{
			_observerService.RemoveObserver( observer, topic );
		}

		public void AddObserver(Observers.BaseBaseHttpModifyRequestObserver observer)
		{
			_observerService.AddObserver( observer, ObserverNotifications.HttpRequests.HttpOnModifyRequest, false );
		}

		public void RemoveObserver(Observers.BaseBaseHttpModifyRequestObserver observer)
		{
			_observerService.RemoveObserver(observer, ObserverNotifications.HttpRequests.HttpOnModifyRequest);
		}
	}
}
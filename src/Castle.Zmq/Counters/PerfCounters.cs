namespace Castle.Zmq.Counters
{
	using System.Linq;

	public static class PerfCounters
	{
		//public const string NumberOfRequestsReceived = "# of Requests Received / sec";
		//public const string NumberOfResponseSent = "# of Response Sent / sec";

		//public const string NumberOfRequestsSent = "# of Response Received / sec";
		//public const string NumberOfResponseReceived = "# of Requests Sent / sec";

		//public const string AverageReplyTime = "Average Reply Time";
		//public const string AverageRequestTime = "Average Request Time";

		//public const string NumberOfCallForwardedToFrontend = "# of Forwarded To Frontend / sec";
		//public const string NumberOfCallForwardedToBackend = "# of Forwarded To Backend / sec";

		//public const string BaseReplyTime = "Base Average Reply Time";
		//public const string BaseRequestTime = "Base Average Request Time";


		public static string Metric(string svc, string method)
		{
			var p = svc.Split(',');

			var s = p.Length > 0 ? p[0] : svc;

			return  ("zmq." + s.Substring(s.LastIndexOf('.') + 1) + "." + method).ToLower();
		}
	}
}
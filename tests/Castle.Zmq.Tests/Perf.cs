namespace Castle.Zmq.Tests
{
	using Counters;
	using NUnit.Framework;

	[TestFixture]
	public class Perf
	{
		[Test]
		public void Naming()
		{
			var name = GetType().AssemblyQualifiedName;
			var svc = name.Split(',')[0];

			Assert.AreEqual("Perf", svc.Substring(svc.LastIndexOf('.') + 1));
			Assert.AreEqual("zmq.perf.naming", PerfCounters.Metric(name, "Naming"));
		}
	}
}
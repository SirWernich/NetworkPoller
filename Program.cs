using System;
using System.Threading;
using System.Threading.Tasks;

namespace NetworkPoller
{
	class Program
	{
		static void Main(string[] args)
		{
			Network.Poller poller = new Network.Poller();
			poller.Start(new CancellationTokenSource().Token);
		}
	}
}

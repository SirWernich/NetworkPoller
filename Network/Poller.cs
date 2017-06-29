using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NetworkPoller.Network
{
	public class Poller
	{
		public void Start(CancellationToken token)
		{
			UdpClient client = new UdpClient(5021);
			string ip = getIpAddress().ToString();

			try
			{
				Sender sender = new Sender(client, ip);

				while (true)
				{

				}
			}
			catch (AggregateException ae)
			{

			}
		}

		private IPAddress getIpAddress()
		{
			string hostname = Dns.GetHostName();
			//IPAddress[] ipEntries = Dns.GetHostAddresses(hostname);
			//var hostInfo = Dns.GetHostEntry(hostname);
			return new IPAddress(new byte[] { 1, 2, 3, 4 });
		}
	}
}
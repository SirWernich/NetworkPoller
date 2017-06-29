using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace NetworkPoller.Network
{
	public class Sender
	{
		private UdpClient udpClient;
		private string mac = "c8:21:58:81:98:5e";
		private int counter = 0;
		private string ipAddress;

		public Sender(UdpClient client, string ip)
		{
			udpClient = client;
			ipAddress = ip;
		}

		public void Send(string[] args)
		{

		}

	}
}











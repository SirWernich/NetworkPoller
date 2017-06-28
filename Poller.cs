using System.Net.Sockets;

namespace NetworkPoller.Network
{
    public class Poller
    {
        public void Start(CancellatioToken token) 
        {
            UdpClient client = new UdpClient(5021);
            
            try 
            {
                while (true)
                {
                    client.
                }
            }
            catch (AggregateException ae)
            {
                
            }
        }
    }
}
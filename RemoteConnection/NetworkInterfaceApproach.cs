using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RemoteConnection
{
    public class NetworkInterfaceApproach
    {
        public List<Adapter> DisplayGatewayAddresses()
        {
            var _adapters = new List<Adapter>();

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters.Where(p => p.OperationalStatus == OperationalStatus.Up))
            {
                var _adapter = new Adapter() { GatewayAddress = new List<string>(), InternalIPAddress = new List<string>(), NetworkIPDetails = new List<IPDetails>() };
                _adapter.ComputerName = Dns.GetHostName();

                _adapter.Name = adapter.Name;
                _adapter.Description = adapter.Description;
                _adapter.NetworkInterfaceType = adapter.NetworkInterfaceType.ToString();
                _adapter.DNSName = string.Empty;

                foreach (GatewayIPAddressInformation address in adapter.GetIPProperties().GatewayAddresses)
                {
                    _adapter.GatewayAddress.Add(address.Address.ToString());
                }

                foreach (UnicastIPAddressInformation ip in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        _adapter.InternalIPAddress.Add(ip.Address.ToString());
                        if (!ip.IPv4Mask.ToString().Equals("0.0.0.0"))
                            _adapter.SubNetMask = ip.IPv4Mask.ToString();
                    }
                }
                _adapters.Add(_adapter);
            }
            return _adapters;
        }

        /// <summary>
        /// This will ping all combinations at Level 1. I.e. at 255.255.255.*
        /// Also only for Ethernet and Wireless Connections
        /// </summary>
        /// <param name="_adapters"></param>
        public void PingAllPossibleCombinations(List<Adapter> _adapters)
        {
            _adapters.ForEach(p =>
            {
                if (p.NetworkInterfaceType.Contains("Ethernet") || p.NetworkInterfaceType.Contains("Wireless"))
                {
                    p.InternalIPAddress.ForEach(k =>
                    {
                        var startIP = k.Substring(0, k.LastIndexOf("."));

                        ConcurrentBag<bool> values = new ConcurrentBag<bool>();
                        Parallel.For(0, 255, (x, y) => values.Add(PingUsingCmdPrompt(startIP + "." + x.ToString())));
                    });
                };
            });
        }

        public bool PingUsingCmdPrompt(string nameOrAdddress) {
            System.Diagnostics.ProcessStartInfo _processStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + "ping " + nameOrAdddress);
            _processStartInfo.RedirectStandardOutput = true;
            _processStartInfo.UseShellExecute = false;
            _processStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process _process = new System.Diagnostics.Process();
            _process.StartInfo = _processStartInfo;
            _process.Start();

            var _result = _process.StandardOutput;

            return PingOutputParse(_result);
        }

        private bool PingOutputParse(System.IO.StreamReader pingOutput) {
            var _roundTrip = false;
            var _outputLine = string.Empty;

            //A ping can be only considered success if there is a round trip
            while (((_outputLine = pingOutput.ReadLine()) != null)) {
                if (_outputLine.Contains("Approximate round trip times in milli-seconds"))
                    _roundTrip = true;
            }

            return _roundTrip;
        }


        /// <summary>
        /// This PING function is not reliable with Wifi Networks.
        /// </summary>
        /// <param name="nameOrAddress"></param>
        /// <returns></returns>
        [Obsolete("This PING function is not reliable with Wifi Networks. Use PingUsingCmdPrompt() method.")]
        public PingReply PingHost(string nameOrAddress)
        {
            PingReply _pingResult = null;
            using (var pinger = new Ping())
            {
                _pingResult = pinger.Send(nameOrAddress);
                return _pingResult;
            }
        }
    }
}

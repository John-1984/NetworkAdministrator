using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteConnection
{
    public class Computer {
        public string ComputerName { get; set; }
    }
    public class Adapter: Computer
    {
        public string DNSName { get; set; }
        public List<IPDetails> NetworkIPDetails { get; set; }
        public List<string> GatewayAddress { get; set; }
        public List<string> InternalIPAddress { get; set; }
        public string NetworkInterfaceType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SubNetMask { get; set; }
    }

    public class InternalIPAddress {
        public string InternalIP { get; set; }
    }

    public class IPDetails : InternalIPAddress
    {
        public string IP { get; set; }
        public string MacAddress { get; set; }
        public string IPType { get; set; } //Dynamic OR Static
        public string HostName { get; set; }
        public DotNMap.nmaprun NMapRun { get; set; }
    }

    public class OSMatch {
        public string OSName { get; set; }
        public string Accuracy { get; set; }
        public string DeviceType { get; set; }
    }

    public class Port
    {
        public string PortID { get; set; }
        public string State { get; set; }
        public string ServiceName { get; set; }
        public string Protocol { get; set; }
    }
}

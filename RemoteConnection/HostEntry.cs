using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RemoteConnection
{
    public class HostEntry
    {
        /// <summary>
        /// Obselete method
        /// </summary>
        /// <returns></returns>
        [Obsolete("ARP Table method will retrieve all relevant info")]
        public List<IPDetails> GetLocalIPAddress()
        {
            var _lstIP = new List<IPDetails>();
            var _host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in _host.AddressList) {
                _lstIP.Add(new IPDetails(){ IP = ip.ToString(), InternalIP = string.Empty , HostName = _host.HostName});
            }

            return _lstIP;
        }

        /// <summary>
        /// Obselete Method
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        [Obsolete("ARP Table method will retrieve all relevant info")]
        public List<IPDetails> GetLocalIPAddress(string ipAddress)
        {
            var _lstIP = new List<IPDetails>();
            var _host = Dns.GetHostEntry(System.Net.IPAddress.Parse(ipAddress));
            foreach (IPAddress ip in _host.AddressList)
            {
                _lstIP.Add(new IPDetails() { IP = ip.ToString(), InternalIP = ipAddress, HostName = _host.HostName });
            }

            return _lstIP;
        }

        public string GetHostName(string ipAddress)
        {
            try
            {
                var _host = Dns.GetHostEntry(System.Net.IPAddress.Parse(ipAddress));

                return _host.HostName;
            }
            catch (Exception)
            {
                return string.Empty;
            }
            
        }
    }
}

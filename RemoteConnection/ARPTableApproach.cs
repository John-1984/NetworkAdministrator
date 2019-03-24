using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RemoteConnection
{
    public class ARPTableApproach
    {
        private string _internalIP = string.Empty;
        public List<IPDetails> GelARPTableDetails(string ipAddress)
        {
            _internalIP = ipAddress;
            var _ipDetails = new List<IPDetails>();

            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = "arp";
            pProcess.StartInfo.Arguments = "-a " ;
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.Start();
            string cmdOutput = pProcess.StandardOutput.ReadToEnd();

            return ConvertARPToModel(cmdOutput);
        }

        private List<IPDetails> ConvertARPToModel(string arpOutput)
        {
            var _allLines = arpOutput.Split('\n');
            var _allIPDetails = new List<IPDetails>();

            var _newSection = false;
            _allLines.ToList().ForEach(p =>
            {
                if (p.Equals("\r") || p.Equals(string.Empty)) { _newSection = true; }
                else if (_newSection)
                {
                    var _interStr = p.Replace("Interface:", "");
                    var _ip = _interStr.Split(' ').Where(q => !string.IsNullOrEmpty(q) && !q.Equals("\r")).ToArray().First();
                    //Only choose section with specific IP
                    if (_ip.Equals(_internalIP))
                        _newSection = false;
                }
                else
                {
                    if (!p.Contains("Internet"))
                    {
                        var _details = p.Split(' ').Where(q => !string.IsNullOrEmpty(q) && !q.Equals("\r")).ToArray();
                        //Add only valid Pingable IP's. ARP table can have old and inactive values.
                        if (_details.Length > 0 && (new NetworkInterfaceApproach().PingUsingCmdPrompt(_details[0])))
                            _allIPDetails.Add(new IPDetails() { InternalIP = _internalIP, IP = _details[0], MacAddress = _details[1], IPType = _details[2] });
                    }
                }
            });

            return _allIPDetails;
        }
    }

}

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteConnection
{
    /// <summary>
    /// For the SSH commants to work properly, the user has to be added in the etc/sudoers as follows.
    /// john    ALL = (ALL) NOPASSWD: ALL
    /// Otherwise the commands will fail. Instead of the final ALL, you can selectively give the commands like '/sbin/shutdown, /sbin/reboot' 
    /// </summary>
    public partial class NetworkSystems : Form
    {
        public List<Adapter> _adapters = new List<Adapter>();
        private SSHClientAdapter _SShClientAdapter = new SSHClientAdapter();
        public NetworkSystems()
        {
            InitializeComponent();
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            using (ProgressBar _progressBar = new ProgressBar(DetectAction)) {
                _progressBar.ShowDialog(this);

                //If all goes well, then populate screen
                PopulateScreen();
            }
        }

        private void DetectAction() {

            _adapters = new List<Adapter>();

            var _networkInterfaceApproach = new NetworkInterfaceApproach();
            var _allAdapters = _networkInterfaceApproach.DisplayGatewayAddresses();
            _adapters.AddRange(_allAdapters);

            //Ping all Combinations at Level 1. I.e. 255.255.255.*
            //This will populate the ARP table
            _networkInterfaceApproach.PingAllPossibleCombinations(_adapters);

            //Retrieve Network IPS from ARP Table
            var _arpTableApproach = new ARPTableApproach();
            _adapters.ForEach(p => { p.InternalIPAddress.ForEach(k => { p.NetworkIPDetails.AddRange(_arpTableApproach.GelARPTableDetails(k)); }); });

            //Populate Host Name for all Ethernet IP's
            var _hostEntry = new HostEntry();
            _adapters.ForEach(p =>
            {
                if (p.NetworkInterfaceType == "Ethernet")
                {
                    p.NetworkIPDetails.ForEach(k => k.HostName = _hostEntry.GetHostName(k.IP));
                }
            });

            //Run Nmap and get system Details
            //Commenting these codes as these information from NMap is not reliable
            var _allTasks = new List<Task<IPDetails>>();
            _adapters.ForEach(p => { p.NetworkIPDetails.ForEach(k => { _allTasks.Add(this.NMapProcessThread(k)); }); });
            var _results = Task.WhenAll(_allTasks.ToArray());
            //The results will be automaically populated into _adapters model, as its passed by reference.
            _results.Wait();

            //Remove the files created
            new DotNMap.Runner().DeleteFiles();
        }

        private void PopulateScreen()
        {
            treeViewNetworkSystems.Nodes.Clear();
            PopulateTreeView();
        }

        private void PopulateTreeView()
        {
            TreeNode _ethernet = new TreeNode();
            _ethernet.Name = "NodeEthernet";
            _ethernet.Text = "Ethernet";

            _adapters.FindAll(p => p.NetworkInterfaceType.Equals("Ethernet")).ForEach(h =>
            {
                h.NetworkIPDetails.ForEach(k =>
                {
                    _ethernet.Nodes.Add(new TreeNode() { Name = k.MacAddress, Text = string.IsNullOrEmpty(k.HostName) ? k.IP : k.HostName });
                });
            });
            treeViewNetworkSystems.Nodes.Add(_ethernet);

            TreeNode _wireless = new TreeNode();
            _wireless.Name = "NodeWireless";
            _wireless.Text = "Wireless";

            _adapters.FindAll(p => p.NetworkInterfaceType.Contains("Wireless")).ForEach(h =>
            {
                h.NetworkIPDetails.ForEach(k =>
                {
                    _wireless.Nodes.Add(new TreeNode() { Name = k.MacAddress, Text = string.IsNullOrEmpty(k.HostName) ? k.IP : k.HostName });
                });
            });
            treeViewNetworkSystems.Nodes.Add(_wireless);
        }

        private Task<IPDetails> NMapProcessThread(IPDetails _ipDetails)
        {
            var _task = Task.Factory.StartNew(() =>
            {
                _ipDetails.NMapRun = new DotNMap.Runner().Scan(_ipDetails.IP);
                return _ipDetails;
            });
            return _task;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateScreen();
        }

        private void treeViewNetworkSystems_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewNetworkSystems.SelectedNode.Parent != null) //Display details only for child element
            {
                ClearFields();

                var _macAddress = treeViewNetworkSystems.SelectedNode.Name;
                var _ipAddress = treeViewNetworkSystems.SelectedNode.Text;

                var _parent = treeViewNetworkSystems.SelectedNode.Parent.Text;
                if (_parent.Equals("Ethernet")) { }
                else
                {
                    var _selectedAdapter = _adapters.FindAll(p => p.NetworkInterfaceType.Contains("Wireless")).Where(h => h.NetworkIPDetails.Find(q => q.MacAddress.Equals(_macAddress)) != null).FirstOrDefault();
                    var _selectedIPAddress = ((Adapter)_selectedAdapter).NetworkIPDetails.Find(q => q.MacAddress.Equals(_macAddress));
                    DisplaySystemDetails(_selectedAdapter, _selectedIPAddress);
                }
            }
        }

        private void ClearFields() {
            gvOpenPorts.DataSource = null;
            gvOSPossibilities.DataSource = null;

            lblIPAddressValue.Text = string.Empty;
            lblMacAddressValue.Text = string.Empty;
            lblHostNameValue.Text = string.Empty;

            lblSubnetMaskValue.Text = string.Empty;
            lblNetworkAdapterValue.Text = string.Empty;
            lblGatewayAddressValue.Text = string.Empty;
        }

        private void DisplaySystemDetails(Adapter selectedAdapter, IPDetails selectedIPDetails)
        {
            lblIPAddressValue.Text = selectedIPDetails.IP;
            lblMacAddressValue.Text = selectedIPDetails.MacAddress;
            lblHostNameValue.Text = selectedIPDetails.HostName;

            lblSubnetMaskValue.Text = selectedAdapter.SubNetMask;
            lblNetworkAdapterValue.Text = selectedAdapter.Name;
            lblGatewayAddressValue.Text = selectedAdapter.GatewayAddress.FirstOrDefault();

            var _host = (DotNMap.host)selectedIPDetails.NMapRun.Items.ToList().Find(p => p.GetType().Name.ToString().Equals("host"));
            if (_host != null && _host.status.state == DotNMap.statusState.up)
            {
                //Bind OS Details
                var _os = (DotNMap.os)_host.Details.ToList().Find(p => p.GetType().Name.ToString().Equals("os"));
                if (_os != null && _os.osmatch != null)
                {
                    var _osMatch = new List<OSMatch>();
                    _os.osmatch.ToList().ForEach(p => { _osMatch.Add(new OSMatch() { OSName = p.name, Accuracy = p.accuracy, DeviceType = p.osclass.Count() > 0 ? p.osclass[0].type : string.Empty }); });
                    gvOSPossibilities.DataSource = _osMatch;
                }

                //Bind Port Details
                var _ports = (DotNMap.ports)_host.Details.ToList().Find(p => p.GetType().Name.ToString().Equals("ports"));
                if (_ports != null && _ports.port != null && _ports.port.Count() > 0)
                {
                    var _portDetails = new List<Port>();
                    _ports.port.ToList().ForEach(p => { _portDetails.Add(new Port() { PortID = p.portid, Protocol = p.protocol.ToString(), ServiceName = p.service.name, State = p.state.state1 }); });
                    gvOpenPorts.DataSource = _portDetails;
                }
            }
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            SSHResult _resultForm = new SSHResult();
            var _response = _SShClientAdapter.RunSSHCommand("sudo shutdown -h now");

            _resultForm.Controls["txtBoxSSHResult"].Text = string.IsNullOrEmpty(_response) ? "Success" : _response;
            _resultForm.ShowDialog();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            SSHResult _resultForm = new SSHResult();
            var _response = _SShClientAdapter.RunSSHCommand("sudo reboot");

            _resultForm.Controls["txtBoxSSHResult"].Text = string.IsNullOrEmpty(_response)? "Success": _response;
            _resultForm.ShowDialog();
        }

        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            SSHResult _resultForm = new SSHResult();
            var _response = _SShClientAdapter.RunSSHCommand("sudo screencapture test.png");

            ((RichTextBox)_resultForm.Controls["txtBoxSSHResult"]).Text = string.IsNullOrEmpty(_response) ? "Success" : _response; ;

            _SShClientAdapter.RunSSHDownloadCommand("test.png", "test.png");
            ((PictureBox)_resultForm.Controls["pBoxScreenShot"]).ImageLocation = "test.png";

            _resultForm.ShowDialog();
        }

        private void btnRunCommand_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSShCommand.Text))
            {
                SSHResult _resultForm = new SSHResult();
                var _response = _SShClientAdapter.RunSSHCommand(txtSShCommand.Text);

                _resultForm.Controls["txtBoxSSHResult"].Text = string.IsNullOrEmpty(_response) ? "Success" : _response;
                _resultForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please enter a command");
            }
        }
    }
}

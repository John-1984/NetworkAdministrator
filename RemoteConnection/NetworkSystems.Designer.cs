namespace RemoteConnection
{
    partial class NetworkSystems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkSystems));
            this.pnlSystemDetails = new System.Windows.Forms.Panel();
            this.gvOSPossibilities = new System.Windows.Forms.DataGridView();
            this.gvOpenPorts = new System.Windows.Forms.DataGridView();
            this.btnRunCommand = new System.Windows.Forms.Button();
            this.lblSSHCommand = new System.Windows.Forms.Label();
            this.txtSShCommand = new System.Windows.Forms.TextBox();
            this.btnScreenShot = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.lblSubnetMaskValue = new System.Windows.Forms.Label();
            this.lblSubnetMask = new System.Windows.Forms.Label();
            this.lblGatewayAddressValue = new System.Windows.Forms.Label();
            this.lblGatewayAddress = new System.Windows.Forms.Label();
            this.lblNetworkAdapterValue = new System.Windows.Forms.Label();
            this.lblNetworkAdapter = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblHostNameValue = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblPorts = new System.Windows.Forms.Label();
            this.lblMacAddressValue = new System.Windows.Forms.Label();
            this.lblIPAddressValue = new System.Windows.Forms.Label();
            this.lblMacAddress = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.btnDetect = new System.Windows.Forms.Button();
            this.lblDetectionStatus = new System.Windows.Forms.Label();
            this.treeViewNetworkSystems = new System.Windows.Forms.TreeView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlSystemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOSPossibilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOpenPorts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSystemDetails
            // 
            this.pnlSystemDetails.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSystemDetails.Controls.Add(this.gvOSPossibilities);
            this.pnlSystemDetails.Controls.Add(this.gvOpenPorts);
            this.pnlSystemDetails.Controls.Add(this.btnRunCommand);
            this.pnlSystemDetails.Controls.Add(this.lblSSHCommand);
            this.pnlSystemDetails.Controls.Add(this.txtSShCommand);
            this.pnlSystemDetails.Controls.Add(this.btnScreenShot);
            this.pnlSystemDetails.Controls.Add(this.btnRestart);
            this.pnlSystemDetails.Controls.Add(this.btnShutDown);
            this.pnlSystemDetails.Controls.Add(this.lblSubnetMaskValue);
            this.pnlSystemDetails.Controls.Add(this.lblSubnetMask);
            this.pnlSystemDetails.Controls.Add(this.lblGatewayAddressValue);
            this.pnlSystemDetails.Controls.Add(this.lblGatewayAddress);
            this.pnlSystemDetails.Controls.Add(this.lblNetworkAdapterValue);
            this.pnlSystemDetails.Controls.Add(this.lblNetworkAdapter);
            this.pnlSystemDetails.Controls.Add(this.lblOS);
            this.pnlSystemDetails.Controls.Add(this.lblHostNameValue);
            this.pnlSystemDetails.Controls.Add(this.lblHostName);
            this.pnlSystemDetails.Controls.Add(this.lblPorts);
            this.pnlSystemDetails.Controls.Add(this.lblMacAddressValue);
            this.pnlSystemDetails.Controls.Add(this.lblIPAddressValue);
            this.pnlSystemDetails.Controls.Add(this.lblMacAddress);
            this.pnlSystemDetails.Controls.Add(this.lblIPAddress);
            this.pnlSystemDetails.Location = new System.Drawing.Point(215, 59);
            this.pnlSystemDetails.Name = "pnlSystemDetails";
            this.pnlSystemDetails.Size = new System.Drawing.Size(602, 454);
            this.pnlSystemDetails.TabIndex = 1;
            // 
            // gvOSPossibilities
            // 
            this.gvOSPossibilities.AllowUserToAddRows = false;
            this.gvOSPossibilities.AllowUserToDeleteRows = false;
            this.gvOSPossibilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvOSPossibilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOSPossibilities.Location = new System.Drawing.Point(26, 231);
            this.gvOSPossibilities.Name = "gvOSPossibilities";
            this.gvOSPossibilities.ReadOnly = true;
            this.gvOSPossibilities.Size = new System.Drawing.Size(557, 116);
            this.gvOSPossibilities.TabIndex = 23;
            // 
            // gvOpenPorts
            // 
            this.gvOpenPorts.AllowUserToAddRows = false;
            this.gvOpenPorts.AllowUserToDeleteRows = false;
            this.gvOpenPorts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvOpenPorts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOpenPorts.Location = new System.Drawing.Point(26, 121);
            this.gvOpenPorts.Name = "gvOpenPorts";
            this.gvOpenPorts.ReadOnly = true;
            this.gvOpenPorts.Size = new System.Drawing.Size(557, 91);
            this.gvOpenPorts.TabIndex = 22;
            // 
            // btnRunCommand
            // 
            this.btnRunCommand.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRunCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunCommand.Location = new System.Drawing.Point(508, 407);
            this.btnRunCommand.Name = "btnRunCommand";
            this.btnRunCommand.Size = new System.Drawing.Size(75, 23);
            this.btnRunCommand.TabIndex = 21;
            this.btnRunCommand.Text = "Run";
            this.btnRunCommand.UseVisualStyleBackColor = false;
            this.btnRunCommand.Click += new System.EventHandler(this.btnRunCommand_Click);
            // 
            // lblSSHCommand
            // 
            this.lblSSHCommand.AutoSize = true;
            this.lblSSHCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSHCommand.Location = new System.Drawing.Point(23, 413);
            this.lblSSHCommand.Name = "lblSSHCommand";
            this.lblSSHCommand.Size = new System.Drawing.Size(94, 13);
            this.lblSSHCommand.TabIndex = 20;
            this.lblSSHCommand.Text = "SSH Command:";
            // 
            // txtSShCommand
            // 
            this.txtSShCommand.Location = new System.Drawing.Point(116, 410);
            this.txtSShCommand.Name = "txtSShCommand";
            this.txtSShCommand.Size = new System.Drawing.Size(391, 20);
            this.txtSShCommand.TabIndex = 19;
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnScreenShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenShot.Location = new System.Drawing.Point(434, 363);
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(130, 23);
            this.btnScreenShot.TabIndex = 18;
            this.btnScreenShot.Text = "Screen Shot";
            this.btnScreenShot.UseVisualStyleBackColor = false;
            this.btnScreenShot.Click += new System.EventHandler(this.btnScreenShot_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(244, 363);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(112, 23);
            this.btnRestart.TabIndex = 17;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutDown.Location = new System.Drawing.Point(16, 363);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(111, 23);
            this.btnShutDown.TabIndex = 16;
            this.btnShutDown.Text = "Shut Down";
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // lblSubnetMaskValue
            // 
            this.lblSubnetMaskValue.AutoSize = true;
            this.lblSubnetMaskValue.Location = new System.Drawing.Point(411, 47);
            this.lblSubnetMaskValue.Name = "lblSubnetMaskValue";
            this.lblSubnetMaskValue.Size = new System.Drawing.Size(0, 13);
            this.lblSubnetMaskValue.TabIndex = 14;
            // 
            // lblSubnetMask
            // 
            this.lblSubnetMask.AutoSize = true;
            this.lblSubnetMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubnetMask.Location = new System.Drawing.Point(332, 47);
            this.lblSubnetMask.Name = "lblSubnetMask";
            this.lblSubnetMask.Size = new System.Drawing.Size(85, 13);
            this.lblSubnetMask.TabIndex = 13;
            this.lblSubnetMask.Text = "Subnet Mask:";
            // 
            // lblGatewayAddressValue
            // 
            this.lblGatewayAddressValue.AutoSize = true;
            this.lblGatewayAddressValue.Location = new System.Drawing.Point(431, 82);
            this.lblGatewayAddressValue.Name = "lblGatewayAddressValue";
            this.lblGatewayAddressValue.Size = new System.Drawing.Size(0, 13);
            this.lblGatewayAddressValue.TabIndex = 12;
            // 
            // lblGatewayAddress
            // 
            this.lblGatewayAddress.AutoSize = true;
            this.lblGatewayAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGatewayAddress.Location = new System.Drawing.Point(332, 82);
            this.lblGatewayAddress.Name = "lblGatewayAddress";
            this.lblGatewayAddress.Size = new System.Drawing.Size(109, 13);
            this.lblGatewayAddress.TabIndex = 11;
            this.lblGatewayAddress.Text = "Gateway Address:";
            // 
            // lblNetworkAdapterValue
            // 
            this.lblNetworkAdapterValue.AutoSize = true;
            this.lblNetworkAdapterValue.Location = new System.Drawing.Point(119, 82);
            this.lblNetworkAdapterValue.Name = "lblNetworkAdapterValue";
            this.lblNetworkAdapterValue.Size = new System.Drawing.Size(0, 13);
            this.lblNetworkAdapterValue.TabIndex = 10;
            // 
            // lblNetworkAdapter
            // 
            this.lblNetworkAdapter.AutoSize = true;
            this.lblNetworkAdapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetworkAdapter.Location = new System.Drawing.Point(23, 82);
            this.lblNetworkAdapter.Name = "lblNetworkAdapter";
            this.lblNetworkAdapter.Size = new System.Drawing.Size(106, 13);
            this.lblNetworkAdapter.TabIndex = 9;
            this.lblNetworkAdapter.Text = "Network Adapter:";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.Location = new System.Drawing.Point(23, 215);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(94, 13);
            this.lblOS.TabIndex = 8;
            this.lblOS.Text = "OS Possibilities";
            // 
            // lblHostNameValue
            // 
            this.lblHostNameValue.AutoSize = true;
            this.lblHostNameValue.Location = new System.Drawing.Point(101, 47);
            this.lblHostNameValue.Name = "lblHostNameValue";
            this.lblHostNameValue.Size = new System.Drawing.Size(0, 13);
            this.lblHostNameValue.TabIndex = 7;
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostName.Location = new System.Drawing.Point(23, 47);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(73, 13);
            this.lblHostName.TabIndex = 6;
            this.lblHostName.Text = "Host Name:";
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorts.Location = new System.Drawing.Point(23, 105);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(70, 13);
            this.lblPorts.TabIndex = 4;
            this.lblPorts.Text = "Open Ports";
            // 
            // lblMacAddressValue
            // 
            this.lblMacAddressValue.AutoSize = true;
            this.lblMacAddressValue.Location = new System.Drawing.Point(410, 18);
            this.lblMacAddressValue.Name = "lblMacAddressValue";
            this.lblMacAddressValue.Size = new System.Drawing.Size(0, 13);
            this.lblMacAddressValue.TabIndex = 3;
            // 
            // lblIPAddressValue
            // 
            this.lblIPAddressValue.AutoSize = true;
            this.lblIPAddressValue.Location = new System.Drawing.Point(87, 18);
            this.lblIPAddressValue.Name = "lblIPAddressValue";
            this.lblIPAddressValue.Size = new System.Drawing.Size(0, 13);
            this.lblIPAddressValue.TabIndex = 2;
            // 
            // lblMacAddress
            // 
            this.lblMacAddress.AutoSize = true;
            this.lblMacAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacAddress.Location = new System.Drawing.Point(332, 18);
            this.lblMacAddress.Name = "lblMacAddress";
            this.lblMacAddress.Size = new System.Drawing.Size(84, 13);
            this.lblMacAddress.TabIndex = 1;
            this.lblMacAddress.Text = "Mac Address:";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.Location = new System.Drawing.Point(23, 18);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(72, 13);
            this.lblIPAddress.TabIndex = 0;
            this.lblIPAddress.Text = "IP Address:";
            // 
            // btnDetect
            // 
            this.btnDetect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetect.Location = new System.Drawing.Point(18, 12);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(175, 39);
            this.btnDetect.TabIndex = 2;
            this.btnDetect.Text = "Detect";
            this.btnDetect.UseVisualStyleBackColor = false;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // lblDetectionStatus
            // 
            this.lblDetectionStatus.AutoSize = true;
            this.lblDetectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblDetectionStatus.Location = new System.Drawing.Point(229, 29);
            this.lblDetectionStatus.Name = "lblDetectionStatus";
            this.lblDetectionStatus.Size = new System.Drawing.Size(134, 13);
            this.lblDetectionStatus.TabIndex = 3;
            this.lblDetectionStatus.Text = "All Networks Detected";
            // 
            // treeViewNetworkSystems
            // 
            this.treeViewNetworkSystems.Location = new System.Drawing.Point(18, 59);
            this.treeViewNetworkSystems.Name = "treeViewNetworkSystems";
            this.treeViewNetworkSystems.Size = new System.Drawing.Size(175, 454);
            this.treeViewNetworkSystems.TabIndex = 4;
            this.treeViewNetworkSystems.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNetworkSystems_AfterSelect);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Azure;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(649, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 36);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // NetworkSystems
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 525);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.treeViewNetworkSystems);
            this.Controls.Add(this.lblDetectionStatus);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.pnlSystemDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NetworkSystems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Administrator";
            this.pnlSystemDetails.ResumeLayout(false);
            this.pnlSystemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOSPossibilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOpenPorts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSystemDetails;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Label lblDetectionStatus;
        private System.Windows.Forms.TreeView treeViewNetworkSystems;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.Label lblMacAddressValue;
        private System.Windows.Forms.Label lblIPAddressValue;
        private System.Windows.Forms.Label lblMacAddress;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblHostNameValue;
        private System.Windows.Forms.Label lblSubnetMaskValue;
        private System.Windows.Forms.Label lblSubnetMask;
        private System.Windows.Forms.Label lblGatewayAddressValue;
        private System.Windows.Forms.Label lblGatewayAddress;
        private System.Windows.Forms.Label lblNetworkAdapterValue;
        private System.Windows.Forms.Label lblNetworkAdapter;
        private System.Windows.Forms.Label lblSSHCommand;
        private System.Windows.Forms.TextBox txtSShCommand;
        private System.Windows.Forms.Button btnScreenShot;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Button btnRunCommand;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView gvOpenPorts;
        private System.Windows.Forms.DataGridView gvOSPossibilities;
    }
}


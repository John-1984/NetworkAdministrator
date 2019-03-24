using Renci.SshNet;
using Renci.SshNet.Sftp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteConnection
{
    public class SSHClientAdapter
    {
        public string RunSSHCommand(string Command, string IPAddress = "192.168.1.15", string UserName = "john", string Password = "P@ssw0rd", string Port = "")
        {
            var _result = string.Empty;
            try
            {
                using (SshClient _sshClient = new SshClient(IPAddress, UserName, Password))
                {
                    _sshClient.Connect();
                    var _response = _sshClient.RunCommand(Command);
                    _result = _response.Result;
                    _sshClient.Disconnect();
                };
            }
            catch (Exception ex)
            {
                //Do Nothing
            }

            return _result;
        }

        public string RunSSHDownloadCommand(string LocalFileFullPath, string RemoteFileFullPath, string IPAddress = "192.168.1.15", string UserName = "john", string Password = "P@ssw0rd", string Port = "")
        {
            var _result = string.Empty;
            try
            {
                using (SftpClient _sshClient = new SftpClient(IPAddress, UserName, Password))
                {
                    _sshClient.Connect();
                    using (Stream localFile = File.Create(LocalFileFullPath))
                    {
                        _sshClient.DownloadFile(RemoteFileFullPath, localFile);
                    }
                    _sshClient.Disconnect();
                };
            }
            catch (Exception ex)
            {
                //Do Nothing
            }

            return _result;
        }

        public string RunSSHUploadCommand(string LocalFileFullPath, string RemoteFileFullPath, string IPAddress = "192.168.1.15", string UserName = "john", string Password = "P@ssw0rd", string Port = "")
        {
            var _result = string.Empty;
            try
            {
                using (SftpClient _sshClient = new SftpClient(IPAddress, UserName, Password))
                {
                    _sshClient.Connect();
                    using (Stream localFile = File.OpenRead(LocalFileFullPath))
                    {
                        _sshClient.UploadFile(localFile, RemoteFileFullPath);
                    }
                    _sshClient.Disconnect();
                };
            }
            catch (Exception ex)
            {
                //Do Nothing
            }

            return _result;
        }
    }
}

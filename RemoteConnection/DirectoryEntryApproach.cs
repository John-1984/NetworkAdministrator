using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace RemoteConnection
{
    /// <summary>
    /// This is a possible approach for Networks having Active Directory
    /// </summary>
    public class DirectoryEntryApproach
    {
        public List<string> GetComputersOnNetwork()
        {
            var _computerNames = new List<string>();
            using(DirectoryEntry root = new DirectoryEntry("WinNT:")){
                foreach (DirectoryEntry computers in root.Children) {
                    foreach (DirectoryEntry computer in computers.Children) {
                        _computerNames.Add(computers.Name);
                    }
                }
            }

            return _computerNames.Distinct().ToList();
        }
    }
}

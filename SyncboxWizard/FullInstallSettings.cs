using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SyncboxWizard
{
    
    [XmlRoot("syncbox")]
    public class FullInstallSettings
    {
        [XmlElement("callsign")]
        public string CallSign { get; set; }
        [XmlElement("useDHCP")]
        public string Dhcp { get; set; }
        [XmlElement("ip")]
        public string IpAddress { get; set; }
        [XmlElement("subnet")]
        public string SubnetMask { get; set; }
        [XmlElement("gateway")]
        public string DefaultGateway { get; set; }
        [XmlElement("dns1")]
        public string PreferredDns { get; set; }
        [XmlElement("dns2")]
        public string AlternateDns { get; set; }
        [XmlElement("updated")]
        public string Updated { get; set; }

        public FullInstallSettings()
        {
            CallSign = "";
            Dhcp = "";
            IpAddress = "";
            SubnetMask = "";
            DefaultGateway = "";
            PreferredDns = "";
            AlternateDns = "";
            Updated = "";
        }

        public FullInstallSettings(string callsign, string dhcp, string ipAddress, string subnetMask, string defaultGateway, string preferredDns, string alternateDns)
        {
            this.CallSign = callsign;
            this.Dhcp = dhcp;
            this.IpAddress = ipAddress;
            this.SubnetMask = subnetMask;
            this.DefaultGateway = defaultGateway;
            this.PreferredDns = preferredDns;
            this.AlternateDns = alternateDns;
            this.Updated = "";
        }

    }
}

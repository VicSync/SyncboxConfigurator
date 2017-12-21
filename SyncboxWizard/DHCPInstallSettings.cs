using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SyncboxWizard
{
    [XmlRoot("syncbox")]
    public class DHCPInstallSettings
    {
        [XmlElement("callsign")]
        public string CallSign { get; set; }
        [XmlElement("useDHCP")]
        public string Dhcp { get; set; }
        [XmlElement("updated")]
        public string Updated { get; set; }

        public DHCPInstallSettings()
        {
            CallSign = "";
            Dhcp = "";
            Updated = "";
        }

        public DHCPInstallSettings(string callsign, string dhcp, string updated)
        {
            CallSign = callsign;
            Dhcp = dhcp;
            Updated = updated;
        }
    }
}

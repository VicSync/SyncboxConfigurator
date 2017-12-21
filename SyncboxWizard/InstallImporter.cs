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
    public class InstallImporter
    {
        /// <summary>
        /// Looks for current settings in config.xml and deserializes into an object
        /// </summary>
        /// <returns>InstallSettings object</returns>
        /// <param name="fileName">file name of the file to deserialize</param>
        public FullInstallSettings Deserialize(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            string callsignText, dhcpText, ipText, subnetText, gatewayText, preferredDnsText, alternateDnsText;
            callsignText = dhcpText = ipText = subnetText = gatewayText = preferredDnsText = alternateDnsText = "";

            XmlNodeList callsign = doc.GetElementsByTagName("callsign");
            XmlNodeList dhcp = doc.GetElementsByTagName("useDHCP");
            callsignText = callsign[0].InnerText;
            dhcpText = dhcp[0].InnerText;

            if (dhcp[0].InnerText.Equals("false"))
            {
                XmlNodeList ip = doc.GetElementsByTagName("ip");
                XmlNodeList subnet = doc.GetElementsByTagName("subnet");
                XmlNodeList gateway = doc.GetElementsByTagName("gateway");
                XmlNodeList preferredDns = doc.GetElementsByTagName("dns1");
                XmlNodeList altDns = doc.GetElementsByTagName("dns2");
                ipText = ip[0].InnerText;
                subnetText = subnet[0].InnerText;
                gatewayText = gateway[0].InnerText;
                preferredDnsText = preferredDns[0].InnerText;
                alternateDnsText = altDns[0].InnerText;

            }
            FullInstallSettings settings = new FullInstallSettings(callsignText, dhcpText, ipText, subnetText, gatewayText, preferredDnsText, alternateDnsText);

            return settings;
        }

        /// <summary>
        /// Takes an InstallSettings object and serializes into xml
        /// </summary>
        /// <param name="incoming">An InstallSettings object</param>
        /// <returns>String containing the serialized objects xml</returns>
        public string Serialize(FullInstallSettings incoming)
        {
            //To determine what dataObject to use for serialization based on the dhcp button selected
            bool useDHCP = (incoming.Dhcp.Equals("true")) ? true : false;

            //Resulting xml string
            var xmlResult = "";

            //Settings to remove namspaces from the xml
            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
            xsn.Add(string.Empty, string.Empty);

            //Create the custom stringWriter to use utf-8 instead of utf-16
            StringWriterWithEncoding utf8StringWriter = new StringWriterWithEncoding(Encoding.UTF8);
            XmlWriterSettings ws = new XmlWriterSettings() { Indent = true, Encoding = Encoding.UTF8 };

            //Create a serializer
            XmlSerializer serializer = null;


            if (useDHCP == true) //Serialize the DHCP version
            {
                DHCPInstallSettings settings = new DHCPInstallSettings(incoming.CallSign, incoming.Dhcp, incoming.Updated);

                //Initialize the serializer and writer
                serializer = new XmlSerializer(typeof(DHCPInstallSettings));
                XmlWriter writer = XmlWriter.Create(utf8StringWriter, ws);

                //Srialize and then save the output string to result and pass back
                serializer.Serialize(writer, settings, xsn);
                xmlResult = utf8StringWriter.ToString();
            }
            else // Serialize the full installsettings version
            {
                XmlSerializer xs = new XmlSerializer(typeof(FullInstallSettings));

                //Initialize the serializer and writer
                serializer = new XmlSerializer(typeof(FullInstallSettings));
                XmlWriter writer = XmlWriter.Create(utf8StringWriter, ws);

                //Srialize and then save the output string to result and pass back
                serializer.Serialize(writer, incoming, xsn);
                xmlResult = utf8StringWriter.ToString();
                
            }
            
            return xmlResult;
        }

        /// <summary>
        /// Writes a string to a file
        /// </summary>
        /// <param name="incomingXml">A string to write to file</param>
        public void WriteXmlToCurrentDirectory(string incomingXml)
        {            
            string path = "config.xml";

            System.IO.File.WriteAllText(path, incomingXml);
        }

    }
}

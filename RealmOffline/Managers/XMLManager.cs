using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using RealmOffline.Packets;

namespace RealmOffline.Managers
{
    public class XMLManager
    {
        #region Properties/Fields
        private XmlDocument _doc;
        /// <summary>
        /// the document object to use
        /// </summary>
        private XmlDocument XMLDoc
        {
            get { return _doc; }
            set { _doc = value; }
        }

        /// <summary>
        /// Our config file
        /// </summary>
        private string Config { get { return "Config.xml"; } }
        /// <summary>
        /// Our whats new data file
        /// </summary>
        private string WhatsNew { get { return "WhatsNew.xml"; } }

        #endregion

        public XMLManager()
        {
        }

        #region GetRouter
        /// <summary>
        /// Returnss the router ip, remember 
        /// the port is always 7002 for the router.
        /// </summary>
        /// <returns></returns>
        public string GetRouter()
        {
            string tmp = "";

            XMLDoc = new XmlDocument();
            XMLDoc.Load(Config);
            // Grab my Patch node
            XmlNodeList router = XMLDoc.SelectNodes("/Config/Servers/Router");
            foreach (XmlNode n in router)
            {
                tmp = n["Address"].InnerText;
            }

            return tmp;
        }
        #endregion

        #region GetPatch
        /// <summary>
        /// returns the patch server information
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetPatch()
        {
            Dictionary<string, string> tmp = new Dictionary<string, string>();
            try
            {
                XMLDoc = new XmlDocument();
                XMLDoc.Load(Config);
                // Grab my Patch node
                XmlNodeList patch = XMLDoc.SelectNodes("/Config/Servers/Patch");
                foreach (XmlNode n in patch)
                {
                    tmp.Add(n["Address"].InnerText, n["Port"].InnerText);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return tmp;
        }
        #endregion

        #region MySql
        public string GetMySqlConnection
        {
            get
            {
                string result = string.Empty;
                XMLDoc = new XmlDocument();
                XMLDoc.Load(Config);
                // Grab my Patch node
                XmlNodeList sql = XMLDoc.SelectNodes("/Config/Mysql");
                try
                {
                    foreach (XmlNode n in sql)
                    {
                        result += "Server=" + n["Server"].InnerText + ";";
                        result += "Port=" + n["Port"].InnerText + ";";
                        result += "Database=" + n["Database"].InnerText + ";";
                        result += "Uid=" + n["Username"].InnerText + ";";
                        result += "Pwd=" + n["Password"].InnerText + ";";
                    }
                }
                catch { }
                return result;
            }
        }
        #endregion
        #region GetGameServers
        /// <summary>
        /// Returns all World Server in config file
        /// </summary>
        /// <returns></returns>
        public List<ServerObject> GetGameServers()
        {
            List<ServerObject> tmp = new List<ServerObject>();
            ServerObject s = null;
            try
            {
                XMLDoc = new XmlDocument();
                XMLDoc.Load(Config);
                // Grab my Patch node
                XmlNodeList game = XMLDoc.SelectNodes("/Config/WorldServer");
                foreach (XmlNode n in game)
                {
                    s = new ServerObject();
                    s.Name = n["Servername"].InnerText;
                    s.Address = n["Address"].InnerText;
                    s.Port = int.Parse(n["Port"].InnerText);
                    s.WorldIndex = int.Parse(n["Index"].InnerText);
                    tmp.Add(s);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return tmp;
        }
        #endregion
    }
}

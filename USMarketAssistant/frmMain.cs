using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace USMarketAssistant
{
    public partial class frmMain : Form
    {
        public string strSettingPath = "../../Settings.xml";
        public Dictionary<string, string> dicApiServices = new Dictionary<string, string>();
        public frmMain()
        {
            InitializeComponent();

            // Load Favorite Stocks
            LoadFavorites();
            LoadApiServices();
            //txtFavoriteStocks.AppendText("hello");
        }

        public void LoadFavorites()
        {
            XmlDocument doc = GetSettingXml();
            
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                if (node.Name == "FavoriteStocks")
                {
                    foreach (XmlNode nd in node.ChildNodes)
                    {
                        txtFavoriteStocks.AppendText(nd.InnerText+Environment.NewLine);
                    }
                }
                
            }
        }

        public void LoadApiServices()
        {
            dicApiServices.Clear();
            XmlDocument doc = GetSettingXml();
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/Settings/ApiServices/ApiService");
            foreach (XmlNode node in nodes)
            {
                dicApiServices.Add(node.SelectNodes("Name")[0].InnerText, node.SelectNodes("Key")[0].InnerText);
            }
        }

        private void btnUpdateFavoriteStocks_Click(object sender, EventArgs e)
        {

            XmlDocument doc = GetSettingXml();
            doc = ClearFavoriteStocksInSetting();
            SaveSettingXml(doc);
            using (StringReader sr = new StringReader(txtFavoriteStocks.Text))
            {
                string line;
                while ((line = sr.ReadLine())!=null)
                {
                    if (!string.IsNullOrEmpty(line))
                        AddFavoriteStockToSetting(doc, line);
                }
            }
            
        }

        public XmlDocument ClearFavoriteStocksInSetting()
        {
            XmlDocument doc = GetSettingXml();

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                if (node.Name == "FavoriteStocks")
                {
                    node.RemoveAll();
                }

            }

            return doc;
        }

        public XmlDocument GetSettingXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(strSettingPath);
            return doc;
        }

        public void SaveSettingXml(XmlDocument doc)
        {
            doc.Save(strSettingPath);
        }

        public void AddFavoriteStockToSetting(XmlDocument doc, string name)
        {
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                if (node.Name == "FavoriteStocks")
                {
                    XmlNode xmlnode = doc.CreateNode(XmlNodeType.Element, "Stock", "");
                    xmlnode.InnerText = name;
                    node.AppendChild(xmlnode);
                }

            }
            SaveSettingXml(doc);
        }

        private void btnSaveService1ApiKey_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(strSettingPath);
            bool blFoundEntry = false;

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                if (node.Name == "ApiServices")
                {
                    foreach (XmlNode nd in node.ChildNodes)
                    {
                        if (nd.HasChildNodes)
                        {
                            if (nd.SelectNodes("Name")[0].InnerText == "Alpha Vantage")
                            {
                                nd.SelectNodes("Key")[0].InnerText = txtService1ApiKey.Text;
                                blFoundEntry = true;
                            }
                        }
                        if (blFoundEntry)
                            break;
                    }
                    if (blFoundEntry)
                        break;
                    else
                    {
                        XmlNode xmlnode = doc.CreateNode(XmlNodeType.Element, "ApiService", "");
                        XmlNode xmlnode1 = doc.CreateNode(XmlNodeType.Element, "Name", "");
                        XmlNode xmlnode2 = doc.CreateNode(XmlNodeType.Element, "Key", "");
                        xmlnode1.InnerText = "Alpha Vantage";
                        xmlnode2.InnerText = txtService1ApiKey.Text;
                        xmlnode.AppendChild(xmlnode1);
                        xmlnode.AppendChild(xmlnode2);

                        node.AppendChild(xmlnode);
                        blFoundEntry = true;
                    }
                }
                if (blFoundEntry)
                    break;
            }
            SaveSettingXml(doc);
            LoadApiServices();
        }
    }
}

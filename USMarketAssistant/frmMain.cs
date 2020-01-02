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
        public frmMain()
        {
            InitializeComponent();

            // Load Favorite Stocks
            LoadFavorites();
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
            doc.Load("../../Settings.xml");
            return doc;
        }

        public void SaveSettingXml(XmlDocument doc)
        {
            doc.Save("../../Settings.xml");
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
    }
}

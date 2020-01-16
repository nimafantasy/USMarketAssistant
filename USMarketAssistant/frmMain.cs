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
        public List<Stock> lstFavorites = new List<Stock>();
        private int intSelectedPeriod = 365;
        public frmMain()
        {
            InitializeComponent();

            // Load Favorite Stocks
            
            LoadApiServices();
            LoadFavorites();


            //txtFavoriteStocks.AppendText("hello");
        }



        public void LoadFavorites()
        {
            XmlDocument doc = GetSettingXml();
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/Settings/FavoriteStocks/Stock");
            lstFavorites.Clear();
            DataLoader dl = new DataLoader();
            foreach (XmlNode nd in nodes)
            {
                txtFavoriteStocks.AppendText(nd.InnerText+Environment.NewLine);
                lstFavorites.Add(dl.Load(nd.InnerText, dicApiServices));
                lbFavorites.Items.Add(nd.InnerText);
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
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/Settings/FavoriteStocks");
            
            XmlNode xmlnode = doc.CreateNode(XmlNodeType.Element, "Stock", "");
            xmlnode.InnerText = name;
            nodes[0].AppendChild(xmlnode);

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

        private void lbFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Drawing.DrawChart(chrtMain, lstFavorites.Find(x => x.Name == lb.SelectedItem.ToString()),intSelectedPeriod);
        }

        private void periodRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            int period = 365; // default 1 year
            if (sender == rbPeriod10Y)
                period = 3650;
            else if (sender == rbPeriod1Y)
                period = 365;
            else if (sender == rbPeriod9M)
                period = 270;
            else if (sender == rbPeriod6M)
                period = 180;
            else if (sender == rbPeriod3M)
                period = 90;
            else if (sender == rbPeriod1M)
                period = 30;
            else
                period = 365;
            intSelectedPeriod = period;
            Drawing.DrawChart(chrtMain, lstFavorites.Find(x => x.Name == lbFavorites.SelectedItem.ToString()), period);
        }

        private void btnDrawChannel_Click(object sender, EventArgs e)
        {
            Drawing.DrawChannel(chrtMain,lstFavorites.Find(x => x.Name ==  lbFavorites.SelectedItem.ToString()), intSelectedPeriod);
        }
    }
}

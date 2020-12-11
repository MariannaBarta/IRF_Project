using IRF_Project_DCWC5L.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IRF_Project_DCWC5L
{
    public partial class Form1 : Form
    {
        string CurrentPath = "";
        BindingList<CDInfo> CDList = new BindingList<CDInfo>();
        private AccountController _controller = new AccountController();

        public Form1()
        {
            InitializeComponent();
            dataGridViewCD.DataSource = CDList;
            dataGridViewPersonList.DataSource = _controller.AccountManager.Accounts;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            betoltes();
        }

        private void betoltes()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\Temp";
            openFileDialog1.ShowDialog();
            CurrentPath = textBoxOpenFile.Text = openFileDialog1.FileName;

            var xDoc = new XmlDocument();
            xDoc.Load(CurrentPath);

            foreach (XmlElement element in xDoc.DocumentElement)
            {
                var CD = new CDInfo();
                CDList.Add(CD);

                var CDTitle = (XmlElement)element.ChildNodes[0];
                CD.Cim = CDTitle.InnerText;

                var CDArtist = (XmlElement)element.ChildNodes[1];
                CD.Eloado = CDArtist.InnerText;

                var CDYear = (XmlElement)element.ChildNodes[5];
                CD.KiadasEve = Int32.Parse(CDYear.InnerText);
            }
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.Register(
                    textBoxFullName.Text,
                    textBoxShortName.Text,
                    textBoxAccount.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

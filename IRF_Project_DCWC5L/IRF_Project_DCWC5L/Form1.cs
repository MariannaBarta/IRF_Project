using IRF_Project_DCWC5L.Entities;
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

namespace IRF_Project_DCWC5L
{
    public partial class Form1 : Form
    {
        string CurrentPath = "";
        BindingList<CDInfo> CDList = new BindingList<CDInfo>();
        List<PresentList> MyPresents = new List<PresentList>();
        private AccountController _controller = new AccountController();
        


        public Form1()
        {
            InitializeComponent();
            dataGridViewCD.DataSource = CDList;
            dataGridViewPersonList.DataSource = _controller.AccountManager.Accounts;
            pictureBoxLogo.BackgroundImage = Bitmap.FromFile(Properties.Settings.Default.logo);


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
            textBoxFullName.Clear();
            textBoxShortName.Clear();
            textBoxAccount.Clear();
            timerRandomCD.Enabled = true;
        }

        private void timerRandomCD_Tick(object sender, EventArgs e)
        {
            //na itt van gáz
            Random rnd = new Random();
            int randomCD = rnd.Next(CDList.Count);
            richTextBoxRandomCD.Text = CDList[randomCD].ToString();
        }

        private void buttonSaveList_Click(object sender, EventArgs e)
        {
            // meg itt
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            sfd.DefaultExt = "csv";
            
            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                string output = "";
                sw.WriteLine(String.Format("Cím; Előadó; Kiadás éve; Teljes név; Becenév; iTunes Account"));
                sw.WriteLine(output);
                for (int i = 0; i < MyPresents.Count; i++)
                {
                    output += String.Format(MyPresents[i].ToString());

                    sw.WriteLine(output);
                }
            }
            



        }

        private void buttonAddPresent_Click(object sender, EventArgs e)
        {
            //ezt meg csak nem tudom, hogy működik-e XD
            PresentList listaelem = new PresentList();

            foreach (DataGridViewRow row in dataGridViewCD.SelectedRows)
            {
                listaelem.Cim = row.Cells[0].Value.ToString();
                listaelem.Eloado = row.Cells[1].Value.ToString();
                listaelem.KiadasEve = Int32.Parse(row.Cells[2].Value.ToString());
            }

            foreach (DataGridViewRow row in dataGridViewPersonList.SelectedRows)
            {
                listaelem.TeljesNev = row.Cells[0].Value.ToString();
                listaelem.BeceNev = row.Cells[1].Value.ToString();
                listaelem.Account = row.Cells[2].Value.ToString();
            }

            MyPresents.Add(listaelem);
        }

        
    }
}

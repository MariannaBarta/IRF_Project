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
        BindingList<PresentList> MyPresents = new BindingList<PresentList>();
        private RecipientController _reccontroller = new RecipientController();
        Random rnd = new Random();


        public Form1()
        {
            InitializeComponent();
            dataGridViewCD.DataSource = CDList;
            dataGridViewPersonList.DataSource = _reccontroller.RecipientManager.Recipients;
            dataGridViewPresentList.DataSource = MyPresents;
            pictureBoxLogo.BackgroundImage = Bitmap.FromFile(Properties.Settings.Default.logo);
            pictureBoxMusic.BackgroundImage = Bitmap.FromFile(Properties.Settings.Default.music);

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

            timerRandomCD.Enabled = true;
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            try
            {
                _reccontroller.Register(
                    textBoxFullName.Text,
                    textBoxShortName.Text,
                    textBoxAccount.Text);

                textBoxFullName.Clear();
                textBoxShortName.Clear();
                textBoxAccount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void timerRandomCD_Tick(object sender, EventArgs e)
        {
                      
            int randomCD = rnd.Next(CDList.Count);
            richTextBoxRandomCD.Text = CDList[randomCD].Eloado.ToString() + ":" + Environment.NewLine + CDList[randomCD].Cim.ToString();
            richTextBoxRandomCD.SelectAll();
            richTextBoxRandomCD.SelectionAlignment = HorizontalAlignment.Center;
            
        }

        private void buttonSaveList_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            sfd.DefaultExt = "csv";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                string output = "";
                sw.WriteLine(String.Format("Cím; Előadó; Kiadás éve; Teljes név; Becenév; iTunes Account"));
                for (int i = 0; i < MyPresents.Count; i++)
                {
                    
                    output += (MyPresents[i].Cim.ToString() + ";" + MyPresents[i].Eloado.ToString() + ";" + MyPresents[i].KiadasEve.ToString() + ";" +
                        MyPresents[i].TeljesNev.ToString() + ";" + MyPresents[i].BeceNev.ToString() + ";" + MyPresents[i].Account.ToString());

                    sw.WriteLine(output);
                }
            }

        }

        private void buttonAddPresent_Click(object sender, EventArgs e)
        {
            PresentList lista = new PresentList();

            foreach (DataGridViewRow row in dataGridViewCD.SelectedRows)
            {
                lista.Cim = row.Cells[0].Value.ToString();
                lista.Eloado = row.Cells[1].Value.ToString();
                lista.KiadasEve = Int32.Parse(row.Cells[2].Value.ToString());
            }

            foreach (DataGridViewRow row in dataGridViewPersonList.SelectedRows)
            {
                lista.TeljesNev = row.Cells[0].Value.ToString();
                lista.BeceNev = row.Cells[1].Value.ToString();
                lista.Account = row.Cells[2].Value.ToString();
            }

            MyPresents.Add(lista);

        }


    }
}

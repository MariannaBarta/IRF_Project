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
        public Form1()
        {
            InitializeComponent();
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
        }
    }
}

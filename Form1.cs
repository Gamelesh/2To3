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
using System.IO.Compression;
using Ionic.Zip;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;


        //
        // Browse - Button
        // Sucht die gewünschte ZIP File raus
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "2To3 ResourcePack Converter - Selec ZIP File";
            fdlg.InitialDirectory = @"%appdata%";
            fdlg.Filter = "Only ZIP Files|*.zip";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = "Erfolgreich geöffnet: " + fdlg.FileName;
            }
        }

        //
        // Help - Button
        // Zeigt einen Hilfe Text zum Programm an
        private void button3_Click(object sender, EventArgs e)
        {
            const string help = "Only use correct zip files from Minecraft Resources Packs Type 2";
            MessageBox.Show(help);
        }

        //
        // Convert - Button
        // Convertiert das Programm in die neue Form
        private void button1_Click(object sender, EventArgs e, String file)
        {
           
        }
    }
}

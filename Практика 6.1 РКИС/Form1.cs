using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_6._1_РКИС
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
            Singleton.GetInstance();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Singleton.GetInstance().cpu.Count; i++) 
            {
                cbCPU.Items.Add(Singleton.GetInstance().cpu[i]);
            }
            for (int i = 0; i < Singleton.GetInstance().ram.Count; i++)
            {
                cbRam.Items.Add(Singleton.GetInstance().ram[i]);
            }
            for (int i = 0; i < Singleton.GetInstance().pb.Count; i++)
            {
                cbPB.Items.Add(Singleton.GetInstance().pb[i]);
            }
            for (int i = 0; i < Singleton.GetInstance().gc.Count; i++)
            {
                cbGV.Items.Add(Singleton.GetInstance().gc[i]);
            }
        }
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            output.Text = string.Empty;
            if (Singleton.GetInstance().Explosion(cbCPU.SelectedIndex, cbRam.SelectedIndex, cbPB.SelectedIndex, cbGV.SelectedIndex))
            {
                pictureBox2.Size = pictureBox1.Size;
                Console.Beep();
                MessageBox.Show("Комп сгорел! :(", "ОШИБКА!!!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                pictureBox2.Size = new Size(1,1);
                Console.Beep();
            }
            else output.Text = "AMIBIOS (C) 2008 American Megatrends, Inc. \r\nASUS F50Z ACPI BIOS Revision 220 \r\nCPU : AMD Athlon (tm) X2 Dual-Core QL-62 \r\nDCT0 = 667 MHz, DCT1 = N/A \r\n\r\nPress F12 if you want to boot from the network 768MB \r\nOK (Installed Memory Size: 1024MB) \r\nAuto-detecting USB Mass Storage Devices . 00 \r\nUSB mass storage devices found and configured.";
        }
    }
}

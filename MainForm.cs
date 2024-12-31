using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkilliEvYonetim
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 saniyede bir güncelle
            timer.Tick += (s, ev) =>
            {
                lblTarihSaat.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
            };
            timer.Start();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}

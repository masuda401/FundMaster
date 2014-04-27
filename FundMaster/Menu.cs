using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FundMaster
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void 銘柄情報登録ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FundMaster fm = new FundMaster();
            DialogResult dr = fm.ShowDialog();
        }

        private void 銘柄情報一覧ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FundList fl = new FundList();
            DialogResult dr = fl.ShowDialog();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}

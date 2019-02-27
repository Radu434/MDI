using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public frmCautare fCautare;
        public frmAdaugare fAdaugare;
        public frmModificare fModificare;
        public frmStergere fStergere;

        private void cautareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCautare = new frmCautare();
            fCautare.MdiParent = this;
            fCautare.Show();
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdaugare = new frmAdaugare();
            fAdaugare.MdiParent = this;
            fAdaugare.Show();
        }

        private void modificareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fModificare = new frmModificare();
            fModificare.MdiParent = this;
            fModificare.Show();
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStergere = new frmStergere();
            fStergere.MdiParent = this;
            fStergere.Show();
        }
    }
}

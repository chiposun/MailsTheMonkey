using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailsTheMonkey
{
    public partial class thrSL : Form
    {
        public thrSL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secSL f = new secSL();
            f.Show(); 
            Hide();

        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            forSL f = new forSL();
            f.Show();
            Hide();
        }
    }
}

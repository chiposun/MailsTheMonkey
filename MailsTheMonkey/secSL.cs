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
    public partial class secSL : Form
    {
        public secSL()
        {
            InitializeComponent();
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            thrSL f = new thrSL();
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstSL f = new firstSL();
            f.Show();
            Hide();
        }
    }
}

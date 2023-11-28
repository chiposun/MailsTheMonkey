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
    public partial class forSL : Form
    {
        public forSL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sadSL f = new sadSL();
            f.Show();
            Hide();
        }
    }
}

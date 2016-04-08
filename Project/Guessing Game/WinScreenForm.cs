using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class WinScreenForm : Form
    {
        public WinScreenForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            StartScreenForm startScreenForm = new StartScreenForm();
            startScreenForm.Show();
            this.Close();
        }
    }
}

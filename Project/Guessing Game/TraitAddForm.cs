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
    public partial class TraitAddForm : Form
    {
        public TraitAddForm()
        {
            InitializeComponent();
            ChangeText();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            PlayerData.AddQuestion(traitName.Text, PlayerData.newAnimal);
            StartScreenForm startScreenForm = new StartScreenForm();
            startScreenForm.Show();
            this.Close();
        }
    }
}

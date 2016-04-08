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
    public partial class AnimalAddForm : Form
    {
        public AnimalAddForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            PlayerData.newAnimal = animalName.Text;
            TraitAddForm traitAddForm = new TraitAddForm();
            traitAddForm.Show();
            this.Hide();
        }
    }
}

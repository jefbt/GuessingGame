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
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
            PlayerData.ResetCurrentQuestion();
            AdjustForm();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            AnswerCurrentQuestion(true);
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            AnswerCurrentQuestion(false);
        }
    }
}

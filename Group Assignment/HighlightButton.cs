using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment
{
    public partial class UserControl1 : UserControl
    {
        private ButtonStyle.Highlight highlight;
        public Label MainPageLabel { get; set; }
        public UserControl1()
        {
            InitializeComponent();
            highlight = new ButtonStyle.Highlight(this.panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            highlight.ActivateButton(sender, ButtonStyle.RGBcolors.lightGreen);
        }
    }
}

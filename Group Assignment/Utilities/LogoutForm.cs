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
    public partial class confirmForm : Form
    {
        public confirmForm()
        {
            InitializeComponent();
        }

        //Button Function
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Load Animation
        int Yincrement, y, parentx, parenty, parentwidth, parentheight; //used in FormLoad and Tick 
        private void confirmEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Yincrement >= parenty + y)
            {
                Opacity = 1;
                this.Location = new Point(
                    parentx + ((parentwidth - this.Size.Width) / 2),
                    parenty + ((parentheight - this.Size.Height) / 2));
                confirmEffect_Timer.Stop();
            }
            else
            {
                if (Opacity <= 1)
                    Opacity += .03;
                Yincrement += y / 30;
                this.Location = new Point(
                    parentx + ((parentwidth - this.Size.Width) / 2), Yincrement);
            }
        }

        private void confirmForm_Load(object sender, EventArgs e)
        {
            parentx = this.Owner.Location.X;
            parenty = this.Owner.Location.Y;
            parentwidth = this.Owner.Size.Width;
            parentheight = this.Owner.Size.Height;

            Yincrement = parenty;
            y = (parentheight - this.Size.Height) / 2;

            this.Location = new Point(
                parentx + ((parentwidth - this.Size.Width) / 2),
                parenty + ((parentheight - this.Size.Height) / 2));
        }
    }
}


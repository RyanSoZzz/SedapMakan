using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment
{
    public class Gradient_Panel : Panel
    {

        [Category("Gradient")]
        [Description("Sets the first color of the gradient.")]
        public Color gradientColor1 { get; set; } = Color.HotPink;


        [Category("Gradient")]
        [Description("Sets the second color of the gradient.")]
        public Color gradientColor2 { get; set; } = Color.White;

        private float gradientAngleP = 90F;

        [Category("Gradient")]
        [Description("Sets the angle of the gradient in degrees.")]
        public float gradientAngle
        {
            get { return gradientAngleP; }
            set
            {
                if (value < 0 || value > 360)
                    throw new ArgumentOutOfRangeException("GradientAngle", "Angle must be between 0 and 360 degrees.");
                gradientAngleP = value;
                this.Invalidate();
            } 
        }
        private void Panel_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            LinearGradientBrush linear = new LinearGradientBrush(this.ClientRectangle, this.gradientColor1, this.gradientColor2, gradientAngleP);
            g.FillRectangle(linear, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}

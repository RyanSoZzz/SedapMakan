using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment
{
    public class ButtonStyle
    {
        //List of necessary color 
        public struct RGBcolors
        {
            public static Color lightBlack = Color.FromArgb(25, 25, 25);
            public static Color darkGreen = Color.FromArgb(0, 67, 35);
            public static Color lightGreen = Color.FromArgb(0, 105, 56);
            public static Color limeGreen = Color.FromArgb(50, 205, 50);
            public static Color nougat = Color.FromArgb(208, 204, 171);
            public static Color white = Color.FromArgb(230, 230, 230);
        }

        //IMPORTANT!!!
        //Use this must required currentBtn inside the form code!!
        public class Highlight
        {
            private Button currentBtn;
            private Panel leftBorderBtn;

            public Highlight(Panel pnl)
            {
                //Create the highlight after loaded
                leftBorderBtn = new Panel();
                leftBorderBtn.Size = new Size(5, 60);
                pnl.Controls.Add(leftBorderBtn);
            }

            //Wait function to trigger
            public Button ActivateButton(object senderBtn, Color color, Button currentButton)
            {
                currentBtn = currentButton;
                if (senderBtn != null)
                {
                    DisableButton();

                    //The button
                    currentBtn = (Button)senderBtn;
                    currentBtn.BackColor = RGBcolors.lightBlack;
                    currentBtn.ForeColor = RGBcolors.white;
                    currentBtn.Location = new Point(currentBtn.Location.X + 5, currentBtn.Location.Y);

                    //The left border button 
                    if (leftBorderBtn.Parent != null)
                        leftBorderBtn.Parent.Controls.Remove(leftBorderBtn);

                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;

                    currentBtn.Parent.Controls.Add(leftBorderBtn);
                    leftBorderBtn.BringToFront();
                }

                return currentBtn;
            }

            private void DisableButton()
            {
                if (currentBtn != null)
                {
                    //The button
                    currentBtn.BackColor = RGBcolors.lightBlack;
                    currentBtn.ForeColor = RGBcolors.white;
                    currentBtn.Location = new Point(currentBtn.Location.X - 5, currentBtn.Location.Y);
                }
            }
        }
    }
}

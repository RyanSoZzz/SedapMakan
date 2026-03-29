using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment
{
    internal class CloseOtherForms
    {
        public static void CloseAllFormsExcept(Form keepOpen)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form != keepOpen)
                    form.Close();
            }
        }
    }
}

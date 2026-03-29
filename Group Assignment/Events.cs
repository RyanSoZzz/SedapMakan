using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment.LoginPage
{
    public interface IFormWithAllLoginEvents
    {
        event EventHandler<DataTableEventArgs> finishedLoginEvent;
    }

    public interface IFormWithAllOrderEvents
    {
        event EventHandler<DataTableEventArgs> addOrderItem;
        event EventHandler<DataRowEventArgs> statusChangedOrderItem;
    }

    public interface  IFormWithAllUniversalEvents
    {
        event EventHandler<FormEventArgs> changeFormEvent;
    }

    public class FormEventArgs : EventArgs
    {
        public Form FormToShow { get; }

        public FormEventArgs(Form form)
        {
            FormToShow = form;
        }
    }
    public class DataTableEventArgs : EventArgs
    {
        public DataTable DataTableToShow { get; }

        public DataTableEventArgs(DataTable datatable)
        {
            DataTableToShow = datatable;
        }
    }
    public class DataRowEventArgs : EventArgs
    {
        public DataRow DataRowToShow { get; }

        public DataRowEventArgs(DataRow datarow)
        {
            DataRowToShow = datarow;
        }
    }

    public class CustomMethod
    {
        public void openRolePage(
            Form theRolePage,
            Form theFormToClose
            )
        {
            theRolePage.Show();
            theFormToClose?.Close(); //Close the form that was open before
        }

        public void openChildForm(
            Form childForm,
            Form activeForm,
            Panel panelToShowForm,
            EventHandler<FormEventArgs> changeFormEventHandler = null,
            EventHandler<DataTableEventArgs> finishedLoginEvent = null
        )
        {
            if (activeForm != null)
            {
                if (panelToShowForm.Tag is IFormWithAllUniversalEvents oldForm0)
                    oldForm0.changeFormEvent -= changeFormEventHandler;
                if (panelToShowForm.Tag is IFormWithAllLoginEvents oldForm1)
                    oldForm1.finishedLoginEvent -= finishedLoginEvent;
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false; //Allowing the form to be a child of the panel
            childForm.Dock = DockStyle.Fill; //Filling the panel with the child form
            panelToShowForm.Controls.Add(childForm); //Adding the child form to the panel
            panelToShowForm.Tag = childForm; //

            if (childForm is IFormWithAllUniversalEvents formWithAllUniversalEvents)
                formWithAllUniversalEvents.changeFormEvent += changeFormEventHandler; //Subscribe to the event
            if (childForm is IFormWithAllLoginEvents formWithAllLoginEvents)
                formWithAllLoginEvents.finishedLoginEvent += finishedLoginEvent;

            childForm.BringToFront();
            childForm.Show();
        }
    }
}

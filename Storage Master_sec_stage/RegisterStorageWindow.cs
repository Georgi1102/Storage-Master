using Storage_Master_first_stage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage_Master_sec_stage
{
    public partial class RegisterStorageWindow : Form
    {

        public RegisterStorageWindow()
        {
            InitializeComponent();
            FillListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StorageMaster st = new StorageMaster();

               
               
                string type = typeText.Text;
                string name = nameText.Text;

                string result = st.RegisterStorage(type, name);


                if (CheckIfFormIsOpen("Form1"))
                {
                    var currForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form.Name == "Form1");

                    var mainWin = (Form1)currForm;

                    mainWin.ControlPanel.Text = result;
                    mainWin.CommandHistory.Items.Add(result);
                    var storages = st.Storages;

                    foreach (var storage in storages)
                    {
                        mainWin.regStorages.Items.Add(storage.Key);
                    }

                    mainWin.Refresh();

                    Close();
                }
            }
            catch (InvalidOperationException ex)
            {

                //main window will always be Form1
                var currForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form.Name == "Form1");
                var mainWin = (Form1)currForm;

                mainWin.ControlPanel.Text = ex.Message;

                Close();
            }

        }

        public bool CheckIfFormIsOpen(string formname)
        {
            bool formOpen = Application.OpenForms.Cast<Form>().Any(form => form.Name == formname);

            return formOpen;
        }

        private void FillListBox()
        {        
            this.StoragesAv.Items.Add("AutomatedWarehouse");
            this.StoragesAv.Items.Add("DistributionCenter");
            this.StoragesAv.Items.Add("Warehouse");
        }

        private void StoragesAv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = this.StoragesAv.SelectedItem.ToString();
            this.typeText.Text = selectedType;
        }
    }
}


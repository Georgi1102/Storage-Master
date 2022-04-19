using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage_Master_first_stage;
using Storage_Master_first_stage.Entities;
using Storage_Master_first_stage.Entities.Products;

namespace Storage_Master_sec_stage
{
    public partial class AddProductWindow : Form
    {
        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            StorageMaster st = new StorageMaster();
           
            string type = typeText.Text;
            string price = priceText.Text;

            double nonInputPrice = double.Parse(price);


            string result = st.AddProduct(type, nonInputPrice);


            if (CheckIfFormIsOpen("Form1"))
            {
                var currForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form.Name == "Form1");

                var mainWin = (Form1)currForm;

                

                mainWin.ControlPanel.Text = result;
                mainWin.CommandHistory.Items.Add(result);

                mainWin.ControlPanel.AppendText(Environment.NewLine);
                mainWin.Refresh();

                Close();
            }
          
        }

        public bool CheckIfFormIsOpen(string formname)
        {
            bool formOpen = Application.OpenForms.Cast<Form>().Any(form => form.Name == formname);

            return formOpen;
        }
    }
}

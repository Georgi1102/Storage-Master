using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Storage_Master_first_stage;

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
            try
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
                    var products = st.Products;

                    foreach (var product in products)
                    {
                        mainWin.AddedProducts.Items.Add(product.Key);
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
    }
}

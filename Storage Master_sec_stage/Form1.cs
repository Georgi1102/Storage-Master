using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage_Master_first_stage.Entities;

namespace Storage_Master_sec_stage
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            //take input name from other text or box use it
            //and than display in control panel that the product is added

            AddProductWindow win = new AddProductWindow();

            win.Show();
        }

        private void regStorage_Click(object sender, EventArgs e)
        {
            RegisterStorageWindow win = new RegisterStorageWindow();

            win.Show();
        }
    }
}

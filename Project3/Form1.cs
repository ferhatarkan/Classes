using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerManager customerManager = new CustomerManager();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            dgrwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void gbxAdd_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(tbxId.Text);
            customer.FirsName = tbxFirsName.Text;
            customer.LastName = tbxLastName.Text;
            customer.Email = tbxEmail.Text;
            customer.City = tbxCity.Text;

            customerManager.Add(customer);
            dgrwCustomers.DataSource = null;
            dgrwCustomers.DataSource = customerManager.GetAll();

        }
    }
}

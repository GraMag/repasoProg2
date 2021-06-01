using Application.Helpers;
using Application.Models;
using Application.Repositories;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmCustomer : Form
    {
        protected CustomerRepository customerRepository;


        public FrmCustomer()
        {
            InitializeComponent();
        }

        public FrmCustomer(CustomerRepository customerRepository):this()
        {
            this.customerRepository = customerRepository;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer(txtName.Text, txtLastName.Text, Convert.ToInt32(txtAge.Text));
                this.customerRepository.Create(customer);
                MessageBox.Show("Cliente Crado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Logger.LogException(exc.Message);
            }
        }
    }
}

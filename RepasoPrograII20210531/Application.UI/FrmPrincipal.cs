using System;
using System.Windows.Forms;
using Application.Repositories;
using Application.Helpers;



namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        CustomerRepository customerRepository;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.customerRepository = new CustomerRepository();

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)//SE VA
        {
            DialogResult restult = MessageBox.Show("Esta seguro que desea cerrar?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (restult == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void visualizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerVisualizer frm = new FrmCustomerVisualizer(this.customerRepository);

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                //TODO completar
                throw new NotImplementedException();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se puede abrir: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogException(ex.Message);
            }
        }
        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.customerRepository.SaveToFile(customerRepository.GetAll()))
                {
                    MessageBox.Show("Clientes serializados exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se puede Guardar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se puede Guardar: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogException(ex.Message);
            }
        }
    }
}

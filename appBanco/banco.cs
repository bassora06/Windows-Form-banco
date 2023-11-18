using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBanco
{
    public partial class banco : Form
    {

        Cliente cliente;

        public banco()
        {
            InitializeComponent();

            this.cliente = new Cliente();
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void banco_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(TextBoxDepositar.Text);

                if (valor > 0)
                {

                    cliente.Creditar(valor);

                    MessageBox.Show("Transferencia realizada com sucesso!!!");

                    labelSaldo.Text = cliente.saldo.ToString();

                }
                else
                {
                    MessageBox.Show("Insira um valor maior que zero!!!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(TextBoxSacar.Text);

                if (valor <= cliente.saldo && valor > 0)
                {
                    cliente.Debitar(valor);

                    MessageBox.Show("Transferencia realizada com sucesso!!!");

                    labelSaldo.Text = cliente.saldo.ToString();

                }

                if (valor <= 0)
                {
                    MessageBox.Show("Insira um valor maior que zero!!!");
                }

                if (valor > cliente.saldo)
                {
                    MessageBox.Show("Insira um valor menor que seu saldo atual!!!");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
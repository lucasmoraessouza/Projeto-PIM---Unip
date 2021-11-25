using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PIM_FINAL
{
    public partial class CadastroHospede : Form
    {
        Thread nt;
        Hospedes hospede = new Hospedes();
        public CadastroHospede()
        {
            InitializeComponent();
        }

        private void btnCadastroHospede_Click(object sender, EventArgs e)
        {
            if(txbNome.Text == "" | txbNasc.Text == "" | txbCpf.Text == null | txbEmail.Text == "" | txbCep.Text == "" | txbTelefone.Text == "")
            {
                MessageBox.Show("ERRO! Preencha todos os campos.");
            }
            else
            {
            hospede.Cadastro(txbNome.Text, txbNasc.Text, txbCpf.Text, txbEmail.Text, txbCep.Text, txbTelefone.Text);
            MessageBox.Show(hospede.mensagem);
            this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backToMenu(object obj)
        {
            Application.Run(new Menu());
        }

        private void txbCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

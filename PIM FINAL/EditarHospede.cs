using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIM_FINAL
{
    public partial class EditarHospede : Form
    {
        string idHospede;
        AdministrarHospedes administrarHospedes;
        Hospedes hospede = new Hospedes();
        public EditarHospede(AdministrarHospedes formulario)
        {
            InitializeComponent();
            administrarHospedes = formulario;
        }

        private void EditarHospede_Load(object sender, EventArgs e)
        {

            idHospede = administrarHospedes.idHospedeSelecionado;
           
            DataTable infoHospede = hospede.ListarId(idHospede);

            if(infoHospede.Rows.Count > 0) {
            
                txbAtualizarNome.Text = infoHospede.Rows[0]["nome"].ToString();
                txbAtualizarNasc.Text = infoHospede.Rows[0]["nascimento"].ToString();
                txbAtualizarCpf.Text = infoHospede.Rows[0]["cpf"].ToString();
                txbAtualizarEmail.Text = infoHospede.Rows[0]["email"].ToString();
                txbAtualizarCep.Text = infoHospede.Rows[0]["cep"].ToString();
                txbAtualizarTelefone.Text = infoHospede.Rows[0]["telefone"].ToString();
            }
            else
            {
                MessageBox.Show("Hospede não encontrado!");
            }

        }

        private void btnAtualizarHospede_Click(object sender, EventArgs e)
        {
            if (txbAtualizarNome.Text == "" ^ txbAtualizarNasc.Text == "" ^ txbAtualizarCpf.Text == null ^ txbAtualizarEmail.Text == "" ^ txbAtualizarCep.Text == "" ^ txbAtualizarTelefone.Text == "")
            {
                MessageBox.Show("Erro! Campo vazio.");
            }
            else
            {
            hospede.AtualizarCadastro(idHospede, txbAtualizarNome.Text, txbAtualizarNasc.Text, txbAtualizarCpf.Text, txbAtualizarEmail.Text, txbAtualizarCep.Text, txbAtualizarTelefone.Text);
            MessageBox.Show(hospede.mensagem);

            administrarHospedes.PreencherDatagrid();
            this.Close();
            }




        }
    }
}

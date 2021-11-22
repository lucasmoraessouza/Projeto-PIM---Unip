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
    public partial class AdministrarHospedes : Form
    {
        public string idHospedeSelecionado;
        Hospedes hospede = new Hospedes();

        Thread nt;
        public AdministrarHospedes()
        {
            InitializeComponent();
        }

        public void PreencherDatagrid()
        {

            DataTable listarNome = hospede.ListarNome(txbFiltroNome.Text);
            dataGridListagemHospedes.DataSource = listarNome;

            txtValorTotal.Text = listarNome.Rows.Count.ToString();
        }

        private void backToMenu(object obj)
        {
            Application.Run(new Menu());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdministrarHospedes_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            PreencherDatagrid();
        }

        private void btnDeletarHospede_Click(object sender, EventArgs e)
        {
            hospede.ExcluirHospede(idHospedeSelecionado);
            MessageBox.Show(hospede.mensagem);
            PreencherDatagrid();
        }

        private void dataGridListagemHospedes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idHospedeSelecionado = dataGridListagemHospedes.Rows[e.RowIndex].Cells["id"].Value.ToString();
            if(idHospedeSelecionado != "")
            {
                btnEditarHospede.Enabled = true;
                btnDeletarHospede.Enabled = true;
            }

        }

        private void btnEditarHospede_Click(object sender, EventArgs e)
        {
            EditarHospede editarHospede = new EditarHospede(this);
            editarHospede.Show();
        }

        private void btnAdicionarHospede_Click(object sender, EventArgs e)
        {
            CadastroHospede cadastroHospede = new CadastroHospede();
            cadastroHospede.Show();
        }
    }
}

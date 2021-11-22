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
    public partial class ConsultarReserva : Form
    {
        Thread nt;
        Reservas reserva = new Reservas();
        public string idReservaSelecionada;
        public ConsultarReserva()
        {
            InitializeComponent();
        }

        public void PreencherDatagrid()
        {
            
            DataTable listarReserva = reserva.ListarPorHospede(txbBuscarNome.Text);
            datagridReservas.DataSource = listarReserva;
            labelReservasEncontradas.Text = listarReserva.Rows.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backToMenu(object obj)
        {
            Application.Run(new Menu());
        }

        private void btnBuscarHospede_Click(object sender, EventArgs e)
        {
            PreencherDatagrid();
        }
        private void datagridReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            idReservaSelecionada = datagridReservas.Rows[e.RowIndex].Cells["Numero da Reserva"].Value.ToString();
            btnDeletarReserva.Enabled = true;
            btnEditarReserva.Enabled=true;
        }

        private void btnDeletarReserva_Click(object sender, EventArgs e)
        {
            reserva.ExcluirReserva(idReservaSelecionada);
            MessageBox.Show(reserva.mensagem);
            PreencherDatagrid();

        }

        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            EditarReserva editarReserva = new EditarReserva(this);
            editarReserva.Show();
        }

    }
}

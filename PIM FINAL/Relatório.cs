using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIM_FINAL
{
    public partial class Relatório : Form
    {
        Reservas reservas = new Reservas();
        DateTime dateEntrada;
        DateTime dateSaida;
        public Relatório()
        {
            InitializeComponent();
        }

        public void PreencherDatagrid()
        {
            DataTable listarReservas = reservas.GerarRelatorio(dateEntrada, dateSaida);
            dataGridReservas.DataSource = listarReservas;
            labelValorTotalReservas.Text = listarReservas.Rows.Count.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dateEntrada = dateTimePickerEntrada.Value;
            dateSaida = dateTimePickerSaida.Value;

            PreencherDatagrid();

            DataTable valorTotalRelatorio = reservas.ValorTotalRelatorio(dateEntrada, dateSaida);
                
            labelValorTotal.Text ="R$" + valorTotalRelatorio.Rows[0]["total"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

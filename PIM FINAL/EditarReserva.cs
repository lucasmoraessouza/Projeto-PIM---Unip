using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace PIM_FINAL
{
    public partial class EditarReserva : Form
    {
        string idReserva;
        float valorTotal;
        Reservas reservas = new Reservas();
        Quartos quartos = new Quartos();

        ConsultarReserva consultarReserva;
        DataTable listarQuartos = new DataTable();
        public EditarReserva(ConsultarReserva formulario)
        {
            InitializeComponent();
            consultarReserva = formulario;
        }

        private void CalcularValorTotal()
        {
            labelValorTotalReserva.Text = (datapickerAtualizarSaida.Value.Subtract(datapickerAtualizarEntrada.Value).Days * valorTotal).ToString();
        }

        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            idReserva = consultarReserva.idReservaSelecionada;
            DataTable infoReservas = reservas.ListarReservasPorId(idReserva);
            DateTime dateSaida = datapickerAtualizarSaida.Value;
            DateTime dateEntrada = datapickerAtualizarEntrada.Value;

            int dias = dateSaida.Subtract(dateEntrada).Days;

            if(dias < 1)
            {
                MessageBox.Show("ERRO! Data inválida!");
            }

            else if (comboBoxAtualizarQuartos.Text == "" | datapickerAtualizarEntrada.Value == null | datapickerAtualizarSaida.Value == null)
            {
                MessageBox.Show("ERRO! Preencha todos os campos!");
            }
            else
            {
                reservas.AtualizarReserva(idReserva, comboBoxAtualizarQuartos.Text, datapickerAtualizarEntrada.Value, datapickerAtualizarSaida.Value);
                MessageBox.Show(reservas.mensagem);

                consultarReserva.PreencherDatagrid();
                this.Close();
            }
        }

        private void EditarReserva_Load(object sender, EventArgs e)
        {
            idReserva = consultarReserva.idReservaSelecionada;
            DataTable infoReservas = reservas.ListarReservasPorId(idReserva);
            listarQuartos = quartos.ListarQuartosDisponiveis();
                   
            comboBoxAtualizarQuartos.DataSource = listarQuartos;
            comboBoxAtualizarQuartos.ValueMember = "numeroQuarto";
            comboBoxAtualizarQuartos.DisplayMember = "numeroQuarto";

           

            if (infoReservas.Rows.Count > 0)
            {
                DataRow workRow = listarQuartos.NewRow();
                workRow["numeroQuarto"] = infoReservas.Rows[0]["numeroQuarto"].ToString();
                listarQuartos.Rows.Add(workRow);
                comboBoxAtualizarQuartos.Text = infoReservas.Rows[0]["numeroQuarto"].ToString();

                txbNomeHospede.Text = infoReservas.Rows[0]["nome"].ToString();

                DateTime dateSaida = (DateTime)infoReservas.Rows[0]["dataSaida"];
                DateTime dateEntrada = (DateTime)infoReservas.Rows[0]["dataEntrada"];
                datapickerAtualizarSaida.Value = dateSaida;
                datapickerAtualizarEntrada.Value = dateEntrada;

                float valor = float.Parse(infoReservas.Rows[0]["valor"].ToString());
                labelValorQuarto.Text = valor.ToString();
                labelValorTotalReserva.Text = (dateSaida.Subtract(dateEntrada).Days * valor).ToString();

                valorTotal = valor;

            } else
            {
                MessageBox.Show("Reserva não encontrada.");
            }

        }

        private void datapickerAtualizarEntrada_ValueChanged(object sender, EventArgs e)
        {
            CalcularValorTotal();
        }

        private void datapickerAtualizarSaida_ValueChanged(object sender, EventArgs e)
        {
            CalcularValorTotal();

        }

        private void comboBoxAtualizarQuartos_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < listarQuartos.Rows.Count; i++)
            {
                if (listarQuartos.Rows[i]["numeroQuarto"].ToString() == comboBoxAtualizarQuartos.Text)
                {
                    valorTotal = float.Parse(listarQuartos.Rows[i]["valor"].ToString());
                }
            }
            CalcularValorTotal();
        }

        private void labelValorTotalReserva_Click(object sender, EventArgs e)
        {

        }
    }
}

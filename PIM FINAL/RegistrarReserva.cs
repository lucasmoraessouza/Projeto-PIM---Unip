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
    public partial class RegistrarReserva : Form
    {
        Thread nt;
        DataTable listarQuartos = new DataTable();
        string idHospedeSelecionado;
        Reservas reservas = new Reservas();
        Hospedes hospede = new Hospedes();
        Quartos quartos = new Quartos();
        float valorTotal;

        public RegistrarReserva()
        {
            InitializeComponent();
        }
        public void PreencherDatagrid()
        {
             DataTable listarNome = hospede.ListarNome(txbBuscarHospede.Text);
             dataGridHospedes.DataSource = listarNome;
             labelValorTotal.Text = listarNome.Rows.Count.ToString();
        }

        private void CalcularValorTotal()
        {
            labelValorTotalReserva.Text = (datapickerSaida.Value.Subtract(datapickerEntrada.Value).Days * valorTotal).ToString();
        }

        private void backToMenu(object obj)
        {
            Application.Run(new Menu());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarHospede_Click(object sender, EventArgs e)
        {
            PreencherDatagrid();
        }

        private void RegistrarReserva_Load(object sender, EventArgs e)
        {


            listarQuartos = quartos.ListarQuartosDisponiveis();


            if (listarQuartos.Rows.Count > 0)
            {
                comboBoxQuartos.DataSource = listarQuartos;
                comboBoxQuartos.ValueMember = "numeroQuarto";
                comboBoxQuartos.DisplayMember = "numeroQuarto";
                comboBoxQuartos.Refresh();
            }
            else
            {
                MessageBox.Show("ERRO (vazio) ");
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            DateTime dateSaida = datapickerSaida.Value;
            DateTime dateEntrada = datapickerEntrada.Value;

            int dias = dateSaida.Subtract(dateEntrada).Days;

            if (dias < 1)
            {
                MessageBox.Show("ERRO! Data inválida!");
            } else if (comboBoxQuartos.Text == "")
            {
                MessageBox.Show("ERRO! Preencha todos os campos");
            }
            else
            {
            reservas.RegistrarReserva(idHospedeSelecionado, comboBoxQuartos.Text, datapickerEntrada.Value, datapickerSaida.Value);
            MessageBox.Show(reservas.mensagem);
            }
        }

        private void dataGridHospedes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idHospedeSelecionado = dataGridHospedes.Rows[e.RowIndex].Cells["id"].Value.ToString();

            datapickerEntrada.Enabled = true;
            datapickerSaida.Enabled = true;
            comboBoxQuartos.Enabled = true;


        }

        private void comboBoxQuartos_SelectedValueChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < listarQuartos.Rows.Count; i++)
            {
                if (listarQuartos.Rows[i]["numeroQuarto"].ToString() == comboBoxQuartos.Text)
                {
                    valorTotal = float.Parse(listarQuartos.Rows[i]["valor"].ToString());
                }
            }
            labelValorQuarto.Text = valorTotal.ToString();
            CalcularValorTotal();

            btnReservar.Enabled = true;
        }

        private void datapickerEntrada_ValueChanged(object sender, EventArgs e)
        {
            CalcularValorTotal();
        }

        private void datapickerSaida_ValueChanged(object sender, EventArgs e)
        {
            CalcularValorTotal();
        }
    }
}

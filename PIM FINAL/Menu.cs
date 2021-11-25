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
    public partial class Menu : Form
    {
        Thread nt;
        public Menu()
        {
            InitializeComponent();
            btnCadastrarHospede.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarReserva consultarReserva = new ConsultarReserva();
            consultarReserva.ShowDialog();
            //nt = new Thread(ConsultarReserva);
            //nt.SetApartmentState(ApartmentState.STA);
            //nt.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroHospede cadastroHospede = new CadastroHospede();
            cadastroHospede.ShowDialog();
            //this.Close();
            //nt = new Thread(RegisterHospede);
            //nt.SetApartmentState(ApartmentState.STA);
            //nt.Start();
        }

        private void RegisterHospede(object obj)
        {
            Application.Run(new CadastroHospede());
        }

        private void ConsultarReserva(object obj)
        {
            Application.Run(new ConsultarReserva());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            AdministrarHospedes administrarHospedes = new AdministrarHospedes();
            administrarHospedes.ShowDialog();
            //this.Close();
            //nt = new Thread(AdministrarHospedes);
            //nt.SetApartmentState(ApartmentState.STA);
            //nt.Start();
        }

        private void AdministrarHospedes(object obj)
        {
            Application.Run(new AdministrarHospedes());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistrarReserva registrarReserva = new RegistrarReserva();
            registrarReserva.ShowDialog();

            //this.Close();
            //nt = new Thread(RegistrarReserva);
            //nt.SetApartmentState(ApartmentState.STA);
            //nt.Start();
        }

        private void RegistrarReserva(object obj)
        {
            Application.Run(new RegistrarReserva());
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelatório_Click(object sender, EventArgs e)
        {
            Relatório relatório = new Relatório();
            relatório.ShowDialog();

        }
    }
}

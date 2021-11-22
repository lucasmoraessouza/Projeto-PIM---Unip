namespace PIM_FINAL
{
    partial class RegistrarReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txbBuscarHospede = new System.Windows.Forms.TextBox();
            this.datapickerSaida = new System.Windows.Forms.DateTimePicker();
            this.datapickerEntrada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarHospede = new System.Windows.Forms.Button();
            this.dataGridHospedes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.comboBoxQuartos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelValorQuarto = new System.Windows.Forms.Label();
            this.labelValorTotalReserva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(260, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Reserva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(528, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº Quarto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(668, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Saída";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(528, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de entrada";
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.btnReservar.Enabled = false;
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReservar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnReservar.Location = new System.Drawing.Point(556, 359);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(186, 28);
            this.btnReservar.TabIndex = 7;
            this.btnReservar.Text = "Realizar Reserva";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button2.Location = new System.Drawing.Point(701, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbBuscarHospede
            // 
            this.txbBuscarHospede.Location = new System.Drawing.Point(39, 112);
            this.txbBuscarHospede.Name = "txbBuscarHospede";
            this.txbBuscarHospede.Size = new System.Drawing.Size(358, 23);
            this.txbBuscarHospede.TabIndex = 1;
            // 
            // datapickerSaida
            // 
            this.datapickerSaida.CustomFormat = "dd/MM/yyyy";
            this.datapickerSaida.Enabled = false;
            this.datapickerSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datapickerSaida.Location = new System.Drawing.Point(668, 184);
            this.datapickerSaida.Name = "datapickerSaida";
            this.datapickerSaida.Size = new System.Drawing.Size(108, 23);
            this.datapickerSaida.TabIndex = 5;
            this.datapickerSaida.ValueChanged += new System.EventHandler(this.datapickerSaida_ValueChanged);
            // 
            // datapickerEntrada
            // 
            this.datapickerEntrada.CustomFormat = "dd/MM/yyyy";
            this.datapickerEntrada.Enabled = false;
            this.datapickerEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datapickerEntrada.Location = new System.Drawing.Point(528, 184);
            this.datapickerEntrada.Name = "datapickerEntrada";
            this.datapickerEntrada.Size = new System.Drawing.Size(108, 23);
            this.datapickerEntrada.TabIndex = 4;
            this.datapickerEntrada.ValueChanged += new System.EventHandler(this.datapickerEntrada_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Buscar por hóspede";
            // 
            // btnBuscarHospede
            // 
            this.btnBuscarHospede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.btnBuscarHospede.FlatAppearance.BorderSize = 0;
            this.btnBuscarHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarHospede.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarHospede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnBuscarHospede.Location = new System.Drawing.Point(414, 112);
            this.btnBuscarHospede.Name = "btnBuscarHospede";
            this.btnBuscarHospede.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarHospede.TabIndex = 2;
            this.btnBuscarHospede.Text = "Buscar";
            this.btnBuscarHospede.UseVisualStyleBackColor = false;
            this.btnBuscarHospede.Click += new System.EventHandler(this.btnBuscarHospede_Click);
            // 
            // dataGridHospedes
            // 
            this.dataGridHospedes.AllowUserToAddRows = false;
            this.dataGridHospedes.AllowUserToDeleteRows = false;
            this.dataGridHospedes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dataGridHospedes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHospedes.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridHospedes.Location = new System.Drawing.Point(39, 140);
            this.dataGridHospedes.Name = "dataGridHospedes";
            this.dataGridHospedes.ReadOnly = true;
            this.dataGridHospedes.RowTemplate.Height = 25;
            this.dataGridHospedes.Size = new System.Drawing.Size(450, 247);
            this.dataGridHospedes.TabIndex = 3;
            this.dataGridHospedes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHospedes_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(39, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total de hóspedes encontrado: ";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValorTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValorTotal.Location = new System.Drawing.Point(260, 394);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(15, 17);
            this.labelValorTotal.TabIndex = 23;
            this.labelValorTotal.Text = "0";
            // 
            // comboBoxQuartos
            // 
            this.comboBoxQuartos.Enabled = false;
            this.comboBoxQuartos.FormattingEnabled = true;
            this.comboBoxQuartos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxQuartos.Location = new System.Drawing.Point(529, 246);
            this.comboBoxQuartos.Name = "comboBoxQuartos";
            this.comboBoxQuartos.Size = new System.Drawing.Size(247, 23);
            this.comboBoxQuartos.TabIndex = 6;
            this.comboBoxQuartos.SelectedValueChanged += new System.EventHandler(this.comboBoxQuartos_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(527, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Valor do quarto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(529, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Valor total:";
            // 
            // labelValorQuarto
            // 
            this.labelValorQuarto.AutoSize = true;
            this.labelValorQuarto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValorQuarto.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValorQuarto.Location = new System.Drawing.Point(657, 294);
            this.labelValorQuarto.Name = "labelValorQuarto";
            this.labelValorQuarto.Size = new System.Drawing.Size(19, 21);
            this.labelValorQuarto.TabIndex = 27;
            this.labelValorQuarto.Text = "0";
            // 
            // labelValorTotalReserva
            // 
            this.labelValorTotalReserva.AutoSize = true;
            this.labelValorTotalReserva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValorTotalReserva.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValorTotalReserva.Location = new System.Drawing.Point(657, 324);
            this.labelValorTotalReserva.Name = "labelValorTotalReserva";
            this.labelValorTotalReserva.Size = new System.Drawing.Size(19, 21);
            this.labelValorTotalReserva.TabIndex = 28;
            this.labelValorTotalReserva.Text = "0";
            // 
            // RegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelValorTotalReserva);
            this.Controls.Add(this.labelValorQuarto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxQuartos);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridHospedes);
            this.Controls.Add(this.btnBuscarHospede);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datapickerEntrada);
            this.Controls.Add(this.datapickerSaida);
            this.Controls.Add(this.txbBuscarHospede);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Reserva";
            this.Load += new System.EventHandler(this.RegistrarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHospedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbBuscarHospede;
        private System.Windows.Forms.DateTimePicker datapickerSaida;
        private System.Windows.Forms.DateTimePicker datapickerEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarHospede;
        private System.Windows.Forms.DataGridView dataGridHospedes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.ComboBox comboBoxQuartos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelValorQuarto;
        private System.Windows.Forms.Label labelValorTotalReserva;
    }
}
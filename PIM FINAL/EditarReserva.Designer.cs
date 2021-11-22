namespace PIM_FINAL
{
    partial class EditarReserva
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
            this.labelValorTotalReserva = new System.Windows.Forms.Label();
            this.labelValorQuarto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxAtualizarQuartos = new System.Windows.Forms.ComboBox();
            this.datapickerAtualizarEntrada = new System.Windows.Forms.DateTimePicker();
            this.datapickerAtualizarSaida = new System.Windows.Forms.DateTimePicker();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNomeHospede = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelValorTotalReserva
            // 
            this.labelValorTotalReserva.AutoSize = true;
            this.labelValorTotalReserva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValorTotalReserva.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValorTotalReserva.Location = new System.Drawing.Point(169, 296);
            this.labelValorTotalReserva.Name = "labelValorTotalReserva";
            this.labelValorTotalReserva.Size = new System.Drawing.Size(19, 21);
            this.labelValorTotalReserva.TabIndex = 39;
            this.labelValorTotalReserva.Text = "0";
            this.labelValorTotalReserva.Click += new System.EventHandler(this.labelValorTotalReserva_Click);
            // 
            // labelValorQuarto
            // 
            this.labelValorQuarto.AutoSize = true;
            this.labelValorQuarto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValorQuarto.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValorQuarto.Location = new System.Drawing.Point(170, 268);
            this.labelValorQuarto.Name = "labelValorQuarto";
            this.labelValorQuarto.Size = new System.Drawing.Size(19, 21);
            this.labelValorQuarto.TabIndex = 38;
            this.labelValorQuarto.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(43, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 37;
            this.label8.Text = "Valor total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(43, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "Valor do quarto:";
            // 
            // comboBoxAtualizarQuartos
            // 
            this.comboBoxAtualizarQuartos.FormattingEnabled = true;
            this.comboBoxAtualizarQuartos.Items.AddRange(new object[] {
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
            this.comboBoxAtualizarQuartos.Location = new System.Drawing.Point(42, 232);
            this.comboBoxAtualizarQuartos.Name = "comboBoxAtualizarQuartos";
            this.comboBoxAtualizarQuartos.Size = new System.Drawing.Size(247, 23);
            this.comboBoxAtualizarQuartos.TabIndex = 4;
            // 
            // datapickerAtualizarEntrada
            // 
            this.datapickerAtualizarEntrada.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datapickerAtualizarEntrada.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.datapickerAtualizarEntrada.CustomFormat = "dd/MM/yyyy";
            this.datapickerAtualizarEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datapickerAtualizarEntrada.Location = new System.Drawing.Point(41, 171);
            this.datapickerAtualizarEntrada.Name = "datapickerAtualizarEntrada";
            this.datapickerAtualizarEntrada.Size = new System.Drawing.Size(108, 23);
            this.datapickerAtualizarEntrada.TabIndex = 2;
            this.datapickerAtualizarEntrada.ValueChanged += new System.EventHandler(this.datapickerAtualizarEntrada_ValueChanged);
            // 
            // datapickerAtualizarSaida
            // 
            this.datapickerAtualizarSaida.CustomFormat = "dd/MM/yyyy";
            this.datapickerAtualizarSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datapickerAtualizarSaida.Location = new System.Drawing.Point(182, 171);
            this.datapickerAtualizarSaida.Name = "datapickerAtualizarSaida";
            this.datapickerAtualizarSaida.Size = new System.Drawing.Size(108, 23);
            this.datapickerAtualizarSaida.TabIndex = 3;
            this.datapickerAtualizarSaida.ValueChanged += new System.EventHandler(this.datapickerAtualizarSaida_ValueChanged);
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.btnEditarReserva.FlatAppearance.BorderSize = 0;
            this.btnEditarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarReserva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarReserva.Location = new System.Drawing.Point(43, 352);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(247, 28);
            this.btnEditarReserva.TabIndex = 5;
            this.btnEditarReserva.Text = "Alterar";
            this.btnEditarReserva.UseVisualStyleBackColor = false;
            this.btnEditarReserva.Click += new System.EventHandler(this.btnEditarReserva_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(41, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Data de entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(182, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Data Saída";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(41, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nº Quarto";
            // 
            // txbNomeHospede
            // 
            this.txbNomeHospede.Enabled = false;
            this.txbNomeHospede.Location = new System.Drawing.Point(41, 110);
            this.txbNomeHospede.Name = "txbNomeHospede";
            this.txbNomeHospede.Size = new System.Drawing.Size(247, 23);
            this.txbNomeHospede.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(41, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nome Hospede";
            // 
            // EditarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(345, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNomeHospede);
            this.Controls.Add(this.labelValorTotalReserva);
            this.Controls.Add(this.labelValorQuarto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxAtualizarQuartos);
            this.Controls.Add(this.datapickerAtualizarEntrada);
            this.Controls.Add(this.datapickerAtualizarSaida);
            this.Controls.Add(this.btnEditarReserva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "EditarReserva";
            this.Text = "Editar Reserva";
            this.Load += new System.EventHandler(this.EditarReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValorTotalReserva;
        private System.Windows.Forms.Label labelValorQuarto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxAtualizarQuartos;
        private System.Windows.Forms.DateTimePicker datapickerAtualizarEntrada;
        private System.Windows.Forms.DateTimePicker datapickerAtualizarSaida;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNomeHospede;
        private System.Windows.Forms.Label label1;
    }
}
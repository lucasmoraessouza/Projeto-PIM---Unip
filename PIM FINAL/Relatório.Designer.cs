namespace PIM_FINAL
{
    partial class Relatório
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
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerEntrada = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSaida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelValorTotalReservas = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridReservas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(326, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 45);
            this.label6.TabIndex = 12;
            this.label6.Text = "Relatório";
            // 
            // dateTimePickerEntrada
            // 
            this.dateTimePickerEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEntrada.Location = new System.Drawing.Point(33, 110);
            this.dateTimePickerEntrada.Name = "dateTimePickerEntrada";
            this.dateTimePickerEntrada.Size = new System.Drawing.Size(153, 23);
            this.dateTimePickerEntrada.TabIndex = 13;
            // 
            // dateTimePickerSaida
            // 
            this.dateTimePickerSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSaida.Location = new System.Drawing.Point(218, 110);
            this.dateTimePickerSaida.Name = "dateTimePickerSaida";
            this.dateTimePickerSaida.Size = new System.Drawing.Size(153, 23);
            this.dateTimePickerSaida.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(33, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Data de entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(218, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Data de saída";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(31, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Valor total:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValorTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValorTotal.Location = new System.Drawing.Point(121, 360);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(19, 21);
            this.labelValorTotal.TabIndex = 39;
            this.labelValorTotal.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 31);
            this.button1.TabIndex = 40;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnBuscar.Location = new System.Drawing.Point(598, 108);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(135, 25);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(485, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Total de reservas encontradas:";
            // 
            // labelValorTotalReservas
            // 
            this.labelValorTotalReservas.AutoSize = true;
            this.labelValorTotalReservas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValorTotalReservas.ForeColor = System.Drawing.SystemColors.Control;
            this.labelValorTotalReservas.Location = new System.Drawing.Point(708, 360);
            this.labelValorTotalReservas.Name = "labelValorTotalReservas";
            this.labelValorTotalReservas.Size = new System.Drawing.Size(19, 21);
            this.labelValorTotalReservas.TabIndex = 44;
            this.labelValorTotalReservas.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button2.Location = new System.Drawing.Point(701, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 45;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridReservas
            // 
            this.dataGridReservas.AllowUserToAddRows = false;
            this.dataGridReservas.AllowUserToDeleteRows = false;
            this.dataGridReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dataGridReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservas.Location = new System.Drawing.Point(33, 139);
            this.dataGridReservas.Name = "dataGridReservas";
            this.dataGridReservas.ReadOnly = true;
            this.dataGridReservas.RowTemplate.Height = 25;
            this.dataGridReservas.Size = new System.Drawing.Size(700, 218);
            this.dataGridReservas.TabIndex = 46;
            // 
            // Relatório
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridReservas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelValorTotalReservas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerSaida);
            this.Controls.Add(this.dateTimePickerEntrada);
            this.Controls.Add(this.label6);
            this.Name = "Relatório";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntrada;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelValorTotalReservas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridReservas;
    }
}
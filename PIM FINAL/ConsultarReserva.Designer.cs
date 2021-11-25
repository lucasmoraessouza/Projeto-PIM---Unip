namespace PIM_FINAL
{
    partial class ConsultarReserva
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
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBuscarNome = new System.Windows.Forms.TextBox();
            this.btnBuscarHospede = new System.Windows.Forms.Button();
            this.datagridReservas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelReservasEncontradas = new System.Windows.Forms.Label();
            this.btnDeletarReserva = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(236, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "Administrar Reserva";
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
            this.button2.TabIndex = 6;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(37, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar Hóspede:";
            // 
            // txbBuscarNome
            // 
            this.txbBuscarNome.Location = new System.Drawing.Point(37, 104);
            this.txbBuscarNome.Name = "txbBuscarNome";
            this.txbBuscarNome.Size = new System.Drawing.Size(540, 23);
            this.txbBuscarNome.TabIndex = 1;
            // 
            // btnBuscarHospede
            // 
            this.btnBuscarHospede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.btnBuscarHospede.FlatAppearance.BorderSize = 0;
            this.btnBuscarHospede.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarHospede.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarHospede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnBuscarHospede.Location = new System.Drawing.Point(583, 104);
            this.btnBuscarHospede.Name = "btnBuscarHospede";
            this.btnBuscarHospede.Size = new System.Drawing.Size(148, 24);
            this.btnBuscarHospede.TabIndex = 2;
            this.btnBuscarHospede.Text = "Buscar Hóspede";
            this.btnBuscarHospede.UseVisualStyleBackColor = false;
            this.btnBuscarHospede.Click += new System.EventHandler(this.btnBuscarHospede_Click);
            // 
            // datagridReservas
            // 
            this.datagridReservas.AllowUserToAddRows = false;
            this.datagridReservas.AllowUserToDeleteRows = false;
            this.datagridReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.datagridReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridReservas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.datagridReservas.Location = new System.Drawing.Point(37, 133);
            this.datagridReservas.Name = "datagridReservas";
            this.datagridReservas.ReadOnly = true;
            this.datagridReservas.RowTemplate.Height = 25;
            this.datagridReservas.Size = new System.Drawing.Size(694, 233);
            this.datagridReservas.TabIndex = 3;
            this.datagridReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridReservas_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(37, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Total de reservas encontradas:";
            // 
            // labelReservasEncontradas
            // 
            this.labelReservasEncontradas.AutoSize = true;
            this.labelReservasEncontradas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelReservasEncontradas.ForeColor = System.Drawing.SystemColors.Control;
            this.labelReservasEncontradas.Location = new System.Drawing.Point(236, 371);
            this.labelReservasEncontradas.Name = "labelReservasEncontradas";
            this.labelReservasEncontradas.Size = new System.Drawing.Size(15, 17);
            this.labelReservasEncontradas.TabIndex = 24;
            this.labelReservasEncontradas.Text = "0";
            // 
            // btnDeletarReserva
            // 
            this.btnDeletarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.btnDeletarReserva.Enabled = false;
            this.btnDeletarReserva.FlatAppearance.BorderSize = 0;
            this.btnDeletarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarReserva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnDeletarReserva.Location = new System.Drawing.Point(37, 401);
            this.btnDeletarReserva.Name = "btnDeletarReserva";
            this.btnDeletarReserva.Size = new System.Drawing.Size(127, 28);
            this.btnDeletarReserva.TabIndex = 4;
            this.btnDeletarReserva.Text = "Cancelar Reserva";
            this.btnDeletarReserva.UseVisualStyleBackColor = false;
            this.btnDeletarReserva.Click += new System.EventHandler(this.btnDeletarReserva_Click);
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.btnEditarReserva.Enabled = false;
            this.btnEditarReserva.FlatAppearance.BorderSize = 0;
            this.btnEditarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarReserva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEditarReserva.Location = new System.Drawing.Point(170, 401);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(127, 28);
            this.btnEditarReserva.TabIndex = 5;
            this.btnEditarReserva.Text = "Editar Reserva";
            this.btnEditarReserva.UseVisualStyleBackColor = false;
            this.btnEditarReserva.Click += new System.EventHandler(this.btnEditarReserva_Click);
            // 
            // ConsultarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditarReserva);
            this.Controls.Add(this.btnDeletarReserva);
            this.Controls.Add(this.labelReservasEncontradas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagridReservas);
            this.Controls.Add(this.btnBuscarHospede);
            this.Controls.Add(this.txbBuscarNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Name = "ConsultarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrar Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.datagridReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBuscarNome;
        private System.Windows.Forms.Button btnBuscarHospede;
        private System.Windows.Forms.DataGridView datagridReservas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelReservasEncontradas;
        private System.Windows.Forms.Button btnDeletarReserva;
        private System.Windows.Forms.Button btnEditarReserva;
    }
}
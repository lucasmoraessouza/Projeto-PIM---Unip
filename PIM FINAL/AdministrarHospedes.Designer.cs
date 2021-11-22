namespace PIM_FINAL
{
    partial class AdministrarHospedes
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
            this.btnAdicionarHospede = new System.Windows.Forms.Button();
            this.btnDeletarHospede = new System.Windows.Forms.Button();
            this.txbFiltroNome = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dataGridListagemHospedes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.Label();
            this.btnEditarHospede = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListagemHospedes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(222, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrar Hospedes";
            // 
            // btnAdicionarHospede
            // 
            this.btnAdicionarHospede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.btnAdicionarHospede.FlatAppearance.BorderSize = 0;
            this.btnAdicionarHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarHospede.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarHospede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAdicionarHospede.Location = new System.Drawing.Point(12, 342);
            this.btnAdicionarHospede.Name = "btnAdicionarHospede";
            this.btnAdicionarHospede.Size = new System.Drawing.Size(185, 33);
            this.btnAdicionarHospede.TabIndex = 4;
            this.btnAdicionarHospede.Text = "Adicionar Hospede";
            this.btnAdicionarHospede.UseVisualStyleBackColor = false;
            this.btnAdicionarHospede.Click += new System.EventHandler(this.btnAdicionarHospede_Click);
            // 
            // btnDeletarHospede
            // 
            this.btnDeletarHospede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.btnDeletarHospede.Enabled = false;
            this.btnDeletarHospede.FlatAppearance.BorderSize = 0;
            this.btnDeletarHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarHospede.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarHospede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnDeletarHospede.Location = new System.Drawing.Point(12, 395);
            this.btnDeletarHospede.Name = "btnDeletarHospede";
            this.btnDeletarHospede.Size = new System.Drawing.Size(185, 33);
            this.btnDeletarHospede.TabIndex = 6;
            this.btnDeletarHospede.Text = "Deletar Hospede";
            this.btnDeletarHospede.UseVisualStyleBackColor = false;
            this.btnDeletarHospede.Click += new System.EventHandler(this.btnDeletarHospede_Click);
            // 
            // txbFiltroNome
            // 
            this.txbFiltroNome.Location = new System.Drawing.Point(12, 74);
            this.txbFiltroNome.Multiline = true;
            this.txbFiltroNome.Name = "txbFiltroNome";
            this.txbFiltroNome.Size = new System.Drawing.Size(660, 23);
            this.txbFiltroNome.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button3.Location = new System.Drawing.Point(703, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 26);
            this.button3.TabIndex = 7;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnListar.Location = new System.Drawing.Point(673, 74);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(89, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "&Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dataGridListagemHospedes
            // 
            this.dataGridListagemHospedes.AllowUserToAddRows = false;
            this.dataGridListagemHospedes.AllowUserToDeleteRows = false;
            this.dataGridListagemHospedes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dataGridListagemHospedes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridListagemHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListagemHospedes.Location = new System.Drawing.Point(12, 103);
            this.dataGridListagemHospedes.Name = "dataGridListagemHospedes";
            this.dataGridListagemHospedes.ReadOnly = true;
            this.dataGridListagemHospedes.RowTemplate.Height = 25;
            this.dataGridListagemHospedes.Size = new System.Drawing.Size(755, 233);
            this.dataGridListagemHospedes.TabIndex = 3;
            this.dataGridListagemHospedes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridListagemHospedes_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(516, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total de hóspedes encontrado: ";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.AutoSize = true;
            this.txtValorTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtValorTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.txtValorTotal.Location = new System.Drawing.Point(742, 339);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(19, 21);
            this.txtValorTotal.TabIndex = 12;
            this.txtValorTotal.Text = "0";
            // 
            // btnEditarHospede
            // 
            this.btnEditarHospede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(222)))));
            this.btnEditarHospede.Enabled = false;
            this.btnEditarHospede.FlatAppearance.BorderSize = 0;
            this.btnEditarHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarHospede.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarHospede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEditarHospede.Location = new System.Drawing.Point(249, 342);
            this.btnEditarHospede.Name = "btnEditarHospede";
            this.btnEditarHospede.Size = new System.Drawing.Size(185, 33);
            this.btnEditarHospede.TabIndex = 5;
            this.btnEditarHospede.Text = "Editar Hospede";
            this.btnEditarHospede.UseVisualStyleBackColor = false;
            this.btnEditarHospede.Click += new System.EventHandler(this.btnEditarHospede_Click);
            // 
            // AdministrarHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditarHospede);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dataGridListagemHospedes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txbFiltroNome);
            this.Controls.Add(this.btnDeletarHospede);
            this.Controls.Add(this.btnAdicionarHospede);
            this.Controls.Add(this.label1);
            this.Name = "AdministrarHospedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Hospedes";
            this.Load += new System.EventHandler(this.AdministrarHospedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListagemHospedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionarHospede;
        private System.Windows.Forms.Button btnDeletarHospede;
        private System.Windows.Forms.TextBox txbFiltroNome;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dataGridListagemHospedes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtValorTotal;
        private System.Windows.Forms.Button btnEditarHospede;
    }
}
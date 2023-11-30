namespace ListaDeCompras
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.grbInserir = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.lblEdiPrioridade = new System.Windows.Forms.Label();
            this.lblEdiQuantidade = new System.Windows.Forms.Label();
            this.lblEdiNome = new System.Windows.Forms.Label();
            this.cmbEdiPrio = new System.Windows.Forms.ComboBox();
            this.txbEdiQuantidade = new System.Windows.Forms.TextBox();
            this.txbEdiNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.grbInserir.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(111, 38);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 0;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(111, 85);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txbQuantidade.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(24, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(6, 85);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(91, 16);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridade.Location = new System.Drawing.Point(6, 126);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(83, 16);
            this.lblPrioridade.TabIndex = 4;
            this.lblPrioridade.Text = "prioridade:";
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Items.AddRange(new object[] {
            "alta",
            "media",
            "baixa"});
            this.cmbPrioridade.Location = new System.Drawing.Point(96, 126);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(121, 21);
            this.cmbPrioridade.TabIndex = 6;
            // 
            // dgvLista
            // 
            this.dgvLista.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(390, 39);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(588, 302);
            this.dgvLista.TabIndex = 8;
            this.dgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // grbInserir
            // 
            this.grbInserir.Controls.Add(this.btnInserir);
            this.grbInserir.Controls.Add(this.cmbPrioridade);
            this.grbInserir.Controls.Add(this.lblPrioridade);
            this.grbInserir.Controls.Add(this.lblQuantidade);
            this.grbInserir.Controls.Add(this.lblNome);
            this.grbInserir.Controls.Add(this.txbQuantidade);
            this.grbInserir.Controls.Add(this.txbNome);
            this.grbInserir.Location = new System.Drawing.Point(7, 12);
            this.grbInserir.Name = "grbInserir";
            this.grbInserir.Size = new System.Drawing.Size(316, 198);
            this.grbInserir.TabIndex = 9;
            this.grbInserir.TabStop = false;
            this.grbInserir.Text = "groupBox1";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInserir.Location = new System.Drawing.Point(111, 170);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(106, 22);
            this.btnInserir.TabIndex = 18;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.lblEdiPrioridade);
            this.grbEditar.Controls.Add(this.lblEdiQuantidade);
            this.grbEditar.Controls.Add(this.lblEdiNome);
            this.grbEditar.Controls.Add(this.cmbEdiPrio);
            this.grbEditar.Controls.Add(this.txbEdiQuantidade);
            this.grbEditar.Controls.Add(this.txbEdiNome);
            this.grbEditar.Controls.Add(this.button1);
            this.grbEditar.Location = new System.Drawing.Point(15, 239);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(307, 242);
            this.grbEditar.TabIndex = 16;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "groupBox2";
            // 
            // lblEdiPrioridade
            // 
            this.lblEdiPrioridade.AutoSize = true;
            this.lblEdiPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdiPrioridade.Location = new System.Drawing.Point(14, 125);
            this.lblEdiPrioridade.Name = "lblEdiPrioridade";
            this.lblEdiPrioridade.Size = new System.Drawing.Size(83, 16);
            this.lblEdiPrioridade.TabIndex = 7;
            this.lblEdiPrioridade.Text = "prioridade:";
            // 
            // lblEdiQuantidade
            // 
            this.lblEdiQuantidade.AutoSize = true;
            this.lblEdiQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdiQuantidade.Location = new System.Drawing.Point(6, 86);
            this.lblEdiQuantidade.Name = "lblEdiQuantidade";
            this.lblEdiQuantidade.Size = new System.Drawing.Size(91, 16);
            this.lblEdiQuantidade.TabIndex = 7;
            this.lblEdiQuantidade.Text = "Quantidade:";
            // 
            // lblEdiNome
            // 
            this.lblEdiNome.AutoSize = true;
            this.lblEdiNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdiNome.Location = new System.Drawing.Point(16, 47);
            this.lblEdiNome.Name = "lblEdiNome";
            this.lblEdiNome.Size = new System.Drawing.Size(52, 16);
            this.lblEdiNome.TabIndex = 7;
            this.lblEdiNome.Text = "Nome:";
            // 
            // cmbEdiPrio
            // 
            this.cmbEdiPrio.FormattingEnabled = true;
            this.cmbEdiPrio.Items.AddRange(new object[] {
            "alta",
            "media",
            "baixa"});
            this.cmbEdiPrio.Location = new System.Drawing.Point(103, 125);
            this.cmbEdiPrio.Name = "cmbEdiPrio";
            this.cmbEdiPrio.Size = new System.Drawing.Size(121, 21);
            this.cmbEdiPrio.TabIndex = 7;
            // 
            // txbEdiQuantidade
            // 
            this.txbEdiQuantidade.Location = new System.Drawing.Point(103, 86);
            this.txbEdiQuantidade.Name = "txbEdiQuantidade";
            this.txbEdiQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txbEdiQuantidade.TabIndex = 7;
            // 
            // txbEdiNome
            // 
            this.txbEdiNome.Location = new System.Drawing.Point(103, 43);
            this.txbEdiNome.Name = "txbEdiNome";
            this.txbEdiNome.Size = new System.Drawing.Size(100, 20);
            this.txbEdiNome.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(103, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemover.Location = new System.Drawing.Point(348, 349);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(178, 66);
            this.btnRemover.TabIndex = 17;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 537);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbInserir);
            this.Controls.Add(this.dgvLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.grbInserir.ResumeLayout(false);
            this.grbInserir.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox grbInserir;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Label lblEdiPrioridade;
        private System.Windows.Forms.Label lblEdiQuantidade;
        private System.Windows.Forms.Label lblEdiNome;
        private System.Windows.Forms.ComboBox cmbEdiPrio;
        private System.Windows.Forms.TextBox txbEdiQuantidade;
        private System.Windows.Forms.TextBox txbEdiNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnInserir;
    }
}


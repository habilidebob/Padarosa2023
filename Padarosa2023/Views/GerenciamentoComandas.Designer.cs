namespace Padarosa2023.Views
{
    partial class GerenciamentoComandas
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
            this.pibIcone = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbInfos = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.lblComanda = new System.Windows.Forms.Label();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbInfos.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pibIcone
            // 
            this.pibIcone.Image = global::Padarosa2023.Properties.Resources.order;
            this.pibIcone.Location = new System.Drawing.Point(69, 508);
            this.pibIcone.Margin = new System.Windows.Forms.Padding(7);
            this.pibIcone.Name = "pibIcone";
            this.pibIcone.Size = new System.Drawing.Size(186, 105);
            this.pibIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIcone.TabIndex = 0;
            this.pibIcone.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(285, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(329, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciamento de Comandas";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(348, 72);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(510, 517);
            this.dgvProdutos.TabIndex = 2;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbInfos
            // 
            this.grbInfos.Controls.Add(this.btnContinuar);
            this.grbInfos.Controls.Add(this.txbCodProduto);
            this.grbInfos.Controls.Add(this.lblCodProduto);
            this.grbInfos.Controls.Add(this.txbComanda);
            this.grbInfos.Controls.Add(this.lblComanda);
            this.grbInfos.Location = new System.Drawing.Point(12, 72);
            this.grbInfos.Name = "grbInfos";
            this.grbInfos.Size = new System.Drawing.Size(330, 199);
            this.grbInfos.TabIndex = 3;
            this.grbInfos.TabStop = false;
            this.grbInfos.Text = "Informações";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Location = new System.Drawing.Point(24, 133);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(282, 38);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Location = new System.Drawing.Point(176, 88);
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(130, 33);
            this.txbCodProduto.TabIndex = 3;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(19, 88);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(151, 29);
            this.lblCodProduto.TabIndex = 2;
            this.lblCodProduto.Text = "Cód Produto:";
            // 
            // txbComanda
            // 
            this.txbComanda.Location = new System.Drawing.Point(176, 43);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(130, 33);
            this.txbComanda.TabIndex = 1;
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Location = new System.Drawing.Point(19, 43);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(119, 29);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda:";
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.btnCancelar);
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Controls.Add(this.txbQuantidade);
            this.grbLancamento.Controls.Add(this.lblQuantidade);
            this.grbLancamento.Controls.Add(this.txbProduto);
            this.grbLancamento.Controls.Add(this.lblProduto);
            this.grbLancamento.Enabled = false;
            this.grbLancamento.Location = new System.Drawing.Point(12, 277);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(330, 221);
            this.grbLancamento.TabIndex = 5;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamento";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLancar.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.Location = new System.Drawing.Point(24, 133);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(282, 38);
            this.btnLancar.TabIndex = 4;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(176, 88);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(130, 33);
            this.txbQuantidade.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(19, 88);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(143, 29);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txbProduto
            // 
            this.txbProduto.Location = new System.Drawing.Point(176, 43);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.ReadOnly = true;
            this.txbProduto.Size = new System.Drawing.Size(130, 33);
            this.txbProduto.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(19, 43);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(103, 29);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(24, 177);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(282, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // GerenciamentoComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 629);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.pibIcone);
            this.Controls.Add(this.grbInfos);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "GerenciamentoComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Comandas";
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbInfos.ResumeLayout(false);
            this.grbInfos.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibIcone;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbInfos;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnCancelar;
    }
}
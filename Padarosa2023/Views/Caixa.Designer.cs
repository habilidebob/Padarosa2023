namespace Padarosa2023.Views
{
    partial class Caixa
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvFicha = new System.Windows.Forms.DataGridView();
            this.lblComanda = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chbPagamentoRecebido = new System.Windows.Forms.CheckBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFicha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(603, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(241, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Caixa :: Padarosa";
            // 
            // dgvFicha
            // 
            this.dgvFicha.BackgroundColor = System.Drawing.Color.White;
            this.dgvFicha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFicha.Location = new System.Drawing.Point(12, 108);
            this.dgvFicha.Name = "dgvFicha";
            this.dgvFicha.Size = new System.Drawing.Size(832, 286);
            this.dgvFicha.TabIndex = 1;
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(74, 29);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(195, 37);
            this.lblComanda.TabIndex = 2;
            this.lblComanda.Text = "Nº Comanda:";
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(275, 29);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(144, 47);
            this.txbComanda.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Padarosa2023.Properties.Resources.cashier;
            this.pictureBox1.Location = new System.Drawing.Point(105, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(490, 407);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(277, 88);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // chbPagamentoRecebido
            // 
            this.chbPagamentoRecebido.AutoSize = true;
            this.chbPagamentoRecebido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbPagamentoRecebido.Location = new System.Drawing.Point(505, 510);
            this.chbPagamentoRecebido.Name = "chbPagamentoRecebido";
            this.chbPagamentoRecebido.Size = new System.Drawing.Size(239, 30);
            this.chbPagamentoRecebido.TabIndex = 7;
            this.chbPagamentoRecebido.Text = "Pagamento Recebido";
            this.chbPagamentoRecebido.UseVisualStyleBackColor = true;
            this.chbPagamentoRecebido.CheckedChanged += new System.EventHandler(this.chbPagamentoRecebido_CheckedChanged);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncerrar.Location = new System.Drawing.Point(505, 563);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(301, 57);
            this.btnEncerrar.TabIndex = 8;
            this.btnEncerrar.Text = "Encerrar Comanda";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::Padarosa2023.Properties.Resources.magnifying_glass;
            this.btnBuscar.Location = new System.Drawing.Point(425, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(42, 37);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 632);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.chbPagamentoRecebido);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbComanda);
            this.Controls.Add(this.lblComanda);
            this.Controls.Add(this.dgvFicha);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFicha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvFicha;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chbPagamentoRecebido;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.PictureBox btnBuscar;
    }
}
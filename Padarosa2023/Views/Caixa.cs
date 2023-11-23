using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa2023.Views
{
    public partial class Caixa : Form
    {
        Classes.Usuario usuario;
        public Caixa(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verificar se o txb está vazio:
            if(txbComanda.Text != "")
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(txbComanda.Text);
                var r = ordem.BuscarFicha();
                // Verificar se existem itens na comanda:
                if(r.Rows.Count > 0)
                {
                    dgvFicha.DataSource = r;
                    // Atualizar o valor total:
                    lblTotal.Text = "R$ " + r.Compute("SUM(Total_Item)", "True").ToString();
                }
                else
                {
                    MessageBox.Show("Não existem lançamentos nessa comanda!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar o dgv
                    dgvFicha.DataSource = null;
                    lblTotal.Text = "R$ 0,00";
                    txbComanda.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("Digite o número da ficha!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbPagamentoRecebido_CheckedChanged(object sender, EventArgs e)
        {
            // Ativar/desativar btn de acordo com o checked:
            btnEncerrar.Enabled = chbPagamentoRecebido.Checked;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja encerrar?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(txbComanda.Text);
                if(ordem.EncerrarFicha() == true)
                {
                    MessageBox.Show("Ficha encerrada!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar:
                    txbComanda.Clear();
                    dgvFicha.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a ficha!", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

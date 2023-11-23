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
    public partial class GerenciamentoComandas : Form
    {
        // Globais:
        Classes.Usuario usuario;
        public GerenciamentoComandas(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            // Mudar o título da janela:
            this.Text = "Gerenciamento Comandas - " +
                "Logado como: " + usuario.NomeCompleto.ToUpper();

            // Popular o DGV com os dados da tabela de produtos:
            Classes.Produto produto = new Classes.Produto();
            dgvProdutos.DataSource = produto.ListarTudo();

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Verificar se o numero da comanda e cod do produto não
            // estão vazios:
            if(txbComanda.Text != "" && txbCodProduto.Text != "")
            {
                grbLancamento.Enabled = true;
                grbInfos.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;
            var linha = dgvProdutos.Rows[linhaSelecionada];

            // Popular os txbs com os valores do dgv
            txbCodProduto.Text = linha.Cells[0].Value.ToString();
            txbProduto.Text = linha.Cells[1].Value.ToString();
            
        }

        private void LimparTudo()
        {
            // Limpar os campos:
            txbCodProduto.Clear();
            txbComanda.Clear();
            txbProduto.Clear();
            txbQuantidade.Clear();

            // Resetar os grbs:
            grbInfos.Enabled = true;
            grbLancamento.Enabled = false;
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if(txbQuantidade.Text != "")
            {
                var r = MessageBox.Show("Tem certeza que deseja lançar?", "Aviso!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                    // Obter os valores dos campos:
                    ordem.IdFicha = int.Parse(txbComanda.Text);
                    ordem.IdProduto = int.Parse(txbCodProduto.Text);
                    ordem.Quantidade = int.Parse(txbQuantidade.Text);
                    ordem.IdResponsavel = usuario.Id;
                    // Efetuar o cadastro:
                    if (ordem.NovoLancamento() == true)
                    {
                        MessageBox.Show("Lançamento efetuado!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparTudo();
                    }
                    else
                    {
                        MessageBox.Show("Falha no lançamento!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimparTudo();
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe a quantidade!","Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }
    }
}

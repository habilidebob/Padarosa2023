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
    public partial class GerenciamentoProdutos : Form
    {
        // Global:
        Classes.Usuario usuario = new Classes.Usuario();
        public GerenciamentoProdutos(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            lblUsuarioLogado.Text = $"Olá, {usuario.NomeCompleto}!";
        }
    }
}
